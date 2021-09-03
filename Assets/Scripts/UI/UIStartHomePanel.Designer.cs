using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;
/********************************************************************************

** Class name:UIStartHomePanel

** Description: Start Home UI 

** Author: Ting Zhang

** Created: 2021-8-17

*********************************************************************************/
namespace QFramework
{
	// Generate Id:327e3411-ca00-4a90-a064-a15b8a401a4b
	public partial class UIStartHomePanel
	{
		public const string Name = "UIStartHomePanel";
		
		[SerializeField]
		public UnityEngine.UI.Button BtnStart;
		
		private UIStartHomePanelData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			BtnStart = null;
			
			mData = null;
		}
		
		public UIStartHomePanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		UIStartHomePanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new UIStartHomePanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
