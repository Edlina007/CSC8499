using System;
using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;

public class TrackableEventHandler : DefaultTrackableEventHandler
{
    public Action onTrackingFound;
    public Action onTrackingLost;

    protected ETrackAbleType TrackAbleType;

    private Transform[] childs;

    public string IdName;

    protected virtual void Awake()
    {
        childs = transform.GetComponentsInChildren<Transform>();
    }

    protected override void Start()
    {
        base.Start();
       
    }

    protected override void OnTrackingFound()
    {
        Debug.Log("识别到了图片");
        foreach (Transform child in childs)
        {
            if (child!=this.transform)
            {
                child.gameObject.SetActive(true);
            }
            
        }
        base.OnTrackingFound();
        
        onTrackingFound?.Invoke();
        TypeEventSystem.Global.Send<EventTrackableActive>(new EventTrackableActive(){_idName = IdName,eTrackAbleType = TrackAbleType,imageTarget = this.gameObject});
    }

    protected override void OnTrackingLost()
    {
        Debug.Log("识别图丢失");

        base.OnTrackingLost();
      
        onTrackingLost?.Invoke();
        foreach (Transform child in childs)
        {
            if (child != this.transform)
            {
                child.gameObject.SetActive(false);
            }
        }
    }
}
/// <summary>
/// 被识别图片需要展示的功能类型
/// </summary>
public enum ETrackAbleType
{
    Model,
    Video,
    UIData,
    QRCode
}
