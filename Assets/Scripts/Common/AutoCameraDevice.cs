using UnityEngine;
using Vuforia;

/********************************************************************************

** Class name: AutoCameraDevice

** Description: AutoCameraDevice

** Author: Ting Zhang

** Created: 2021-8-16

*********************************************************************************/
public class AutoCameraDevice : MonoBehaviour
{
    void Start()

    {
        CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }

    void Update()

    {
        //自动对焦 

        //if (m_bIsFocus)

#if UNITY_EDITOR

        if (Input.GetMouseButtonUp(0))
#elif UNITY_ANDROID || UNITY_IPHONE
if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
#endif

        {
            CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        }
    }
}