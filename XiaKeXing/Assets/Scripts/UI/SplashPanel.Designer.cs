using System;
using QFramework;
using UnityEngine;
using UnityEngine.UI;

namespace MatchThree.UI
{
	// Generate Id:4dd7fe24-f80b-4771-8d7a-e2a4e4538955
	public partial class SplashPanel
	{
		public const string Name = "SplashPanel";
		
		[SerializeField]
		public UnityEngine.UI.Button StartBtn;
		[SerializeField]
		public UnityEngine.UI.Button SettingBtn;
		[SerializeField]
		public UnityEngine.UI.Button QuitBtn;
		
		private SplashPanelData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			StartBtn = null;
			SettingBtn = null;
			QuitBtn = null;
			
			mData = null;
		}
		
		public SplashPanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		SplashPanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new SplashPanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
