using System;
using System.Collections.Generic;
using Effect;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PokemonStatusPanelAbility : PokemonStatusPanel
{
	[Serializable]
	private class ChartItem
	{
		public UIText name;

		public UIText text;

		public Image icon;

		public RectTransform effectRoot;
	}

	private enum RaderType
	{
		Ability,
		BasicAndTalent,
		Effort
	}

	[SerializeField]
	private ChartItem[] _chartItems;

	[SerializeField]
	private UIText _tokuseiName;

	[SerializeField]
	private UIText _tokuseiDescription;

	[SerializeField]
	private Color[] _raderColors;

	[SerializeField]
	private RectTransform _raderChartRoot;

	[SerializeField]
	private RaderChart[] _raders;

	[SerializeField]
	private Sprite[] _spriteUpDowns;

	[SerializeField]
	private Color[] _colorUpDowns;

	[SerializeField]
	private AnimationCurve _curveAbility;

	private int _selectRaderChartIndex;

	private List<EffectInstance> _effects;

	private PowerID[] _powerIdMap;

	private const float _minLength = 0.15f;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	public override void Setup(PokemonParam pokemonParam)
	{
	}

	private void SetupUpDownState(ChartItem chartItem, PowerID powerId)
	{
	}

	private float GetAbilityRaderValue(uint value)
	{
		return default(float);
	}

	private float GetAbilitySplinedValue(float rate)
	{
		return default(float);
	}

	public float GetBasicAndTalentRaderValue(uint value)
	{
		return default(float);
	}

	public float GetEfforttRaderValue(uint value)
	{
		return default(float);
	}

	private void SelectRaderChartIndex(int selectIndex, bool isInitialized = false)
	{
	}

	private void StopEffects()
	{
	}

	private void PlayEffortEffects(PokemonParam pokemonParam)
	{
	}

	public override bool OnUpdate(float deltaTime)
	{
		return default(bool);
	}
}
