using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;

public class ImageTargetBookQRCode : TrackableEventHandler
{
    protected override void Start()
    {
        base.Start();
        TrackAbleType = ETrackAbleType.QRCode;
    }

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
       
        
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
    }
}
