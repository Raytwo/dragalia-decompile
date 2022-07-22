using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dpr.UI;

public class BoxTextSelector : MonoBehaviour
{
	[SerializeField]
	private UIScrollView _scroller;

	private float _openPosX;

	private float _closePosX;

	private Action _onCancel;

	private Action _onChange;

	private Action _onDecide;

	private List<BoxWindow.SearchItemData> _selectItems;

	private BoxWindow.SearchType _searchType;

	private int _maxCount;

	private int _currentDepth;

	public int CurrentIndex
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

	public void Initialize(Action onCancel, Action onDecide, Action onChange)
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

	public void Open(BoxWindow.SearchType type, int depth, int index, List<BoxWindow.SearchItemData> items)
	{
	}

	public void Close()
	{
	}

	public void Setup(BoxWindow.SearchType type, int depth, int index, List<BoxWindow.SearchItemData> items)
	{
	}

	public void OnUpdate()
	{
	}

	private void ChangeItem(int value)
	{
	}

	public int GetMarkColors()
	{
		return default(int);
	}
}
