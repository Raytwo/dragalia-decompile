using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaExec_Category_FieldEffect : Section
{
	public class Description
	{
		public WazaParam wazaParam;

		public BTL_POKEPARAM attacker;
	}

	public class Result
	{
	}

	public Section_WazaExec_Category_FieldEffect([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void execute_Weather(BTL_POKEPARAM attacker, BtlWeather weather)
	{
	}

	private ChangeWeatherResult changeWeather(BtlWeather weather, byte turnUpCount, byte causePokeID)
	{
		return default(ChangeWeatherResult);
	}

	private void putFailMessage_ByStrongWeather()
	{
	}

	private void execute_Others(WazaParam wazaParam, BTL_POKEPARAM attacker)
	{
	}
}
