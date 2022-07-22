using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_TurnCheck_Weather : Section
{
	public class Description
	{
	}

	public class Result
	{
		public bool isExpGet;
	}

	public Section_TurnCheck_Weather([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void endWeather(BtlWeather weather)
	{
	}

	private void afterChangeWeather(BtlWeather weather)
	{
	}

	private void changeWeather(BtlWeather weather)
	{
	}

	private void weatherDamage_All()
	{
	}

	private void storeFrontPokeByAgilityOrder(PokeSet pPokeSet)
	{
	}

	private bool isWeatherDamageTarget(BTL_POKEPARAM poke)
	{
		return default(bool);
	}

	private bool needSummarizeWeatherDamageMessage()
	{
		return default(bool);
	}

	private void putSummarizedWeatherDamageMessage(ushort reservedQueuePos)
	{
	}

	private BtlWeather geWeather()
	{
		return default(BtlWeather);
	}

	private bool applyWeatherDamage(BTL_POKEPARAM pTarget, bool canPutMessage)
	{
		return default(bool);
	}

	private BtlWeather getLoaclWeather(byte pokeID)
	{
		return default(BtlWeather);
	}

	private bool weatherDamage(BTL_POKEPARAM poke, BtlWeather weather, uint damage, byte damageCausePokeID, bool canPutMessage)
	{
		return default(bool);
	}

	private bool weatherDamage_IsEnable(BTL_POKEPARAM poke, uint damage)
	{
		return default(bool);
	}

	private void weatherDamage_Damage(BTL_POKEPARAM poke, uint damage, byte damageCausePokeID)
	{
	}

	private void weatherDamage_Message(BtlWeather weather, byte pokeID)
	{
	}

	private void weatherDamage_Effect(byte pokeID)
	{
	}

	private void checkPokeDead(BTL_POKEPARAM poke)
	{
	}

	private bool checkExpGet()
	{
		return default(bool);
	}
}
