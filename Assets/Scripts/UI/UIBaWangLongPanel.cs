using UnityEngine;
using UnityEngine.UI;
using QFramework;
/********************************************************************************

** Class name:UIBaWangLongPanelData

** Description: UI data class for Tyrannosaurus rex

** Author: Ting Zhang

** Created: 2021-8-15

*********************************************************************************/
namespace QFramework
{
	public class UIBaWangLongPanelData : UIPanelData
	{
		public string _idName;
	}
	public partial class UIBaWangLongPanel : UIPanel
	{
		protected override void ProcessMsg(int eventId, QMsg msg)
		{
			throw new System.NotImplementedException();
		}
		
		protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as UIBaWangLongPanelData ?? new UIBaWangLongPanelData();
			BGPanel.gameObject.SetActive(false);
			
			BtnOpenBG.onClick.AddListener(()=>{
				BGPanel.gameObject.SetActive(true);
			});
			// please add init code here
			BtnClose.onClick.AddListener(() =>
			{
				BGPanel.gameObject.SetActive(false);
				GameManager.bawanglong = true;
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
