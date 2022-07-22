using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_ChangeWeather : Section
{
	public class Description
	{
		public byte userPokeID;

		public BtlWeather weather;

		public byte turn;

		public byte turnUpCount;

		public bool byAirLock;

		public StrParam successMessage;

		public bool isDisplayTokuseiWindow;
	}

	public class Result
	{
		public bool isSuccessed;
	}

	public Section_FromEvent_ChangeWeather([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private void endWeather_byAirLock(byte userPokeID, bool isTokuseiWindowDisplay, [In] ref StrParam successMessage)
	{
	}

	private void endWeather()
	{
	}

	private void endWeather_After()
	{
	}

	private void startDefaultWeather()
	{
	}

	private bool changeWeather([In] ref Description description)
	{
		return default(bool);
	}

	private ChangeWeatherResult checkWeatherChangeEnable(BtlWeather weather, byte turn)
	{
		return default(ChangeWeatherResult);
	}

	private void changeWeather_Success(byte userPokeID, BtlWeather weather, byte turn, byte turnUpCount, [In] ref StrParam successMessage, bool isDisplayTokuseiWindow)
	{
	}

	private void changeWeatherCore(BtlWeather weather, byte turn, byte turnUpCount, byte causePokeID)
	{
	}

	private void changeWeather_Fail(byte userPokeID, bool isTokuseiWindowDisplay)
	{
	}
}
