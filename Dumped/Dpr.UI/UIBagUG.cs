using System.Collections;
using System.Collections.Generic;
using Dpr.Item;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class UIBagUG : UIWindow
{
	[SerializeField]
	private UIButtonSelector categorySelector;

	[SerializeField]
	private UIScrollView scrollView;

	[SerializeField]
	private Cursor cursor;

	[SerializeField]
	private GameObject noItemTextObject;

	[SerializeField]
	private UIText descriptionHeaderNameText;

	[SerializeField]
	private UIText descriptionText;

	[SerializeField]
	private Image itemViewImage;

	private List<UgItemInfo> itemInfoList;

	private BagUGCategoryButton currentCategoryButton;

	private Coroutine removeNewIconCoroutine;

	public override void OnCreate()
	{
	}

	public void Open(UIWindowID prevWindowId = (UIWindowID)(-1))
	{
	}

	public IEnumerator OpOpen(UIWindowID prevWindowId)
	{
		return null;
	}

	public void Close(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
	}

	public IEnumerator OpClose(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void OnUpdateSelect(float deltaTime)
	{
	}

	private void UpdateKeyGuide()
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

	private void SetupCategoryButtons()
	{
	}

	private void ReloadScrollView(int selectIndex = 0, float scrollPos = 0f)
	{
	}

	private void SetCursor(IUIButton button)
	{
	}

	private void ClearItemInfo()
	{
	}

	private void SetItemInfo(UgItemInfo itemInfo)
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
}
