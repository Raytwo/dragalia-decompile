using System;
using System.Collections.Generic;
using Dpr.Message;
using Dpr.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.SecretBase;

public class StatuePlacementFilterWindow : MonoBehaviour
{
	private enum TopItemType
	{
		Type1,
		Type2,
		Size,
		Category,
		Max
	}

	private enum State
	{
		TopSelect,
		DetailSelect
	}

	public class FilterResult
	{
		public int type1;

		public int type2;

		public int size;

		public int category;

		public int legend;

		public FilterResult()
		{
		}

		public FilterResult(int type1, int type2, int size, int category, int legend)
		{
		}
	}

	[SerializeField]
	private GameObject topItemPrefab;

	[SerializeField]
	private GameObject detailItemPrefab;

	[SerializeField]
	private RectTransform topContentsRoot;

	[SerializeField]
	private RectTransform detailContentsRoot;

	[SerializeField]
	private GameObject topWindow;

	[SerializeField]
	private GameObject detailWindow;

	[SerializeField]
	private RectTransform detailWindowRect;

	[SerializeField]
	private VerticalLayoutGroup detailLayoutGroup;

	[SerializeField]
	private GameObject window;

	[SerializeField]
	private StatuePlacementFilterInfo filterInfo;

	[SerializeField]
	private SecretBaseAudioManager audioManager;

	[SerializeField]
	private IndexSelector topItemSelector;

	[SerializeField]
	private IndexSelector detailItemSelector;

	private List<FillterTopItem> topItems;

	private Dictionary<int, List<FilterDetailItem>> detailItems;

	private int[] detailItemIndices;

	private State currentState;

	private bool isReset;

	private bool isDisplay;

	private float dest;

	private float detailContentHeight;

	private float viewport;

	private readonly float scrollSpeed;

	private readonly float itemSize;

	private Action<FilterResult> OnApplied;

	private Action<bool> OnCancel;

	public void Initialize(Action<FilterResult> OnApplied, Action<bool> OnCancel)
	{
	}

	public void Show()
	{
	}

	public void Close()
	{
	}

	private void InitializeDetail_Top(MessageMsgFile msgFile)
	{
	}

	private void InitializeDetail_Type(MessageMsgFile msgFile)
	{
	}

	private void InitializeDetail_Size(MessageMsgFile msgFile)
	{
	}

	private void InitializeDetail_Category(MessageMsgFile msgFile)
	{
	}

	private void AddDetail(TopItemType type, string[] subjects)
	{
	}

	public void OnUpdate()
	{
	}

	private void OnUpdate_TopSelect()
	{
	}

	private void ResetFillter()
	{
	}

	private void ApplyFilter()
	{
	}

	private void OnUpdate_DetailSelect()
	{
	}

	private void CalcScroll()
	{
	}

	private void CalcScrollImmediate()
	{
	}

	private void ShowDetailItemList()
	{
	}

	private void ShowTopItemList()
	{
	}

	private void ApplyTopItemText()
	{
	}

	private void UpdateTopIndex(int move)
	{
	}

	private void UpdateDetailIndex(int topItemIndex, int move)
	{
	}
}
