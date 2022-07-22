using System.Runtime.InteropServices;
using DPData;
using UnityEngine;

namespace Dpr.UI;

public class PoketchAppColorChanger : PoketchAppBase
{
	private const float _knobSpan = 52f;

	[SerializeField]
	private GameObject _knob;

	[SerializeField]
	private RectTransform _rootKnob;

	private POKETCH_COLOR _colorType;

	protected override void OnInitialize()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnSizeChanged(bool isLarge)
	{
	}

	protected override void OnUpdateDraw()
	{
	}

	protected override void OnUpdateControl(bool isAppControlEnable = false, [Optional] PoketchButton targetButton, PoketchWindow.TouchState state = PoketchWindow.TouchState.None)
	{
	}

	private void SetColorType(POKETCH_COLOR color)
	{
	}

	private void SetKnob(int index)
	{
	}
}
