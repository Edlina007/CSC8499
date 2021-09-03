using UnityEngine;
using UnityEngine.UI;
using QFramework;
/********************************************************************************

** Class name: UI3DBookShelfPanel

** Description: UI3DBookShelfPanel

** Author: Ting Zhang

** Created: 2021-8-15

*********************************************************************************/
namespace QFramework
{
	public class UI3DBookShelfPanelData : UIPanelData
	{
	}
	public partial class UI3DBookShelfPanel : UIPanel
	{
		public Color targetColor;
		protected override void ProcessMsg(int eventId, QMsg msg)
		{
			throw new System.NotImplementedException();
		}
		
		protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as UI3DBookShelfPanelData ?? new UI3DBookShelfPanelData();
			if (GameManager.bawanglong)
			{
				BtnAnimal1.GetComponent<BtnAnimal1>().BtnBookBg.color = targetColor;
				BtnAnimal1.GetComponent<BtnAnimal1>().TxtProces.text = "100%";
			}
			if (GameManager.sanjiaolong)
			{
				BtnSanJiaoLong.GetComponent<BtnAnimal1>().BtnBookBg.color = targetColor;
				BtnSanJiaoLong.GetComponent<BtnAnimal1>().TxtProces.text = "100%";
			}
			if (GameManager.lianglong)
			{
				BtnLiangLong.GetComponent<BtnAnimal1>().BtnBookBg.color = targetColor;
				BtnLiangLong.GetComponent<BtnAnimal1>().TxtProces.text = "100%";
			}
			// please add init code here
			BtnAnimal1.onClick.AddListener(() =>
			{
				CloseSelf();
				TypeEventSystem.Global.Send<EventOpenImagetTrackable>(new EventOpenImagetTrackable(){_idName = "bawanglong"});
			});
			BtnSanJiaoLong.onClick.AddListener(() =>
			{
				CloseSelf();
				TypeEventSystem.Global.Send<EventOpenImagetTrackable>(new EventOpenImagetTrackable(){_idName = "sanjiaolong"});
			});
			BtnLiangLong.onClick.AddListener(() =>
			{
				CloseSelf();
				TypeEventSystem.Global.Send<EventOpenImagetTrackable>(new EventOpenImagetTrackable(){_idName = "lianglong"});
			});
			
			BtnShowData.onClick.AddListener(() =>
			{
				UIKit.OpenPanel<UIAnimalDataPanel>();
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
