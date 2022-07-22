using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SmartPoint.Components;
using UnityEngine;

[ExecuteAlways]
public class EnvironmentController : MonoBehaviour
{
	public enum ShaderMode
	{
		Default,
		Color,
		VertexColor,
		Normal,
		VertexTangentOnly,
		LightIntensity,
		LightReflection,
		LightColorMixed,
		Fresnel,
		Glossy,
		Relfectivity,
		TangentSpaceEyeRay,
		MipLevelsOnly,
		MipLevelsMixed,
		EnvironmentMapDisable,
		UtilityMapChannelR,
		UtilityMapChannelG,
		UtilityMapChannelB,
		UtilityMapChannelA
	}

	public enum WeatherMode
	{
		Sunny,
		Rain,
		Snow
	}

	[Serializable]
	public class Parameters
	{
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
		public Color PokeReflectorColor;

		[SerializeField]
		public float PokeLightIntensity;

		[SerializeField]
		public Vector2 PitchYaw;

		[SerializeField]
		public float VertexColorScale;

		[SerializeField]
		public float BloomThreshold;
	}

	public delegate void UpdateCallback(EnvironmentController controller, float deltaTime);

	private AudioChannel _environmentSound;

	[SerializeField]
	private Texture2D _NoiseTex;

	[SerializeField]
	private Texture2D _SnowTex;

	[SerializeField]
	private Texture2D _SnowNormalTex;

	[SerializeField]
	private ShaderMode _ShaderMode;

	[SerializeField]
	public WeatherMode _WeatherMode;

	[SerializeField]
	private Texture2D _CloudShadowTex;

	[SerializeField]
	private Vector2 _CloudSpeed;

	[SerializeField]
	private Vector2 _CloudTiling;

	[SerializeField]
	private ParticleSystem _rainEffect;

	[SerializeField]
	private Texture2D _EnvironmentMap;

	[SerializeField]
	private Color _ShadowColor;

	[SerializeField]
	private Color _SnowShadowColor;

	[SerializeField]
	public float _Wetness;

	[SerializeField]
	public float _EmissionThreshold;

	[SerializeField]
	public float _EmissionScale;

	[SerializeField]
	public float _CloudShadowScale;

	[SerializeField]
	public float _CloudShadowBase;

	[SerializeField]
	public float _Blurry;

	[SerializeField]
	public float _ShadowDistance;

	[SerializeField]
	public float _ShadowNearPlaneOffset;

	[SerializeField]
	public float _ShadowNormalBias;

	[SerializeField]
	private GameObject _snowField;

	[SerializeField]
	private GameObject _waterField;

	[NonSerialized]
	public UpdateCallback callback;

	public Parameters parameters;

	private Light _light;

	private static readonly int _reflectionColorID;

	private static readonly int _characterLightColorID;

	private static readonly int _characterReflectionColorID;

	private static readonly int _pokeLightColorID;

	private static readonly int _pokeReflectionColorID;

	private static readonly int _vertexColorScaleID;

	private static readonly int _bloomThresholdID;

	private static readonly int _emissionScaleID;

	private static readonly int _emissionThresholdID;

	private static readonly int _cloudShadowID;

	private static readonly int _cloudParamID;

	private static readonly int _cloudScaleID;

	private static readonly int _cloudBaseID;

	private static readonly int _shadowColorID;

	private static readonly int _environmentMapID;

	private static readonly int _snowTexID;

	private static readonly int _snowNormalTexID;

	private static readonly int _noiseTexID;

	private static readonly int _mipTexID;

	private static readonly int _WetnessID;

	private static readonly int _globalBumpScaleID;

	private static readonly int _globalLightPowerID;

	private static readonly int _additionalBlurryID;

	private Texture2D _mipTexture;

	private bool _cloudShadowEnable;

	private bool _throughGlobal;

	private float _savedShadowDistance;

	private float _savedShadowNearPlaneOffset;

	public EnvironmentSettings latestSettings;

	public EnvironmentSettings.Parameters latestParameters;

	public PeriodOfDay periodOfDay;

	[HideInInspector]
	public float AddLightIntensity;

	[HideInInspector]
	public float AddCharacterLightIntensity;

	[HideInInspector]
	public float AddPokeLightIntensity;

	private static List<EnvironmentController> _environmentControllers;

	public static EnvironmentController global
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static float globalBumpScale
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static float globalLightPower
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static bool globalSnowFieldEnable
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static bool globalWaterFieldEnable
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool cloudShadowEnable
	{
		set
		{
		}
	}

	public Texture2D cloudShadowTex
	{
		set
		{
		}
	}

	public float shadowDistance
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float shadowNearPlaneOffset
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public ShaderMode shaderMode
	{
		get
		{
			return default(ShaderMode);
		}
		set
		{
		}
	}

	public bool throughGlobal
	{
		set
		{
		}
	}

	public bool IsActiveController()
	{
		return default(bool);
	}

	public void SetActiveController()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private static void SetKeyword(string keyword, bool state)
	{
	}

	private void OnDestroy()
	{
	}

	public void SetLight(EnvironmentSettings light, PeriodOfDay periodOfDay, float progress, float weight = 0f)
	{
	}

	public void SetPokemonLight(EnvironmentSettings light, PeriodOfDay periodOfDay)
	{
	}

	public void ResetShadowSettings()
	{
	}

	public void OnValidate()
	{
	}
}
