using Dpr.Battle.Logic;

public class WeatherWork
{
	public static SYS_WEATHER WeatherID
	{
		get
		{
			return default(SYS_WEATHER);
		}
		set
		{
		}
	}

	public static EffectFieldID GetFieldEffectID()
	{
		return default(EffectFieldID);
	}

	public static void GetBtlWeatherID(out BtlWeather weather, out BtlGround ground, SYS_WEATHER weatherID = SYS_WEATHER.MAX)
	{
	}

	public static bool GetFieldSunny()
	{
		return default(bool);
	}

	public static bool GetFieldRain()
	{
		return default(bool);
	}
}
