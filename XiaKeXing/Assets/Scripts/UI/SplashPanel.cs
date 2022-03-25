using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace MatchThree.UI
{
	public class SplashPanelData : UIPanelData
	{
	}
	public partial class SplashPanel : UIPanel
	{
		protected override void ProcessMsg(int eventId, QMsg msg)
		{
			throw new System.NotImplementedException();
		}
		
		protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as SplashPanelData ?? new SplashPanelData();
			// please add init code here
		}
		
		protected override void OnOpen(IUIData uiData = null)
		{
		}
		
		protected override void OnShow()
		{
		}
		
		protected override void OnHide()
		{
		}
		
		protected override void OnClose()
		{
		}
	}
}
