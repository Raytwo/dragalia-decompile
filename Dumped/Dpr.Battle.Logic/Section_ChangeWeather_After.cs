using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_ChangeWeather_After : Section
{
	public class Description
	{
		public BtlWeather weather;
	}

	public class Result
	{
	}

	public Section_ChangeWeather_After([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}
}
