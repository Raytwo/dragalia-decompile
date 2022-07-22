using System.Collections;
using System.Collections.Generic;
using Dpr.Item;
using Dpr.Message;
using Dpr.SubContents;
using Pml.UgFather;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class UISellUgItem : UIWindow
{
	private enum MenuState
	{
		Wait,
		SelectItem,
		SelectAmount,
		OpenConfirm,
		WaitSell
	}

	[SerializeField]
	private BagUGCategoryButton currentCategoryButton;

	[SerializeField]
	private UIScrollView scrollView;

	[SerializeField]
	private Cursor cursor;

	[SerializeField]
	private UIText descriptionHeaderNameText;

	[SerializeField]
	private UIText descriptionText;

	[SerializeField]
	private SellUgItemPanel ugItemPanel;

	[SerializeField]
	private UgItemSelectAmount selectAmount;

	[SerializeField]
	private GameObject noDataMessageObj;

	private Dictionary<int, UgFatherDataManager.SellItemData> sellItemDataTable;

	private List<UgItemInfo> itemInfoList;

	private UgFatherDataManager dataManagerPtr;

	private Coroutine removeNewIconCoroutine;

	private KeyGuideCreater keyguide;

	private ShowMessageWindow msgWindow;

	private MessageMsgFile shopMsgFile;

	private BagUGItemButton currentSelectItem;

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

	private bool IsItemEmpty()
	{
		return default(bool);
	}

	private bool CheckIsEmptySelectItem()
	{
		return default(bool);
	}

	private bool CheckIsEmptySellItemData()
	{
		return default(bool);
	}

	private void OnRequiredItemData(IUIButton button)
	{
	}

	private void OnSelectItemScrollViewItem(IUIButton button)
	{
	}

	private void SetItemInfo(UgItemInfo itemInfo)
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

	private void ClearItemInfo()
	{
	}

	private void StartRemoveNew(BagUGItemButton itemButton)
	{
	}

	private void CancelRemoveNew()
	{
	}

	private bool IsIncludeNewItemInCurrentList()
	{
		return default(bool);
	}

	public void Close(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
	}

	private IEnumerator OpClose(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
		return null;
	}
}
