using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;
/********************************************************************************

** Class name:UITestPanel

** Description: UI for displaying test 

** Author: Ting Zhang

** Created: 2021-8-17

*********************************************************************************/
namespace QFramework
{
	// Generate Id:41f1a114-bccc-4edb-bdcd-09558d363329
	public partial class UITestPanel
	{
		public const string Name = "UITestPanel";
		
		[SerializeField]
		public UnityEngine.UI.Toggle TogCtroVuforia;
		
		private UITestPanelData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			TogCtroVuforia = null;
			
			mData = null;
		}
		
		public UITestPanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		UITestPanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new UITestPanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
