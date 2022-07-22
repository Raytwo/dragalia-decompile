using UnityEngine;

namespace Dpr.Battle.View;

public struct BTLV_ENVIRONMENT_PARAM
{
	public readonly Vector2 PitchYaw;

	public readonly Vector4 CharacterLightColor;

	public readonly float CharacterLightIntensity;

	public readonly Vector4 CharacterReflectorColor;

	public readonly Vector4 PokeLightColor;

	public readonly float PokeLightIntensity;

	public readonly Vector4 PokeReflectorColor;

	public BTLV_ENVIRONMENT_PARAM(EnvironmentController controller)
	{
	}
}
