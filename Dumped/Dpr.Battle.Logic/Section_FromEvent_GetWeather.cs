using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_GetWeather : Section
{
	public class Description
	{
		public byte pokeID;
	}

	public class Result
	{
		public BtlWeather weather;
	}

	public Section_FromEvent_GetWeather([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
