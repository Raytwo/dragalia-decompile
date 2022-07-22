using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PoketchAppDWatch : PoketchAppBase
{
	[SerializeField]
	private Image[] _hourNumImages;

	[SerializeField]
	private Image[] _minuteNumImages;

	[SerializeField]
	private Sprite[] _numSprites;

	private int _hour;

	private int _minute;

	[SerializeField]
	private PoketchButton _targetButton;

	[SerializeField]
	private PoketchWindow.TouchState _state;

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
}
