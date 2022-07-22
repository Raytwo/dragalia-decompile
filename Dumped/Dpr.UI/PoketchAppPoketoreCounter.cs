using System;
using System.Runtime.InteropServices;
using DG.Tweening;
using Pml;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PoketchAppPoketoreCounter : PoketchAppBase
{
	[Serializable]
	private struct PoketoreCounterImages
	{
		public GameObject _root;

		public PokemonIcon _pokemonIcon;

		public Image[] _counterImages;

		public DG.Tweening.Sequence _sequence;
	}

	[SerializeField]
	private PoketoreCounterImages _current;

	[SerializeField]
	private PoketoreCounterImages[] _ranking;

	[SerializeField]
	private Sprite[] _numberSprites;

	[SerializeField]
	private static Vector3 _jumpValue;

	[SerializeField]
	private static float _jumpTime;

	private Material _matGrayScale;

	private MonsNo[] _monsNos;

	private int _prevCount;

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

	private void ApplyRanking()
	{
	}

	private void SetPoketoreInfo(PoketoreCounterImages images, PokemonParam pp, int count)
	{
	}

	private void JumpIcon(int index)
	{
	}
}
