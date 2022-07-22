using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PoketchAppCoin : PoketchAppBase
{
	private enum CoinState
	{
		Idle,
		Tos,
		Result,
		End
	}

	private enum CoinImageState
	{
		Heads00,
		Heads01,
		Heads02,
		Tails00,
		Tails01,
		End
	}

	[SerializeField]
	private Image _coinImage;

	[SerializeField]
	private Sprite[] _coinSprites;

	private CoinState _state;

	public float CoinAnimationTime;

	private float _coinAnimationTimeCount;

	private int _coinSpriteIndex;

	private const string animationStateNameCointos = "Poketch_CoinMove01";

	private const string animationStateNameIdle = "Poketch_CoinMove02";

	private Animator _coinAnimator;

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

	private void StartCointos()
	{
	}

	private void ItrCoinSprite()
	{
	}

	private void SetCoinSprite(int index)
	{
	}

	public void DisplayCoinResult()
	{
	}

	public void PlayCoinBoundSE()
	{
	}
}
