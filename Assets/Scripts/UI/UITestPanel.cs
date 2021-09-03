using UnityEngine;
using UnityEngine.UI;
using QFramework;
/********************************************************************************

** Class name:UITestPanelData

** Description: UI for displaying test data

** Author: Ting Zhang

** Created: 2021-8-17

*********************************************************************************/
namespace QFramework
{
	public class UITestPanelData : UIPanelData
	{
	}
	public partial class UITestPanel : UIPanel
	{
		protected override void ProcessMsg(int eventId, QMsg msg)
		{
			throw new System.NotImplementedException();
		}
		
		protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as UITestPanelData ?? new UITestPanelData();
			// please add init code here
			TogCtroVuforia.onValueChanged.AddListener(va =>
			{
				GameManager.Instance.OpenOrCloseVuforia(va);
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
