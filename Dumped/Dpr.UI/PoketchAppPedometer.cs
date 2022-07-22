using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PoketchAppPedometer : PoketchAppBase
{
	[SerializeField]
	private Image[] _numImage;

	[SerializeField]
	private Sprite[] _numSprite;

	private uint _count;

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
