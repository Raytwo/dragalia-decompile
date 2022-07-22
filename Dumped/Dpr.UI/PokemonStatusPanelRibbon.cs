using System.Collections.Generic;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.UI;

public class PokemonStatusPanelRibbon : PokemonStatusPanel
{
	[SerializeField]
	private UIScrollView _scrollView;

	[SerializeField]
	private Cursor _cursor;

	[SerializeField]
	private UIText _name;

	[SerializeField]
	private RectTransform _descRoot;

	[SerializeField]
	private UIText _description;

	[SerializeField]
	private UIText _empty;

	private bool _isSelectRibon;

	private int _selectIndex;

	private int _columnMax;

	private List<PokemonStatusRibbonItem.Param> _itemParams;

	private void Awake()
	{
	}

	public override void Setup(PokemonParam pokemonParam)
	{
	}

	private bool IsShowAbutton()
	{
		return default(bool);
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

	public override bool OnUpdate(float deltaTime)
	{
		return default(bool);
	}

	private bool UpdateSelect(float deltaTime)
	{
		return default(bool);
	}

	private void SelectRibonMode(bool enabled)
	{
	}
}
