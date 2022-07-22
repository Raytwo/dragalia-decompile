using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dpr.Battle.Logic;
using Dpr.Battle.View.Systems;
using UnityEngine;

public sealed class SkyColorSettings : MonoBehaviour
{
	[Serializable]
	public struct Property
	{
		[SerializeField]
		public Color upperColor;

		[SerializeField]
		public float upperIntensity;

		[SerializeField]
		public Color lowerColor;

		[SerializeField]
		public float lowerIntensity;

		[SerializeField]
		public float starlightPower;

		[SerializeField]
		public Vector4 starlightTiling;

		[SerializeField]
		public Color sceneryColor;

		[SerializeField]
		public Color cloudColor;

		[SerializeField]
		public Color shadowColor;

		[SerializeField]
		public float farCloudSpeed;

		[SerializeField]
		public float nearCloudSpeed;
	}

	public const int PERIODO_OF_TIME_NUM = 5;

	private static bool _set_property_id;

	private static readonly int _upper_color_id;

	private static readonly int _lower_color_id;

	private static readonly int _starlight_power_id;

	private static readonly int _starlight_st_id;

	private static readonly int _scenery_color_id;

	private static readonly int _cloud_color_id;

	private static readonly int _shadow_color_id;

	private static readonly int _near_speed_id;

	private static readonly int _far_speed_id;

	[SerializeField]
	public Renderer _renderer;

	[SerializeField]
	public Property _morning;

	[SerializeField]
	public Property _daytime;

	[SerializeField]
	public Property _evening;

	[SerializeField]
	public Property _night;

	[SerializeField]
	public Property _midnight;

	[SerializeField]
	public Property[] _none;

	[SerializeField]
	public Property[] _shine;

	[SerializeField]
	public Property[] _rain;

	[SerializeField]
	public Property[] _snow;

	[SerializeField]
	public Property[] _sand;

	[SerializeField]
	public Property[] _cloud;

	[SerializeField]
	private BtlvWeather _currentWeather;

	[SerializeField]
	private PeriodOfDay _periodOfDay;

	[SerializeField]
	private float _weight;

	private BtlWeather _prevWeather;

	private static MaterialPropertyBlock _propertyBlock;

	public static SkyColorSettings global
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

	public BtlvWeather CurrentWeather
	{
		get
		{
			return default(BtlvWeather);
		}
		private set
		{
		}
	}

	public float Weight
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	private void OnValidate()
	{
	}

	private Property QueryProperty()
	{
		return default(Property);
	}

	private void SetParameters()
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

	public Property GetProperty(BtlvWeather weather, PeriodOfDay periodOfDay)
	{
		return default(Property);
	}

	public Property[] GetProperties(BtlvWeather weather)
	{
		return null;
	}

	public BtlvWeather GetWeather()
	{
		return default(BtlvWeather);
	}

	public void SetWeather(BtlvWeather weather, PeriodOfDay periodOfDay, float weight = 1f)
	{
	}

	public void SetWeather(BtlWeather weather, PeriodOfDay periodOfDay, float weight = 1f)
	{
	}

	public void ResetSkyColor()
	{
	}

	public void ChangeWeather(BtlvWeather fromWeather, BtlvWeather toWeather, PeriodOfDay periodOfDay, float weight = 0f)
	{
	}

	public void ChangeWeather(BtlvWeather fromWeather, BtlvWeather toWeather, PeriodOfDay periodOfDay, float duration, [Optional] Action onComplete)
	{
	}

	public void ChangeWeather(BtlvWeather fromWeather, BtlvWeather toWeather, float duration, [Optional] Action onComplete)
	{
	}

	public void ChangeTemporaryPeriodOfDay(PeriodOfDay periodOfDay, float duration = 0f, [Optional] Action onComplete)
	{
	}
}
