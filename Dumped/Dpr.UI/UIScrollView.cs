using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class UIScrollView : MonoBehaviour
{
	public enum DirectionType
	{
		Vertical,
		Horizontal
	}

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private GameObject itemPrefab;

	[SerializeField]
	private DirectionType direction;

	[SerializeField]
	private int duplicateItemCount;

	[SerializeField]
	private int beginScrollCount;

	[SerializeField]
	private IndexSelector indexSelector;

	private Action<IUIButton> onRequiedItemData;

	private Action<IUIButton> onSelectItem;

	private Action<IUIButton> onUnSelectItem;

	private LayoutGroup layoutGroup;

	private bool isHorizontal;

	private bool isActive;

	private LinkedList<IUIButton> scrollRectItems;

	private float viewportSize;

	private int itemSize;

	private int itemSizeWithSpacing;

	private int viewItemCount;

	private int itemCount;

	private int topPadding;

	private int bottomPadding;

	private int spacing;

	private float contentSize;

	private int viewMaxIndex;

	private int renderedStartIndex;

	private int topPaddingItemCount;

	private int paddingItemCount;

	private int gridItemCount;

	private float maxScrollValue;

	private IUIButton selectedItemNode;

	private float ContentAnchorPos => default(float);

	public int GridItemCount => default(int);

	public LinkedList<IUIButton> ScrollItems => null;

	private void Awake()
	{
	}

	public void Initialize(Action<IUIButton> onRequiedItemData, Action<IUIButton> onSelectItem, Action<IUIButton> onUnSelectItem)
	{
	}

	public void Setup(int itemCount, int selectIndex = 0, float scrollPos = 0f, bool isForceScroll = false)
	{
	}

	public void SetActive(bool isActive)
	{
	}

	public float GetScrollPosition()
	{
		return default(float);
	}

	public bool MoveSelect(int value)
	{
		return default(bool);
	}

	public bool Scroll(float value)
	{
		return default(bool);
	}

	public bool MovePage(bool isNext)
	{
		return default(bool);
	}

	public void ResumeMoveSelect()
	{
	}

	private void SetSelectIndex(int index)
	{
	}

	private void SelectItemNode(int index)
	{
	}

	private void OnValueChanged(Vector2 normalizedPosition)
	{
	}

	private void UpdateRendererItems(int viewTopPos)
	{
	}

	private void ForceUpdateItems(int startIndex)
	{
	}

	private void RefreshScrollContentAnchorPosition()
	{
	}

	private void SetLayoutGroupPadding(int value)
	{
	}

	private void SetScrollRectAnchorPosition(float value)
	{
	}
}
