using Dpr.Battle.View;
using SmartPoint.Rendering;
using UnityEngine;
using UnityEngine.Rendering;

namespace Dpr.Rendering;

[CreateAssetMenu]
public class ColorFilter : ImageEffectObject
{
	public static readonly int _Color;

	private static Material _colorFilteMaterial;

	public Material[] materials => null;

	public override CommandBuffer Build(RenderTargetIdentifier sourceRT, out RenderTargetIdentifier resultRT, bool feedbackCameraTarget = true)
	{
		return null;
	}

	public void Blit(RenderTexture src, RenderTexture dest)
	{
	}

	public void UpdateShaderProperties(PfxParam param)
	{
	}
}
