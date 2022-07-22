using UnityEngine;
using UnityEngine.Rendering;

namespace SmartPoint.Rendering;

[CreateAssetMenu]
public class Bloom : ImageEffectObject
{
	private static Material fogMaterial;

	private const int MaxLayerCount = 5;

	public override CommandBuffer Build(RenderTargetIdentifier sourceRT, out RenderTargetIdentifier resultRT, bool feedbackCameraTarget = true)
	{
		return null;
	}

	private static void SetKeyword(Material material, string keyword, bool state)
	{
	}

	public static void SetFogParameters(FogMode fogMode, float start, float end, float density, float farClip, Color baseColor, Color farColor)
	{
	}

	public static void SetFogColorAlpha(float baseAlpha, float farAlpha)
	{
	}
}
