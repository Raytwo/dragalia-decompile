using System;
using System.Collections;
using System.Collections.Generic;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.UI;

public class ConditionFur : MonoBehaviour
{
	[Serializable]
	private class FurAnimParam
	{
		public float nextSeconds;

		public float waitAllPlaySeconds;
	}

	[SerializeField]
	private RectTransform _furContents;

	[SerializeField]
	private PokemonStatusConditionFurItem _furItemPrefab;

	[SerializeField]
	private FurAnimParam _furParam;

	private readonly int _animStateKeduya01;

	private List<PokemonStatusConditionFurItem> _items;

	private Coroutine _opFurAnim;

	private const int _furIconMax = 12;

	private void Awake()
	{
	}

	public void Setup(PokemonParam pokemonParam)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void StopAnimKezuya()
	{
	}

	private IEnumerator OpAnimKezuya()
	{
		return null;
	}
}
