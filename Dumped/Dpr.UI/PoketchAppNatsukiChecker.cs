using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Dpr.UI;

public class PoketchAppNatsukiChecker : PoketchAppBase
{
	[SerializeField]
	private RectTransform _pokeCanvas;

	[SerializeField]
	private PoketchAppNatsukiCheckerIcon[] _pokeIcons;

	[SerializeField]
	private float _touchTime;

	private Material _matGrayScale;

	private float _displayMargin;

	private float _touchTimeCount;

	private float _releaseTimeCount;

	private bool _isTouchOld;

	private List<PoketchAppNatsukiCheckerIcon> _activePokeIcons;

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

	private void OnUpdate(float deltaTime)
	{
	}
}
