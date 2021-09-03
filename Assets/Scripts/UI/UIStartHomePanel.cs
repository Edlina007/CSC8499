using UnityEngine;
using UnityEngine.UI;
using QFramework;
using Vuforia;
/********************************************************************************

** Class name:UIStartHomePanelData

** Description: Home UI data

** Author: Ting Zhang

** Created: 2021-8-17

*********************************************************************************/
namespace QFramework
{
	public class UIStartHomePanelData : UIPanelData
	{
		public ImageTargetBehaviour _ImageTarget;
	}
	public partial class UIStartHomePanel : UIPanel
	{
		protected override void ProcessMsg(int eventId, QMsg msg)
		{
			throw new System.NotImplementedException();
		}
		
		protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as UIStartHomePanelData ?? new UIStartHomePanelData();
			// please add init code here
			BtnStart.onClick.AddListener(() =>
			{
				//允许二维码被识别
				mData._ImageTarget.enabled = true;
				GameManager.Instance.OpenOrCloseVuforia(true);
				
				UIKit.OpenPanel<UIScanPanel>();
				CloseSelf();
			});
		}
		
		protected override void OnOpen(IUIData uiData = null)
		{
		}
		
		protected override void OnShow()
		{
		}
		
		protected override void OnHide()
		{
		}
		
		protected override void OnClose()
		{
		}
	}
}
