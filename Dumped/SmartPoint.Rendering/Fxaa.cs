using UnityEngine;
using UnityEngine.Rendering;

namespace SmartPoint.Rendering;

[CreateAssetMenu]
public class Fxaa : ImageEffectObject
{
	private static Material fxaaMaterial;

	public override CommandBuffer Build(RenderTargetIdentifier sourceRT, out RenderTargetIdentifier resultRT, bool feedbackCameraTarget = true)
	{
		return null;
	}

	private static void SetKeyword(Material material, string keyword, bool state)
	{
	}

	public static void SetColorGrading(Texture2D lut0, float influence, Texture2D lut1, float weight)
	{
	}
}
