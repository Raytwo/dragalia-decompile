using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dpr.Message;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.UI;

public class BoxSearchPanel : MonoBehaviour
{
	[SerializeField]
	private UIScrollView _searchTypeScroller;

	private float _openPosX;

	private float _closePosX;

	private Action _onClose;

	private Action _onChange;

	private Action _onExecute;

	private Action _onDecide;

	private int _maxCount;

	private int _indexCategory;

	private BoxMark _markIndex;

	private List<string> _selectedItemList;

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

	public int CurrentDepth
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

	public int MaxDepth
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

	public BoxWindow.SEARCH_DATA SearchData
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

	public BoxWindow.SearchType SearchType => default(BoxWindow.SearchType);

	public int[] DepthIndexes
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

	public List<int> LastSelectValues
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

	public List<BoxWindow.SearchItemData> SearchItemList
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

	public void Initialize(BoxWindow.SEARCH_DATA searchData, Action onClose, Action onDecide, Action onExecute, Action onChange)
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

	public void Open(int index, int markColors)
	{
	}

	public void Close()
	{
	}

	public void OnUpdate()
	{
	}

	private void ChangeSearchItem(int value)
	{
	}

	public void SetSelectedItemText(string selectedText)
	{
	}

	private void SetDepth(BoxWindow.SearchType searchType)
	{
	}

	private void SetSearchItemTexts()
	{
	}

	public void CreateSearchDataList(int depthValue = 0, int subIndex = 0)
	{
	}

	private void CreateSearchDataListCore(int indexGroup, MessageMsgFile defaultMsgFile)
	{
	}

	private string GetCalcTextID(string baseTextID, int index)
	{
		return null;
	}

	private void AddSearchList(MessageMsgFile msgFile, string messageID, [Optional] Sprite sprite)
	{
	}

	private int GetCountOfIndexGroup(BoxWindow.SearchType type, int group)
	{
		return default(int);
	}

	public void SetSearchData(BoxWindow.SEARCH_DATA searchData, int subIndex, bool isApplyPanel = false)
	{
	}

	public int GetSubIndex()
	{
		return default(int);
	}

	public void ClearSearchData()
	{
	}

	private int GetNoFromMessageID(string messageID)
	{
		return default(int);
	}
}
