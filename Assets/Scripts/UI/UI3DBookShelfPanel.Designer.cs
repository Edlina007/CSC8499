using System;
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
	// Generate Id:9dace3c5-cb59-4c00-9962-f10ad261b410
	public partial class UI3DBookShelfPanel
	{
		public const string Name = "UI3DBookShelfPanel";
		
		[SerializeField]
		public UnityEngine.UI.Button BtnAnimal1;
		[SerializeField]
		public UnityEngine.UI.Button BtnSanJiaoLong;
		[SerializeField]
		public UnityEngine.UI.Button BtnLiangLong;
		[SerializeField]
		public UnityEngine.UI.Button BtnShowData;
		
		private UI3DBookShelfPanelData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			BtnAnimal1 = null;
			BtnSanJiaoLong = null;
			BtnLiangLong = null;
			BtnShowData = null;
			
			mData = null;
		}
		
		public UI3DBookShelfPanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		UI3DBookShelfPanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new UI3DBookShelfPanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
