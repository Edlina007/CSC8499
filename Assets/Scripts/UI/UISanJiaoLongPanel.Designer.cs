using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;
/********************************************************************************

** Class name:UISanJiaoLongPanel

** Description: UI class for Triceratops

** Author: Ting Zhang

** Created: 2021-8-16

*********************************************************************************/
namespace QFramework
{
	// Generate Id:ebb65023-79b3-4197-ae14-ae75a9f18de1
	public partial class UISanJiaoLongPanel
	{
		public const string Name = "UISanJiaoLongPanel";
		
		[SerializeField]
		public UnityEngine.UI.Button BtnOpenBG;
		[SerializeField]
		public UnityEngine.UI.Image InfoPanel;
		[SerializeField]
		public UnityEngine.UI.Toggle ToggleA;
		[SerializeField]
		public UnityEngine.UI.Button BtnAffirm;
		[SerializeField]
		public UnityEngine.UI.Image ShowMsgPanel;
		[SerializeField]
		public UnityEngine.UI.Text TxtMsgBox;
		[SerializeField]
		public UnityEngine.UI.Button BtnClose;
		[SerializeField]
		public UnityEngine.UI.Button BtnBack;
		
		private UISanJiaoLongPanelData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			BtnOpenBG = null;
			InfoPanel = null;
			ToggleA = null;
			BtnAffirm = null;
			ShowMsgPanel = null;
			TxtMsgBox = null;
			BtnClose = null;
			BtnBack = null;
			
			mData = null;
		}
		
		public UISanJiaoLongPanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		UISanJiaoLongPanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new UISanJiaoLongPanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
