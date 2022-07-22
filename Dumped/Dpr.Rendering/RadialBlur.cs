using Dpr.Battle.View;
using SmartPoint.Rendering;
using UnityEngine;
using UnityEngine.Rendering;

namespace Dpr.Rendering;

[CreateAssetMenu]
public class RadialBlur : ImageEffectObject
{
	public static readonly int _RadialBlurCenter;

	public static readonly int _RadialBlurIntensity;

	public static readonly int _RadialBlurNumSamples;

	private static Material _radialBlurMaterial;

	public override CommandBuffer Build(RenderTargetIdentifier sourceRT, out RenderTargetIdentifier resultRT, bool feedbackCameraTarget = true)
	{
		return null;
	}

	public void UpdateShaderProperties(PfxParam param)
	{
	}
}
