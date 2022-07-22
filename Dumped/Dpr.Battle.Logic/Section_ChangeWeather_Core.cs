using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_ChangeWeather_Core : Section
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
	}

	public Section_ChangeWeather_Core([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void afterChangeWeather(BtlWeather weather)
	{
	}

	private void checkBattleTalk(byte pokeID, BtlWeather weather)
	{
	}
}
