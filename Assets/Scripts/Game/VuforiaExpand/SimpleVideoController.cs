using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SimpleVideoController : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    // Start is called before the first frame update
    void Awake()
    {
        //初始化
        videoPlayer = GetComponent<VideoPlayer>();
        //注册 错误检查事件
        videoPlayer.errorReceived += HandleVideoError;
        //注册视频播放完毕事件
        videoPlayer.loopPointReached += HandleLoopPointReached;
        
    }
//重新播放视频
    public void RestartPlay()
    {
        //播放视频
        videoPlayer.Play();
        //打开音乐
        PauseAudio(false);
        //开启视频背景墙
        videoPlayer.GetComponent<MeshRenderer>().enabled=true;
    }
    //暂停视频
    public void Pause()
    {
        //如果视屏播放器组件 不为空
        if (videoPlayer)
        {
            Debug.Log("Pause Video");
            //暂停音乐
            PauseAudio(true);
            //暂停视频
            videoPlayer.Pause();
        }
    }
    //停止播放视频
    public void Stop()
    {
        //暂停视频
        videoPlayer.Pause();
        //停止视频
        videoPlayer.Stop();
        //关闭视频背景墙
        videoPlayer.GetComponent<MeshRenderer>().enabled=false;
    }
    // 参数为true 暂停音乐  参数为false  开启音乐
    private void PauseAudio(bool pause)
    {
        //视屏播放器有几个audio模块
        for (ushort trackNumber = 0; trackNumber < videoPlayer.audioTrackCount; ++trackNumber)
        {
            if (pause)
                videoPlayer.GetTargetAudioSource(trackNumber).Pause();
            else
                videoPlayer.GetTargetAudioSource(trackNumber).UnPause();
        }
    }
    //程序暂停
    void OnApplicationPause(bool pause)
    {
        Debug.Log("OnApplicationPause(" + pause + ") called.");
        if (pause)
            Pause();
    }
    //错误检查
    void HandleVideoError(VideoPlayer video, string errorMsg)
    {
        Debug.LogError("Error: " + video.clip.name + "\nError Message: " + errorMsg);
    }
   //视屏播放结束
    void HandleLoopPointReached(VideoPlayer video)
    {
        Debug.Log("播放完毕: " + video.clip.name);
        //停止播放视频
       Stop();
    }
   
}
