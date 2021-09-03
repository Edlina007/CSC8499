using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;
/********************************************************************************

** Class name:UIScanPanel

** Description: Scan UI interface

** Author: Ting Zhang

** Created: 2021-8-17

*********************************************************************************/
namespace QFramework
{
	// Generate Id:e96415c9-6ae0-4021-bcd8-c45e936cc046
	public partial class UIScanPanel
	{
		public const string Name = "UIScanPanel";
		
		[SerializeField]
		public UnityEngine.CanvasGroup BGPanel;
		[SerializeField]
		public DG.Tweening.DOTweenAnimation ImgScan;
		
		private UIScanPanelData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			BGPanel = null;
			ImgScan = null;
			
			mData = null;
		}
		
		public UIScanPanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		UIScanPanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new UIScanPanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
