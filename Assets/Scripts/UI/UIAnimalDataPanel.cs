using UnityEngine;
using UnityEngine.UI;
using QFramework;
/********************************************************************************

** Class name:UIAnimalDataPanelData

** Description: UI class for displaying animal data

** Author: Ting Zhang

** Created: 2021-8-15

*********************************************************************************/
namespace QFramework
{
	public class UIAnimalDataPanelData : UIPanelData
	{
	}
	public partial class UIAnimalDataPanel : UIPanel
	{
		protected override void ProcessMsg(int eventId, QMsg msg)
		{
			throw new System.NotImplementedException();
		}
		
		protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as UIAnimalDataPanelData ?? new UIAnimalDataPanelData();
			// please add init code here
			BtnBack.onClick.AddListener(() =>
			{
				UIKit.OpenPanel<UI3DBookShelfPanel>();
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
