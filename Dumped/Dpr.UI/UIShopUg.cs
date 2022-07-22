using System;
using System.Collections;
using System.Collections.Generic;
using Dpr.Message;
using Dpr.SubContents;
using Pml.UgFather;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class UIShopUg : ShopBase
{
	public class UgShopParam
	{
		public UgFatherDataManager.UgShopType shopType;

		public DayOfWeek dayOfWeek;

		public int randomSheed;
	}

	private enum MenuState
	{
		Wait,
		SelectItem,
		SelectAmount,
		OpenConfirm,
		WaitSell
	}

	[SerializeField]
	private UgItemSelectAmount selectUgItemAmount;

	[SerializeField]
	private SellUgItemPanel ugItemPanel;

	private Dictionary<int, UgFatherDataManager.SellItemData> buyItemDataTable;

	private List<ShopUgExchangeItemItem.Param> _itemParams;

	private UgFatherDataManager dataManagerPtr;

	private UgShopParam _param;

	private ShowMessageWindow msgWindow;

	private MessageMsgFile shopMsgFile;

	private KeyGuideCreater keyguide;

	private ShopUgExchangeItemItem _selectShopUgItem;

	private UgFatherDataManager.SellItemData buyItemData;

	private MenuState state;

	private int nowAmount;

	private int tardeUgItemCount;

	private bool isPrevSelectWazaMachine;

	public override void OnCreate()
	{
	}

	public void Open(UgShopParam param, UIWindowID prevWindowId = (UIWindowID)(-1))
	{
	}

	private IEnumerator OpOpen(UIWindowID prevWindowId)
	{
		return null;
	}

	private void CreateBuyItemDataTable()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void OnUpdateStateSelectItem()
	{
	}

	private void HideWazaDescription()
	{
	}

	private bool OnUpdateInput()
	{
		return default(bool);
	}

	private void SelectItem()
	{
	}

	private bool CheckCanBuyItem()
	{
		return default(bool);
	}

	private void OnDecideAmount(int amount)
	{
	}

	private void OnUpdateStateSelectAmount()
	{
	}

	private void OnUpdateStateConfirm()
	{
	}

	private void OnSelectYes()
	{
	}

	private void UpdateUserItemData()
	{
	}

	private void OnFinishSellProcess()
	{
	}

	private bool CheckIsEmptySelectItem()
	{
		return default(bool);
	}

	private void OnRequiredItemData(IUIButton button)
	{
	}

	private void OnSelectItemScrollViewItem(IUIButton button)
	{
	}

	private void UpdateItemUI()
	{
	}

	private void OnUnSelectItemScrollViewItem(IUIButton button)
	{
	}

	public void Close(UnityAction<UIWindow> onClosed_)
	{
	}

	private IEnumerator OpClose(UnityAction<UIWindow> onClosed_)
	{
		return null;
	}
}
