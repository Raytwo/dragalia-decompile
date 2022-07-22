using Dpr.Battle.View;
using SmartPoint.Rendering;
using UnityEngine;
using UnityEngine.Rendering;

namespace Dpr.Rendering;

[CreateAssetMenu]
public class ChromaticAberration : ImageEffectObject
{
	private const float DISPERION_ADJUST = 0.2f;

	public static readonly int _Disper;

	private static Material _chromaticAberrationMaterial;

	public override CommandBuffer Build(RenderTargetIdentifier sourceRT, out RenderTargetIdentifier resultRT, bool feedbackCameraTarget = true)
	{
		return null;
	}

	public void UpdateShaderProperties(PfxParam param)
	{
	}
}
