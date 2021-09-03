using HedgehogTeam.EasyTouch;
using UnityEngine;


public class ImageTargetVideo : TrackableEventHandler
{
    // public SimpleVideoController _simpleVideoC;
    // public VideoController _VideoC;

    public QuickTap _QuickTap;
    protected override void Awake()
    {
        // _simpleVideoC = transform.GetComponentInChildren<SimpleVideoController>();
        // _VideoC = transform.GetComponentInChildren<VideoController>();
        base.Awake();
        
    }

    protected override void Start()
    {
        base.Start();
        TrackAbleType = ETrackAbleType.Video;
    }

    // protected override void OnTrackingFound()
    // {
    //     //使用简单控制
    //     if (_simpleVideoC.enabled)
    //     {
    //         //播放
    //         _simpleVideoC.RestartPlay();
    //     }
    //
    //     base.OnTrackingFound();
    // }
    //
    // protected override void OnTrackingLost()
    // {
    //     //使用复杂控制
    //     if (_VideoC.enabled)
    //     {
    //         //暂停
    //         _VideoC.Pause();
    //     }
    //     else
    //     {
    //         //使用简单控制
    //         //停止
    //         _simpleVideoC.Stop();
    //     }
    //     base.OnTrackingLost();
    // }
}