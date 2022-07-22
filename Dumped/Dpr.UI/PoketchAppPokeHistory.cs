using System.Collections.Generic;
using System.Runtime.InteropServices;
using Pml;
using UnityEngine;

namespace Dpr.UI;

public class PoketchAppPokeHistory : PoketchAppBase
{
	[SerializeField]
	private PokemonIcon[] _icons;

	private Material _matGrayScale;

	private List<(MonsNo, int)> _pokeList;

	protected override void OnInitialize()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	protected override void OnUpdateDraw()
	{
	}

	protected override void OnUpdateControl(bool isAppControlEnable = false, [Optional] PoketchButton targetButton, PoketchWindow.TouchState state = PoketchWindow.TouchState.None)
	{
	}
}
