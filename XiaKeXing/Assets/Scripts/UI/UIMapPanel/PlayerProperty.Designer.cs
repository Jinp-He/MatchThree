/****************************************************************************
 * 2022.3 DESKTOP-K6PJA74
 ****************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace MatchThree.UI
{
	public partial class PlayerProperty
	{
		[SerializeField] public UnityEngine.UI.Image HP;
		[SerializeField] public UnityEngine.UI.Image Fame;
		[SerializeField] public UnityEngine.UI.Image Reputation;
		[SerializeField] public UnityEngine.RectTransform ItemList;
		[SerializeField] public UnityEngine.UI.Text Name;
		[SerializeField] public UnityEngine.UI.Button BagBtn;
		[SerializeField] public UnityEngine.UI.Text Money;

		public void Clear()
		{
			HP = null;
			Fame = null;
			Reputation = null;
			ItemList = null;
			Name = null;
			BagBtn = null;
			Money = null;
		}

		public override string ComponentName
		{
			get { return "PlayerProperty";}
		}
	}
}
