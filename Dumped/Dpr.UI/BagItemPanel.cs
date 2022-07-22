using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dpr.Item;
using UnityEngine;

namespace Dpr.UI;

public class BagItemPanel : MonoBehaviour
{
	public static int SwitchItemDescriptionWazaPanelButton;

	private const string BagPocketMessageFileName = "ss_bag_pocket";

	private static readonly string[] CategoryNameMessageLabels;

	private const int ChangeAmountValue = 1;

	private const int ChangeLotAmountValue = 10;

	[SerializeField]
	private Cursor cursor;

	[SerializeField]
	private BagIconPanel bagIconPanel;

	[SerializeField]
	private UIText moneyValueText;

	[SerializeField]
	private UIButtonSelector categoryButtonSelector;

	[SerializeField]
	private UIText categoryNameText;

	[SerializeField]
	private RectTransform categoryLeftArrowRectTransform;

	[SerializeField]
	private RectTransform categoryRightArrowRectTransform;

	[SerializeField]
	private UIScrollView itemListScrollView;

	[SerializeField]
	private UIText noDataText;

	[SerializeField]
	private BagItemDescriptionPanel bagItemDescriptionPanel;

	[SerializeField]
	private BagItemSelectAmount selectAmount;

	private bool isRemoveNewEnable;

	private bool isBattle;

	private ItemListMemory itemListMemory;

	private List<ItemInfo> items;

	private BagCategoryButton currentCategoryButton;

	private Coroutine removeNewIconCoroutine;

	private Action<int> onDecideSelectAmountCallback;

	private Action onCancelSelectAmountCallback;

	private Action<int> onSelectAmountValueChangedCallback;

	public int CurrentCategoryId
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsNoItem => default(bool);

	public BagItemButton SelectedItemButton
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsShowSelectAmount => default(bool);

	public bool CanSwitchDescriptionWazaPanel => default(bool);

	public UIButtonSelector CategorySelector => null;

	public event Action<BagItemButton> OnChangeSelectItem
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Initialize(ItemListMemory itemListMemory, bool isBattle = false, [Optional] ItemInfo.CategoryType[] categoryTypes)
	{
	}

	public void SetActive(bool isActive)
	{
	}

	public void SetRemoveNewEnable(bool isEnable)
	{
	}

	public void SetShowDescriptionContestWaza(bool isShowWazaContest)
	{
	}

	public void MoveCategorySelect(int value)
	{
	}

	public void ResumeCategoryMoveSelect()
	{
	}

	public void MoveItemListSelect(int value)
	{
	}

	public void MoveItemListPage(bool isNext)
	{
	}

	public void ResumeItemListMoveSelect()
	{
	}

	public void ChangeSelectAmount(bool isAdd, bool isLot)
	{
	}

	public void ResumeSelectAmountChange()
	{
	}

	public void DecideSelectAmount()
	{
	}

	public void CancelSelectAmount()
	{
	}

	public void ReloadItemList(bool isFocusSelectedItem = false, int selectedItemId = 0)
	{
	}

	public void SetMoneyText(int money)
	{
	}

	public void ShowSelectAmount(int min, int max, Action<int> onDecide, Action onCancel, [Optional] Action<int> onAmountValueChanged)
	{
	}

	public void SetSelectAmountDescriptionText(string text)
	{
	}

	public void SwitchItemDescriptionWazaPanel()
	{
	}

	public void PlayCursorDecideAnimation()
	{
	}

	private void SetupCategoryButtons(int selectIndex, [Optional] ItemInfo.CategoryType[] activeCategoryTypes)
	{
	}

	private void OnSelectCategoryButton(IUIButton button)
	{
	}

	private void OnUnSelectCategoryButton(IUIButton button)
	{
	}

	private void OnRequiredItemData(IUIButton button)
	{
	}

	private void OnSelectItemScrollViewItem(IUIButton button)
	{
	}

	private void OnUnSelectItemScrollViewItem(IUIButton button)
	{
	}

	private void StartRemoveNew(BagItemButton bagItemButton)
	{
	}

	private void CancelRemoveNew()
	{
	}
}
