using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu]
public class EnvironmentSettings : ScriptableObject
{
	[Serializable]
	public class Parameters
	{
		[SerializeField]
		public float LightYaw;

		[SerializeField]
		public float LightPitch;

		[SerializeField]
		public Color LightColor;

		[SerializeField]
		public float LightIntensity;

		[SerializeField]
		public Color ReflectorColor;

		[SerializeField]
		public Color CharacterLightColor;

		[SerializeField]
		public float CharacterLightIntensity;

		[SerializeField]
		public Color CharacterReflectorColor;

		[SerializeField]
		public Color PokeLightColor;

		[SerializeField]
		public float PokeLightIntensity;

		[SerializeField]
		public Color PokeReflectorColor;

		[SerializeField]
		public bool ColorGradingEnable;

		[SerializeField]
		public Texture2D ColorGradingLookup;

		[SerializeField]
		public float ColorGradingInfluence;

		[NonSerialized]
		public Texture2D NexColorGradingLookup;

		[NonSerialized]
		public float ColorGradingBlendWeight;

		[SerializeField]
		public float VertexColorScale;

		[SerializeField]
		public float BloomThreshold;

		[SerializeField]
		public bool FogEnable;

		[SerializeField]
		public float FogStart;

		[SerializeField]
		public float FogEnd;

		[SerializeField]
		public float FogDensity;

		[SerializeField]
		public Color FogNearColor;

		[SerializeField]
		public Color FogFarColor;

		[SerializeField]
		public Color ShadowColor;

		[SerializeField]
		public float CloudShadowScale;

		[SerializeField]
		public float Blurry;

		public Parameters Clone()
		{
			return null;
		}
	}

	[SerializeField]
	public bool CloudShadowEnable;

	[SerializeField]
	private Parameters Morning;

	[SerializeField]
	private Parameters Daytime;

	[SerializeField]
	private Parameters Evening;

	[SerializeField]
	private Parameters Night;

	[SerializeField]
	private Parameters Midnight;

	[SerializeField]
	private bool FixedTime;

	[SerializeField]
	public FogMode FogMode;

	[NonSerialized]
	private Parameters Temporary;

	public Parameters this[PeriodOfDay periodOfDay] => null;

	public static PeriodOfDay GetPrevious(PeriodOfDay periodOfDay)
	{
		return default(PeriodOfDay);
	}

	public static PeriodOfDay GetNext(PeriodOfDay periodOfDay)
	{
		return default(PeriodOfDay);
	}

	public Parameters GetTransition(PeriodOfDay periodOfDay, float weight)
	{
		return null;
	}

	public EnvironmentSettings Clone()
	{
		return null;
	}
}
