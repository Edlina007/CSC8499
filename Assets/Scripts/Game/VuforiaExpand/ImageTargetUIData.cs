using UnityEngine;

/// <summary>
/// 答题类型识别图
/// </summary>
    public class ImageTargetUIData :  TrackableEventHandler
    {
        public Animator _ani;
        protected override void Start()
        {
            base.Start();
            TrackAbleType = ETrackAbleType.UIData;
           // _ani = GetComponentInChildren<Animator>();
        }
    /// <summary>
    /// 控制动画播放
    /// </summary>
    /// <param name="va"></param>
        public void AnimatorPlayOrPause(bool va)
        {
            Debug.Log("动画播放"+_ani.name);
            _ani.SetBool("play",va);
        } 
    }