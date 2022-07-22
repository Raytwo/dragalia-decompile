using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_ChangeWeather : Section
{
	public class Description
	{
		public BtlWeather weather;

		public byte turn;

		public byte turnUpCount;

		public byte causePokeID;

		public ChangeWeatherCause cause;
	}

	public class Result
	{
		public ChangeWeatherResult changeResult;
	}

	public Section_ChangeWeather([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private ChangeWeatherResult checkWeatherChangeEnable(BtlWeather weather, byte turn)
	{
		return default(ChangeWeatherResult);
	}

	private void changeWeather(BtlWeather weather, byte turn, byte turnUpCount, byte causePokeID, ChangeWeatherCause cause)
	{
	}
}
