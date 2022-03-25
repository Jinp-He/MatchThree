using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace MatchThree.UI
{
	// Generate Id:f3c62e78-2a70-4878-9311-9e9eda9faca5
	public partial class UIEventPanel
	{
		public const string Name = "UIEventPanel";
		
		[SerializeField]
		public UnityEngine.UI.Image EventImg;
		[SerializeField]
		public UnityEngine.UI.Text Title;
		[SerializeField]
		public UnityEngine.UI.Text DetailTxt;
		[SerializeField]
		public Choices Choices;
		
		private UIEventPanelData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			EventImg = null;
			Title = null;
			DetailTxt = null;
			Choices = null;
			
			mData = null;
		}
		
		public UIEventPanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		UIEventPanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new UIEventPanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
