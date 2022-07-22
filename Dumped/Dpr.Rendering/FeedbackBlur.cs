using Dpr.Battle.View;
using SmartPoint.Rendering;
using UnityEngine;
using UnityEngine.Rendering;

namespace Dpr.Rendering;

[CreateAssetMenu]
public class FeedbackBlur : ImageEffectObject
{
	public static readonly int DELAY_BUFFER_TEX_ID;

	public static readonly int _FeedbackBlurWeight;

	public static readonly int _FeedbackBlurRotation;

	public static readonly int _FeedbackBlurScale;

	public static readonly int _FeedbackBlurHue;

	public static readonly int _FeedbackBlurSaturation;

	public static readonly int _FeedbackBlurBrightness;

	public static readonly int _FeedbackBlurContrast;

	private RenderTexture _delayBuffer;

	private static Material _feedbackBlurMaterial;

	public override void Destroy()
	{
	}

	public override CommandBuffer Build(RenderTargetIdentifier sourceRT, out RenderTargetIdentifier resultRT, bool feedbackCameraTarget = true)
	{
		return null;
	}

	public void UpdateShaderProperties(PfxParam param)
	{
	}
}
