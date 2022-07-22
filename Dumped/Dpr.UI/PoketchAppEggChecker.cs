using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PoketchAppEggChecker : PoketchAppBase
{
	private enum EggCheckerState
	{
		None,
		BlurOut,
		BlurIn,
		End
	}

	[SerializeField]
	private PoketchEggCheckerPokeIcon[] _pokeIcon;

	[SerializeField]
	private Image _eggImage;

	[SerializeField]
	private Image _blurImage;

	[SerializeField]
	private float _inBlurTime;

	[SerializeField]
	private float _outBlurTime;

	[SerializeField]
	private float _maxBlurSize;

	private EggCheckerState _state;

	private float _blurTimeCount;

	private Material _matGrayScale;

	private Material _matBlur;

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

	private void StartBlur()
	{
	}

	private void UpdateAzukariyaInfo()
	{
	}

	private void UpdateBlur(float deltaTime)
	{
	}
}
