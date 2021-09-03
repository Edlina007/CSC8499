using System;
using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;
using Vuforia;

/********************************************************************************

** Class name: GameManager

** Description: GameManager

** Author: Ting Zhang

** Created: 2021-8-15

*********************************************************************************/
[MonoSingletonPath("Managers/GameManager")]
public class GameManager : MonoSingleton<GameManager>
{
    public VuforiaBehaviour _VuforiaBehaviour;

    public static bool bawanglong;
    public static bool sanjiaolong;
    public static bool lianglong;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    /// <summary>
    /// Turn Vuforia on or off Identify function Identify function
    /// </summary>
    public void OpenOrCloseVuforia(bool va)
    {
        // Check if Vuforia has been initialised before operation tracking recognition

        if (Vuforia.VuforiaManager.Instance.Initialized)
        {
            // _VuforiaBehaviour.enabled = va;
            if (va)
            {
                // Camera starts taking images
                Vuforia.CameraDevice.Instance.Start();
                // Start tracking target (start identification)
                Vuforia.TrackerManager.Instance.GetTracker<Vuforia.ObjectTracker>().Start();
            }
            else
            {
                // Camera stops image
                Vuforia.CameraDevice.Instance.Stop();
                // Stops tracking the target (stops recognition)
                Vuforia.TrackerManager.Instance.GetTracker<Vuforia.ObjectTracker>().Stop();
            }
        }
      
      
    }
    /// <summary>
    /// Turn on recognition of the specified image or turn off recognition Recognition function
    /// </summary>
    public void OpenOrCloseImageTargetable(ImageTargetBehaviour trackableEventHandler,bool va)
    {
        
        trackableEventHandler.enabled = va;
    }
   
}