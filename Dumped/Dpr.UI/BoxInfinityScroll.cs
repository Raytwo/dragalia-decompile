using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class BoxInfinityScroll : MonoBehaviour
{
	[SerializeField]
	private BoxInfinityScrollItem _prefab;

	private int _showItemNum;

	private int _outsideItemNum;

	private ScrollRect _scrollRect;

	private HorizontalOrVerticalLayoutGroup _layoutGroup;

	private List<BoxInfinityScrollItem.BaseParam> _params;

	private int _itemNum;

	private int _paramIndex;

	private bool _isMoving;

	private bool _isTeam;

	public UnityAction<BoxInfinityScrollItem> onSelectChanged;

	public List<BoxInfinityScrollItem.BaseParam> baseParams => null;

	public bool IsMoving => default(bool);

	private void Awake()
	{
	}

	public IEnumerator OpSetup(List<BoxInfinityScrollItem.BaseParam> baseParams)
	{
		return null;
	}

	private void SetParamIndex(int index)
	{
	}

	public int GetParamIndex()
	{
		return default(int);
	}

	private BoxInfinityScrollItem.BaseParam GetParam(int index)
	{
		return null;
	}

	private void SetupItem(int itemIndex, BoxInfinityScrollItem.BaseParam param)
	{
	}

	public void Apply(int index, List<int> hideIndexes, BoxWindow.OpenParam openParam, [Optional] BoxWindow.SEARCH_DATA searchData, [Optional] List<BoxWindow.SelectedPokemon> selected)
	{
	}

	public void SetSelect(int index, List<int> selectIndexes)
	{
	}

	public void Move(int offset, [Optional] UnityAction callback)
	{
	}

	public void Jump(int paramIndex)
	{
	}

	public void SetDisplayMode(BoxWindow.DisplayMode mode)
	{
	}

	private float GetScrollPosition()
	{
		return default(float);
	}

	private void SetScrollPosition(float spos)
	{
	}
}
