using System.Collections.Generic;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PokemonStatusPanelBasicInfo : PokemonStatusPanel
{
	[SerializeField]
	private UIText _zukanNo;

	[SerializeField]
	private UIText _name;

	[SerializeField]
	private UIText _playerName;

	[SerializeField]
	private UIText _playerId;

	[SerializeField]
	private UIText _exp;

	[SerializeField]
	private UIText _remainExp;

	[SerializeField]
	private Slider _sliderExp;

	[SerializeField]
	private UIText _item;

	[SerializeField]
	private UIText _itemDescription;

	[SerializeField]
	private Image _itemIcon;

	[SerializeField]
	private TypePanel[] _types;

	[SerializeField]
	private Image[] _pokeruses;

	[SerializeField]
	private Image _rareType;

	[SerializeField]
	private Image _placeMark;

	[SerializeField]
	private RectTransform _markRoot;

	[SerializeField]
	private RectTransform _itemRoot;

	[SerializeField]
	private PokemonStatusMarkSetting _markSetting;

	private List<PokemonStatusMark> _marks;

	private bool _isMarkMode;

	private void Awake()
	{
	}

	public override void Setup(PokemonParam pokemonParam)
	{
	}

	private void SetupKeyguide(PokemonParam pokemonParam)
	{
	}

	private void SetupMarks()
	{
	}

	public override void Select(bool enabled)
	{
	}

	public override bool OnUpdate(float deltaTime)
	{
		return default(bool);
	}

	private void SetMarkMode(bool enabled)
	{
	}

	private void ShowItem(bool enabled)
	{
	}

	private void OnCloseMarkSetting()
	{
	}
}
