using System.Runtime.InteropServices;
using UnityEngine;

namespace Dpr.UI;

public class PoketchAppPokeList : PoketchAppBase
{
	[SerializeField]
	private Color32 _sickColor;

	private const float _updateTime = 5000f;

	private ZoneID _zoneId;

	private Material _matGrayScale;

	private Material _matSolidColor;

	private PoketchPokeListButton _selecteButton;

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

	public override void OnSizeChanged(bool isLarge)
	{
	}

	private void SetPokeIcons()
	{
	}
}
