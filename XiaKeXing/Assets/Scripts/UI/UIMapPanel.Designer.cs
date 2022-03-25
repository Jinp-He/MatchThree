using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace MatchThree.UI
{
	// Generate Id:a9ee4021-75e4-47d9-b10f-a71930b7f9bf
	public partial class UIMapPanel
	{
		public const string Name = "UIMapPanel";
		
		[SerializeField]
		public PlayerProperty PlayerProperty;
		
		private UIMapPanelData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			PlayerProperty = null;
			
			mData = null;
		}
		
		public UIMapPanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		UIMapPanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new UIMapPanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
