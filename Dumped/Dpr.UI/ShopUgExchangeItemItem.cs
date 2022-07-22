using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class ShopUgExchangeItemItem : ShopItemItem
{
	public class Param
	{
		public string unitText;

		public int tradeUgItemNo;

		public int category;

		public int ugItemID;

		public int price;

		public int unit;

		public string itemLabel;

		public int GetItemNo()
		{
			return default(int);
		}
	}

	[SerializeField]
	private Image _tradeItemIcon;

	private Param _param;

	public Param param => null;

	public bool IsUnderGroundItem()
	{
		return default(bool);
	}

	public void Setup(Param param)
	{
	}
}
