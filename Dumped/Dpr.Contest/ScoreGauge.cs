using Dpr.SubContents;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Contest;

public class ScoreGauge : MonoBehaviour
{
	[SerializeField]
	private RectTransform clearArrowRect;

	[SerializeField]
	private RectTransform markRect;

	[SerializeField]
	private Color baseColor;

	[SerializeField]
	private Color flashColor;

	[SerializeField]
	private float flickDuration;

	[SerializeField]
	private Material gaugeMat;

	private EffectEmitter fxEmitter;

	private LockPlayFx lockNormalFxTimer;

	private LockPlayFx lockLargeFxTimer;

	private RectTransform leftFrameRect;

	private Image leftGaugeImage;

	private Image leftGaugeBgImage;

	private RectTransform rightFrameRect;

	private Image rightGaugeImage;

	private Image rightGaugeBgImage;

	private Color gaugeColor;

	private float successScoreRatio;

	private float totalWidth;

	private float goalRatio;

	private float currentRatio;

	private float addGaugeValue;

	private float addFadeValue;

	private float colorAngleValue;

	private bool playingGaugeFlash;

	public Vector3 MarkCenterPos => default(Vector3);

	public void Initialize(float addValue, float lockTime)
	{
	}

	private void SetComponents()
	{
	}

	public void OnFinalize()
	{
	}

	public void SetUp(float successScoreRatio, float initGaugeRatio)
	{
	}

	private EmitEffectParam[] GetHitFxParams()
	{
		return null;
	}

	public void SetScoreRatio(float ratio, EmitHeartPattern emitPattern)
	{
	}

	private void CheckSuccessRatio()
	{
	}

	public void ResetParam(float ratio)
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	private void UpdateGaugeAmount(float deltaTime)
	{
	}

	private void SetGaugeRatio(float scoreRatio)
	{
	}

	private float CalcLeftGaugeAmount(float scoreRatio)
	{
		return default(float);
	}

	private float CalcRightGaugeAmount(float scoreRatio)
	{
		return default(float);
	}

	private void UpdateColorFade(float deltaTime)
	{
	}

	private void SetColorRatio(float ratio)
	{
	}

	private float LerpColorFactor(float a, float b, float ratio)
	{
		return default(float);
	}
}
