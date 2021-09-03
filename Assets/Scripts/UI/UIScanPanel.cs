using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using QFramework;
/********************************************************************************

** Class name:UIScanPanelData

** Description: Scan UI interface

** Author: Ting Zhang

** Created: 2021-8-17

*********************************************************************************/
namespace QFramework
{
	public class UIScanPanelData : UIPanelData
	{
		public string _idName;
	}
	public partial class UIScanPanel : UIPanel
	{
		protected override void ProcessMsg(int eventId, QMsg msg)
		{
			throw new System.NotImplementedException();
		}
		
		protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as UIScanPanelData ?? new UIScanPanelData();
			// please add init code here
			BGPanel.alpha = 0;
			ImgScan.DOPlayForward();
			BGPanel.DOFade(BGPanel.alpha > 0.5f ? 0 : 1, 0.2f).SetAutoKill(true);
			TypeEventSystem.Global.Register<EventTrackableActive>(OnTrackableActive);
		}

		private void OnTrackableActive(EventTrackableActive obj)
		{
			BGPanel.DOFade(BGPanel.alpha > 0.5f ? 0 : 1, 0.2f).SetAutoKill(true).OnComplete(CloseSelf);
			// if (obj._idName==mData._idName)
			// {
			// 	
			// }
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
			ImgScan.DOKill();
			TypeEventSystem.Global.UnRegister<EventTrackableActive>(OnTrackableActive);
		}
	}
}
