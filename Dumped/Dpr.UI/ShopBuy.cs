using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class ShopBuy : ShopBase
{
	public class Param
	{
		public class FriendlyParam
		{
			public ZoneID zoneId;

			public int badgeNum;
		}

		public class FixedParam
		{
			public int shopId;
		}

		public class TobariDepart4FParam
		{
			public int shopId;
		}

		public class BattleParkParam
		{
			public int npcId;
		}

		public ShopType shopType;

		public FriendlyParam friendlyParam;

		public FixedParam fixedParam;

		public TobariDepart4FParam tobariDepart4FParam;

		public BattleParkParam battleParkParam;

		public int GetFixedShopId()
		{
			return default(int);
		}
	}

	[SerializeField]
	private UIText _chargeTitle;

	[SerializeField]
	private UIText _charge;

	private Param _param;

	private List<ShopBuyItemItem.Param> _itemParams;

	private ShopBuyItemItem _selectShopItem;

	public override void OnCreate()
	{
	}

	public void Open(Param param)
	{
	}

	public IEnumerator OpOpen(Param param)
	{
		return null;
	}

	private void SetupCharge()
	{
	}

	private void OnRequiredItemData(IUIButton button)
	{
	}

	private void OnSelectItemScrollViewItem(IUIButton button)
	{
	}

	private void SetupKeyguide()
	{
	}

	private void OnUnSelectItemScrollViewItem(IUIButton button)
	{
	}

	public void Close(UnityAction<UIWindow> onClosed_)
	{
	}

	public IEnumerator OpClose(UnityAction<UIWindow> onClosed_)
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void SequencePurchase(int amount)
	{
	}

	private int GetCharge()
	{
		return default(int);
	}

	private void SubCharge(int subCharge)
	{
	}

	protected override void OnAddContextMenuYesNoItemParams(List<ContextMenuItem.Param> contextMenuItemParams)
	{
	}
}
