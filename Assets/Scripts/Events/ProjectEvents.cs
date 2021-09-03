
using UnityEngine;
/********************************************************************************

** Class name: ProjectEvents

** Description: ProjectEvents

** Author: Ting Zhang

** Created: 2021-8-16

*********************************************************************************/
namespace QFramework
{
     public class ProjectEvents
    {

    }

     /// <summary>
     /// 图片被识别后触发的事件
     /// </summary>
     public class EventTrackableActive
     {
         public string _idName;
         public ETrackAbleType eTrackAbleType;
         public GameObject imageTarget;
     }

     /// <summary>
     /// 点击按钮 根据IdName 打开某个图片的识别功能
     /// </summary>
     public class EventOpenImagetTrackable
     {
         public string _idName;
     }
}