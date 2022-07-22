using System;
using System.Collections.Generic;
using Effect;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class ConditionRaderChart : MonoBehaviour
{
	[Serializable]
	private class ChartItem
	{
		public Image icon;

		public RectTransform effectRoot;
	}

	[SerializeField]
	private ChartItem[] _chartItems;

	[SerializeField]
	private RaderChart _rader;

	private List<EffectInstance> _effects;

	public const int conditionRaderParamNum = 5;

	private void Awake()
	{
	}

	public void Setup(PokemonParam pokemonParam)
	{
	}

	public void SetupByBytes(byte[] conditions, bool isHideArrows = true)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void StopEffects()
	{
	}

	private void PlayEffects(byte[] conditions)
	{
	}

	private float GetRaderValue(byte value)
	{
		return default(float);
	}

	public void EnableStatusUpIcon(bool enabled, Condition condition)
	{
	}
}
