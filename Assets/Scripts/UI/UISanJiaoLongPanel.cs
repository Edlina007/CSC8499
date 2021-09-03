using UnityEngine;
using UnityEngine.UI;
using QFramework;
/********************************************************************************

** Class name:UISanJiaoLongPanelData

** Description: UI data class for Triceratops

** Author: Ting Zhang

** Created: 2021-8-16

*********************************************************************************/
namespace QFramework
{
	public class UISanJiaoLongPanelData : UIPanelData
	{
		public string _idName;
		public ImageTargetUIData _ImageTargetUIData;
	}
	public partial class UISanJiaoLongPanel : UIPanel
	{
		protected override void ProcessMsg(int eventId, QMsg msg)
		{
			throw new System.NotImplementedException();
		}
		
		protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as UISanJiaoLongPanelData ?? new UISanJiaoLongPanelData();
			// please add init code here
			InfoPanel.gameObject.SetActive(false);
			ShowMsgPanel.gameObject.SetActive(false);
			BtnOpenBG.gameObject.SetActive(true);
			
			
			
			BtnOpenBG.onClick.AddListener(()=>{
				Debug.Log("Clicked");
				mData._ImageTargetUIData.AnimatorPlayOrPause(true);
				BtnOpenBG.gameObject.SetActive(false);
				this.Delay(5, () =>
				{
					InfoPanel.gameObject.SetActive(true);
				});
			});
			// please add init code here
			BtnClose.onClick.AddListener(() =>
			{
				InfoPanel.gameObject.SetActive(false);
				ShowMsgPanel.gameObject.SetActive(false);
				BtnOpenBG.gameObject.SetActive(true);
				mData._ImageTargetUIData.AnimatorPlayOrPause(false);
				GameManager.sanjiaolong = true;
			});
			BtnBack.onClick.AddListener(() =>
			{
				UIKit.OpenPanel<UI3DBookShelfPanel>();
				BookManager.Instance.OpenTargetImageable(mData._idName,false);
				mData._ImageTargetUIData.AnimatorPlayOrPause(false);
				CloseSelf();
				BtnOpenBG.gameObject.SetActive(false);
			});
			BtnAffirm.onClick.AddListener(() =>
			{
				ShowMsgPanel.gameObject.SetActive(true);
				if (ToggleA.isOn)
				{
					TxtMsgBox.text = "Congratulations for the correct answer!";
				}
				else
				{
					TxtMsgBox.text = "wrong answer!";
				}
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
