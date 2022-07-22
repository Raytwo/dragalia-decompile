using System;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PokemonStatusPanelWaza : PokemonStatusPanelWazaBase
{
	[Serializable]
	private class DetailParam
	{
		public Image category;

		public UIText power;

		public UIText hitRate;

		public UIText description;
	}

	[SerializeField]
	private DetailParam _detail;

	protected override void OpenBagOfWazaMachine()
	{
	}

	public override void Setup(PokemonParam pokemonParam)
	{
	}

	protected override void SetupDetail()
	{
	}
}
