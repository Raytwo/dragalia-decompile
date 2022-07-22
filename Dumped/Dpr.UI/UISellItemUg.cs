using System.Collections;
using System.Collections.Generic;
using Dpr.Item;
using Dpr.Message;
using Dpr.SubContents;
using Pml.UgFather;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class UISellItemUg : UIWindow
{
	private enum MenuState
	{
		Wait,
		SelectItem,
		SelectAmount,
		OpenConfirm,
		WaitSell
	}

	private const string BagPocketMessageFileName = "ss_bag_pocket";

	private static readonly string[] CategoryNameMessageLabels;

	[SerializeField]
	private UIButtonSelector categorySelector;

	[SerializeField]
	private UIScrollView scrollView;

	[SerializeField]
	private Cursor cursor;

	[SerializeField]
	private UIText descriptionHeaderNameText;

	[SerializeField]
	private UIText descriptionText;

	[SerializeField]
	private UIText categoryNameText;

	[SerializeField]
	private UIText noDataText;

	[SerializeField]
	private Image descriptionItemIconImage;

	[SerializeField]
	private SellUgItemPanel ugItemPanel;

	[SerializeField]
	private UgItemSelectAmount selectAmount;

	[SerializeField]
	private BagIconPanel bagIconPanel;

	private Dictionary<int, UgFatherDataManager.SellItemData> sellItemDataTable;

	private Dictionary<int, int> convertItemIdTable;

	private List<ItemInfo> itemInfoList;

	private UgFatherDataManager dataManagerPtr;

	private Coroutine removeNewIconCoroutine;

	private KeyGuideCreater keyguide;

	private ShowMessageWindow msgWindow;

	private MessageMsgFile shopMsgFile;

	private BagCategoryButton currentCategoryButton;

	private BagItemButton currentSelectItem;

	private UgFatherDataManager.SellItemData sellItemData;

	private MenuState state;

	private int nowAmount;

	private int getUgItemCount;

	public override void OnCreate()
	{
	}

	public void Open(UIWindowID prevWindowId = (UIWindowID)(-1))
	{
	}

	private IEnumerator OpOpen(UIWindowID prevWindowId)
	{
		return null;
	}

	private void SetupCategoryData()
	{
	}

	private void SetupItemData()
	{
	}

	private bool IsContainsCategory(int id, ref ItemInfo.CategoryType[] categoryArray)
	{
		return default(bool);
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void OnUpdateStateSelectItem()
	{
	}

	private void OnUpdateSelect()
	{
	}

	private void SelectItem()
	{
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

	private void OnFinishSellProcess()
	{
	}

	private bool CheckIsEmptySelectItem()
	{
		return default(bool);
	}

	private bool CheckIsEmptySellItemData()
	{
		return default(bool);
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

	private void SetItemInfo(ItemInfo itemInfo)
	{
	}

	private void SetCursor(IUIButton button)
	{
	}

	private void OnUnSelectItemScrollViewItem(IUIButton button)
	{
	}

	private void ReloadScrollView(int selectIndex = 0, float scrollPos = 0f)
	{
	}

	private void ReloadItemInfoList(ItemInfo.CategoryType categoryType)
	{
	}

	private void ClearItemInfo()
	{
	}

	private void StartRemoveNew(BagItemButton itemButton)
	{
	}

	private void CancelRemoveNew()
	{
	}

	private bool IsIncludeNewItemInCategory(ItemInfo.CategoryType category)
	{
		return default(bool);
	}

	private bool IsIncludeNewItemInCurrentList()
	{
		return default(bool);
	}

	public void Close(UnityAction<UIWindow> onClosed_)
	{
	}

	private IEnumerator OpClose(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
		return null;
	}
}
