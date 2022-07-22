using Effect;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Contest;

public class OpeningSection : MonoBehaviour
{
	private enum AnimState
	{
		WaitStartPlayAnim,
		PlayingAnim,
		End
	}

	private readonly int startAnimHash;

	private readonly int endAnimHash;

	private EffectInstance titleLogoFx;

	private EffectData titleLogoFxData;

	private Animator openingAnimator;

	private Transform cameraContent;

	private Transform canvasTransform;

	private Image contestTitleImage;

	private Image medalImage;

	private Image categoryTitleImage;

	private Image rankImage;

	private Vector3 logoFxPos;

	private AnimState animState;

	private bool bRunning;

	private bool bReady;

	public bool IsReady => default(bool);

	public void Initialize()
	{
	}

	public void OnFinalize()
	{
	}

	private void SetImageComponents()
	{
	}

	private void LoadFx()
	{
	}

	public void ResetParam()
	{
	}

	public void Stop()
	{
	}

	public void SetMedalSpr(Sprite spr)
	{
	}

	public void SetContestTitleSpr(Sprite spr)
	{
	}

	public void SetCategorySpr(Sprite spr)
	{
	}

	public void SetRankSpr(Sprite spr)
	{
	}

	public void SetMedalActive(bool active)
	{
	}

	public void SetRankActive(bool active)
	{
	}

	public void Setup()
	{
	}

	public void StartSection()
	{
	}

	public bool UpdateSection()
	{
		return default(bool);
	}

	private void CheckStratAnimation()
	{
	}

	private void CheckFinishAnimation()
	{
	}

	private void OnFinishSection()
	{
	}

	public void PlayAllPlayerAnimation(int animationIndex)
	{
	}

	public void PlayLeftMostTrainerAnim(int animationIndex)
	{
	}

	public void PlayLeftTrainerAnim(int animationIndex)
	{
	}

	public void PlayRightTrainerAnim(int animationIndex)
	{
	}

	public void PlayRightMostTrainerAnim(int animationIndex)
	{
	}

	private void PlayTrainerMotion(int playerIndex, int animationIndex)
	{
	}

	public void PlayTitleFx()
	{
	}

	public void StopTitleFx()
	{
	}
}
