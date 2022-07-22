using Dpr.Battle.View;
using SmartPoint.Rendering;
using UnityEngine;
using UnityEngine.Rendering;

namespace Dpr.Rendering;

[CreateAssetMenu]
public sealed class BtlvPfx : ImageEffectObject
{
	public static readonly int _ColorHue;

	public static readonly int _ColorSat;

	public static readonly int _ColorVal;

	public static readonly int _ColorScale;

	public static readonly int _ColorBias;

	public static readonly int _ColorContrast;

	public const string _SEPIA_TONE_ON = "_SEPIA_TONE_ON";

	public static readonly int _SepiaToneWeight;

	public const string _COLOR_INVERSION_ON = "_COLOR_INVERSION_ON";

	private static Material _btlvPfxMaterial;

	public override CommandBuffer Build(RenderTargetIdentifier sourceRT, out RenderTargetIdentifier resultRT, bool feedbackCameraTarget = true)
	{
		return null;
	}

	public void UpdateShaderProperties(PfxParam param)
	{
	}
}
