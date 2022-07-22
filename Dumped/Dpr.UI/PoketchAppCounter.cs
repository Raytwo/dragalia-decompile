using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PoketchAppCounter : PoketchAppBase
{
	[SerializeField]
	private Image _countImage0001;

	[SerializeField]
	private Image _countImage0010;

	[SerializeField]
	private Image _countImage0100;

	[SerializeField]
	private Image _countImage1000;

	[SerializeField]
	private Sprite[] _numberSprites;

	private int _count;

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

	private void SetCount(int count)
	{
	}
}
