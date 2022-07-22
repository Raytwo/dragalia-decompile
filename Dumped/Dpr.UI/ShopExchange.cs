using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class ShopExchange : ShopBase
{
	public class Param
	{
		public class PalParkParam
		{
			public int shopId;
		}

		public ShopType shopType;

		public PalParkParam palParkParam;

		public int GetFixedShopId()
		{
			return default(int);
		}
	}

	[SerializeField]
	private UIText _guide;

	[SerializeField]
	private ShopTradeItemDescriptionPanel _tradeItemDescriptionPanel;

	private Param _param;

	private List<ShopExchangeItemItem.Param> _itemParams;

	private ShopExchangeItemItem _selectShopItem;

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

	private void SequenceExchange(int amount)
	{
	}

	protected override void OnAddContextMenuYesNoItemParams(List<ContextMenuItem.Param> contextMenuItemParams)
	{
	}
}
