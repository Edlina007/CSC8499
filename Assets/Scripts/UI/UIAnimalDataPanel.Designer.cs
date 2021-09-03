using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;
/********************************************************************************

** Class name:UIAnimalDataPanel

** Description: UI class for displaying animal data

** Author: Ting Zhang

** Created: 2021-8-15

*********************************************************************************/
namespace QFramework
{
	// Generate Id:4c50c540-973d-4f71-9d6b-72b1149eb608
	public partial class UIAnimalDataPanel
	{
		public const string Name = "UIAnimalDataPanel";
		
		[SerializeField]
		public UnityEngine.UI.Button BtnBack;
		
		private UIAnimalDataPanelData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			BtnBack = null;
			
			mData = null;
		}
		
		public UIAnimalDataPanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		UIAnimalDataPanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new UIAnimalDataPanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
