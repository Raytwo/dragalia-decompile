using System.Collections.Generic;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PokemonStatusPanelWazaBase : PokemonStatusPanel
{
	[SerializeField]
	protected RectTransform _contents;

	[SerializeField]
	protected PokemonStatusWazaItem _itemPrefab;

	[SerializeField]
	protected Cursor _cursor;

	[SerializeField]
	protected RectTransform _detailRoot;

	protected List<PokemonStatusWazaItem> _items;

	protected int _selectIndex;

	protected bool _showDetail;

	protected VerticalLayoutGroup _verticalLayoutGroup;

	protected PokemonStatusWazaItem _fromSwapItem;

	protected Vector3 _fromSwapPisiton;

	protected int _fromSwapSiblingIndex;

	protected virtual void Awake()
	{
	}

	public virtual void Setup(PokemonParam pokemonParam, bool isContest)
	{
	}

	protected void SetupItems()
	{
	}

	protected void SetupKeyguide()
	{
	}

	protected void ShowDetail(bool enabled)
	{
	}

	protected virtual void SetupDetail()
	{
	}

	public override bool OnUpdate(float deltaTime)
	{
		return default(bool);
	}

	protected virtual void OpenBagOfWazaMachine()
	{
	}

	protected bool UpdateSwap(float deltaTime)
	{
		return default(bool);
	}

	protected bool UpdateSelect(float deltaTime)
	{
		return default(bool);
	}

	protected bool SetSelectIndex(int selectIndex, bool isInitialize = false)
	{
		return default(bool);
	}
}
