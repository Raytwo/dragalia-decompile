using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dpr.UI;

public class UIPagingListView : MonoBehaviour
{
	[SerializeField]
	private RectTransform contents;

	[SerializeField]
	private GameObject itemPrefab;

	[SerializeField]
	private IndexSelector itemIndexSelector;

	[SerializeField]
	private IndexSelector pagingIndexSelector;

	private int viewItemMaxCount;

	private int contentsItemCount;

	private List<IUIButton> itemButtonList;

	public int PageIndex => default(int);

	public int PageCount
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

	public IUIButton SelectedItem
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

	public event Action<IUIButton> OnRequiredItemData
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

	public void Initialize()
	{
	}

	public void Setup(int count, int showPageIndex = 0, int selectIndex = 0)
	{
	}

	private void SetupContents()
	{
	}

	private void UpdatePageContents()
	{
	}

	private void UpdateSelectItem()
	{
	}

	public bool MoveSelect(int value)
	{
		return default(bool);
	}

	public void ResumeSelectMove()
	{
	}

	public bool MovePage(int value)
	{
		return default(bool);
	}

	public void ResumePageMove()
	{
	}
}
