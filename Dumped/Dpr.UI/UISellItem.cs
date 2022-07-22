using System.Collections;
using Dpr.Item;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class UISellItem : UIWindow
{
	private const string SellPriceValueMessageLabel = "SS_bag_067";

	private const string SellNoPriceValueMessageLabel = "SS_bag_072";

	private const string QuestionSellItemMessageLabel = "SS_bag_073";

	private const string NotSellItemMessageLabel = "SS_bag_074";

	private const string ConfirmSellItemMessageLabel = "SS_bag_069";

	private const string SellItemResultMessageLabel = "SS_bag_075";

	private const string SellMultipleItemResultMessageLabel = "SS_bag_076";

	[SerializeField]
	private BagItemPanel bagItemPanel;

	[SerializeField]
	private UIText sellItemPriceText;

	private readonly int _animStateIn;

	private readonly int _animStateOut;

	private ItemListMemory itemListMemory;

	private UIMsgWindowController msgWindowController;

	private bool isWaitUpdate;

	public override void OnCreate()
	{
	}

	public void Open()
	{
	}

	public IEnumerator OpOpen()
	{
		return null;
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

	private void OnUpdateDefault()
	{
	}

	private void OnUpdateSelectAmount()
	{
	}

	private void UpdateKeyGuide()
	{
	}

	private void SetupBagItemPanel()
	{
	}

	private void ShowItemContextMenu(ItemInfo item)
	{
	}

	private void UpdateSellItemPriceText(ItemInfo item)
	{
	}

	private void OnSelectAmountValueChanged(int amount)
	{
	}

	private void OnChangeBagPanelSelectItem(BagItemButton bagItemButton)
	{
	}
}
