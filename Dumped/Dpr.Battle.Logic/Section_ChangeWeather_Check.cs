using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_ChangeWeather_Check : Section
{
	public class Description
	{
		public BtlWeather weather;

		public byte turn;
	}

	public class Result
	{
		public ChangeWeatherResult result;
	}

	public Section_ChangeWeather_Check([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool canOverwrite(BtlWeather nextWeather)
	{
		return default(bool);
	}
}
