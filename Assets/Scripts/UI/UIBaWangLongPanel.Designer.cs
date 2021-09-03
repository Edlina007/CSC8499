using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;
/********************************************************************************

** Class name:UIBaWangLongPanel

** Description: UI class for Tyrannosaurus rex

** Author: Ting Zhang

** Created: 2021-8-15

*********************************************************************************/
namespace QFramework
{
	// Generate Id:bd047fad-b5a2-4bd5-97f5-ca789d42210e
	public partial class UIBaWangLongPanel
	{
		public const string Name = "UIBaWangLongPanel";
		
		[SerializeField]
		public UnityEngine.UI.Button BtnOpenBG;
		[SerializeField]
		public UnityEngine.UI.Image BGPanel;
		[SerializeField]
		public UnityEngine.UI.Button BtnClose;
		[SerializeField]
		public UnityEngine.UI.Button BtnBack;
		
		private UIBaWangLongPanelData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			BtnOpenBG = null;
			BGPanel = null;
			BtnClose = null;
			BtnBack = null;
			
			mData = null;
		}
		
		public UIBaWangLongPanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		UIBaWangLongPanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new UIBaWangLongPanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
