using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;
using Vuforia;
/********************************************************************************

** Class name: BookManager

** Description: BookManager

** Author: Ting Zhang

** Created: 2021-8-15

*********************************************************************************/
public class BookManager : MonoSingleton<BookManager>
{
    public VuforiaBehaviour _VuforiaBehaviour;


    public List<TrackableEventHandler> _trackables;
    private void Awake()
    {
        GameManager.Instance._VuforiaBehaviour = this._VuforiaBehaviour;
        _VuforiaBehaviour.StartEvent += () =>
        {
          //  _VuforiaBehaviour.enabled = false;
          GameManager.Instance.OpenOrCloseVuforia(false);
        };
    }
    
    // Start is called before the first frame update
    void Start()
    {
        //Turn off all image recognition
        foreach (TrackableEventHandler trackable in _trackables)
        {
            GameManager.Instance.OpenOrCloseImageTargetable(trackable.GetComponent<ImageTargetBehaviour>(),false);
        }    
    }
    private void OnEnable()
    {
        TypeEventSystem.Global.Register<EventOpenImagetTrackable>(OpenImagetTrackable);
        TypeEventSystem.Global.Register<EventTrackableActive>(OnTrackableActive);
    }

    /// <summary>
    ///Open the corresponding UI panel if recognition is successful Answer by panel type video data
    /// </summary>
    /// <param name="obj"></param>
    private void OnTrackableActive(EventTrackableActive obj)
    {
        switch (obj._idName)
        {
            case "bawanglong":
                UIKit.OpenPanel<UIBaWangLongPanel>(new UIBaWangLongPanelData(){_idName = "bawanglong"});
                break;
            case "sanjiaolong":
                UIKit.OpenPanel<UISanJiaoLongPanel>(new UISanJiaoLongPanelData()
                {
                    _idName = "sanjiaolong",_ImageTargetUIData = obj.imageTarget.GetComponent<ImageTargetUIData>()
                });
                break;
            case "lianglong":
                UIKit.OpenPanel<UILiangLongPanel>(new UILiangLongPanelData()
                {
                    _idName = "lianglong",_quicktap = obj.imageTarget.GetComponent<ImageTargetVideo>()._QuickTap
                },prefabName:"resources://UILiangLongPanel");
                break;
        }
    }
    
    private void OpenImagetTrackable(EventOpenImagetTrackable obj)
    {
        //Turn on recognition
        GameManager.Instance.OpenOrCloseVuforia(true);
        //Turn on scanning
        UIKit.OpenPanel<UIScanPanel>();
        OpenTargetImageable(obj._idName,true);
    }

    private void OnDisable()
    {
        TypeEventSystem.Global.UnRegister<EventOpenImagetTrackable>(OpenImagetTrackable);
        TypeEventSystem.Global.UnRegister<EventTrackableActive>(OnTrackableActive);
    }

    /// <summary>
    /// Find the specified image recognition object in the list Turn recognition on or off
    /// </summary>
    /// <param name="idName"></param>
    public void OpenTargetImageable(string idName,bool va)
    {
       
        var imgTrackable=_trackables.Find(e => e.IdName == idName).GetComponent<ImageTargetBehaviour>();
        GameManager.Instance.OpenOrCloseImageTargetable(imgTrackable,va);
    }
}
