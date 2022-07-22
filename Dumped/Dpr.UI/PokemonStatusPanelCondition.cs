using System.Collections;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.UI;

public class PokemonStatusPanelCondition : PokemonStatusPanel
{
	[SerializeField]
	private ConditionFur _fur;

	[SerializeField]
	private ConditionRaderChart _rader;

	[SerializeField]
	private UIText _likeTaste;

	private void Awake()
	{
	}

	public override void Setup(PokemonParam pokemonParam)
	{
	}

	private IEnumerator OpUpdateConditions()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public override void Select(bool enabled)
	{
	}

	public override bool OnUpdate(float deltaTime)
	{
		return default(bool);
	}
}
