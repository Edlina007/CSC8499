using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;
/********************************************************************************

** Class name:UILiangLongPanel

** Description: UI class for Diplodocus

** Author: Ting Zhang

** Created: 2021-8-16

*********************************************************************************/
namespace QFramework
{
	// Generate Id:c4e5b411-b1d3-4598-8af8-5b4cda5ba23a
	public partial class UILiangLongPanel
	{
		public const string Name = "UILiangLongPanel";
		
		[SerializeField]
		public UnityEngine.UI.Button BtnOpenBG;
		[SerializeField]
		public UnityEngine.UI.Image InfoPanel;
		[SerializeField]
		public UnityEngine.Video.VideoPlayer ImgVideo;
		[SerializeField]
		public UnityEngine.UI.Button BtnClose;
		[SerializeField]
		public UnityEngine.UI.Button BtnBack;
		
		private UILiangLongPanelData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			BtnOpenBG = null;
			InfoPanel = null;
			ImgVideo = null;
			BtnClose = null;
			BtnBack = null;
			
			mData = null;
		}
		
		public UILiangLongPanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		UILiangLongPanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new UILiangLongPanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
