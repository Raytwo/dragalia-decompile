using System;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.UI;

public class PokemonStatusPanelContestWaza : PokemonStatusPanelWazaBase
{
	[Serializable]
	private class DetailParam
	{
		public UIText description;

		public RectTransform contents;

		public PokemonStatusContestWazaAppealItem prefab;
	}

	[SerializeField]
	private DetailParam _detail;

	protected override void Awake()
	{
	}

	public override void Setup(PokemonParam pokemonParam)
	{
	}

	protected override void OpenBagOfWazaMachine()
	{
	}

	protected override void SetupDetail()
	{
	}
}
