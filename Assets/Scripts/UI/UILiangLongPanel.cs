using HedgehogTeam.EasyTouch;
using UnityEngine;
using UnityEngine.UI;
using QFramework;
/********************************************************************************

** Class name:UILiangLongPanelData

** Description: UI data class for Diplodocus

** Author: Ting Zhang

** Created: 2021-8-16

*********************************************************************************/
namespace QFramework
{
	public class UILiangLongPanelData : UIPanelData
	{public string _idName;
		public QuickTap _quicktap;
	}
	public partial class UILiangLongPanel : UIPanel
	{
		protected override void ProcessMsg(int eventId, QMsg msg)
		{
			throw new System.NotImplementedException();
		}
		
		protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as UILiangLongPanelData ?? new UILiangLongPanelData();
			// please add init code here
			InfoPanel.gameObject.SetActive(false);
			mData._quicktap.onTap.AddListener((ges) =>
			{
				Debug.Log("双击");
				InfoPanel.gameObject.SetActive(true);
				ImgVideo.Play();
			});
			
			BtnClose.onClick.AddListener(() =>
			{
				ImgVideo.Stop();
				InfoPanel.gameObject.SetActive(false);
				GameManager.lianglong = true;
			});
			BtnBack.onClick.AddListener(() =>
			{
				UIKit.OpenPanel<UI3DBookShelfPanel>();
				BookManager.Instance.OpenTargetImageable(mData._idName,false);
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
