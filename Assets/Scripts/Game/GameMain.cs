using System;
using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;
/********************************************************************************

** Class name: GameMain

** Description: GameMain

** Author: Ting Zhang

** Created: 2021-8-15

*********************************************************************************/
public class GameMain : MonoBehaviour
{
    public VuforiaBehaviour _VuforiaBehaviour;
    public ImageTargetBookQRCode qrCode;

    private void Awake()
    {
        GameManager.Instance._VuforiaBehaviour = this._VuforiaBehaviour;
        _VuforiaBehaviour.StartEvent += () =>
        {
           // _VuforiaBehaviour.enabled = false;
           GameManager.Instance.OpenOrCloseVuforia(false);
        };
        qrCode.GetComponent<ImageTargetBehaviour>().enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        //Resource initialization
        ResKit.Init();
        UIKit.OpenPanel<UIStartHomePanel>(new UIStartHomePanelData(){_ImageTarget = qrCode.GetComponent<ImageTargetBehaviour>()});
        qrCode.onTrackingFound += () =>
        {
            Debug.Log("识别书本成功");
            //After successful recognition of a book QR code Turn off recognition
            //  GameManager.Instance.OpenOrCloseVuforia(false);
            SceneManager.LoadScene("Book");
            //打开3dbookPanel
            UIKit.OpenPanel<UI3DBookShelfPanel>();
        };
    }
}