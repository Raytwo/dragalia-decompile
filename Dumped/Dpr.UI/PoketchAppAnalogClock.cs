using System.Runtime.InteropServices;
using UnityEngine;

namespace Dpr.UI;

public class PoketchAppAnalogClock : PoketchAppBase
{
	[SerializeField]
	private RectTransform _hour;

	[SerializeField]
	private RectTransform _minutes;

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

	private void SetTime(int hour, int minutes)
	{
	}
}
