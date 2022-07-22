using System;
using System.Collections;
using System.Runtime.InteropServices;
using Audio;
using Dpr.Battle.Logic;
using Dpr.Battle.View.Objects;
using Dpr.SequenceEditor;
using UnityEngine;

namespace Dpr.Battle.View.Systems;

public sealed class BattleWeatherSystem
{
	private class WeatherParam
	{
		public BtlvWeather weather;

		public string mainFileName;

		public string cameraFileName;

		public string rangeFileName;

		public string registerName;

		public Vector3 cameraEffctScale;

		public float lightPower;

		public int time;

		public int shortTime;

		public void SetParam(WeatherParam param)
		{
		}
	}

	private BattleViewSystem _pViewSystem;

	private BtlvEffectInstance _iPtrWeatherEffectMain;

	private BtlvEffectInstance _iPtrWeatherEffectCamera;

	private BtlvEffectInstance _iPtrWeatherEffectRange;

	private WeatherParam _currentWeatherParam;

	private WeatherParam _reservationWeatherParam;

	private bool _shortMode;

	private AudioInstance _audio;

	private Coroutine _changeWeatherCol;

	private Action<BtlvWeather, BtlvWeather> _onChanged;

	public static BtlvWeather BtlWeatherToBtlvWeather(BtlWeather wather)
	{
		return default(BtlvWeather);
	}

	public void Initialize(BtlWeather weather, BattleViewSystem pViewSystem)
	{
	}

	public void Request(BtlWeather weather, [Optional] Action<BtlvWeather, BtlvWeather> onChanged)
	{
	}

	public void Request(BtlvWeather weather, [Optional] Action<BtlvWeather, BtlvWeather> onChanged)
	{
	}

	private IEnumerator ChangeWeather(BtlvWeather weather)
	{
		return null;
	}

	private IEnumerator PlayWeatherEffect()
	{
		return null;
	}

	private IEnumerator LoadWeatherEffect(string file, Action<BtlvEffectInstance> setter, SEQ_DEF_EFF_DRAWTYPE drawType = SEQ_DEF_EFF_DRAWTYPE.SEQ_DEF_EFF_DRAWTYPE_NORAML)
	{
		return null;
	}

	private void SetColors(float duration)
	{
	}

	private void SetInitColors(float weight)
	{
	}

	private bool CheckAlreadyChanged()
	{
		return default(bool);
	}

	private IEnumerator EffectStop(BtlvWeather nextWeather)
	{
		return null;
	}

	private bool LoadWeatherParam(BtlvWeather weather)
	{
		return default(bool);
	}

	public void SetWeatherVisibility(bool visible)
	{
	}
}
