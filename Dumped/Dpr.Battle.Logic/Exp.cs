using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public static class Exp
{
	public class CalcParam
	{
		public BtlCompetitor competitor;

		public uint playerLanguageId;

		public uint levelCap;

		public uint deadPokeExp;

		public uint deadPokeLevel;

		public uint getPokeLevel;

		public uint getPokeFriendship;

		public uint getPokeLanguageId;

		public bool isMatch;

		public bool isGakusyusoutiOn;

		public bool haveSiawasetamago;

		public bool isEvoCanceledPoke;

		public bool isMyPoke;
	}

	public class CalcResult
	{
		public uint exp;

		public bool byGakusyusouti;

		public bool isContainBonus;
	}

	public static void CalcExp([In] ref CalcParam calcParam, CalcResult pResult)
	{
	}

	private static uint CalcBaseExp(uint deadPokeExp, uint deadPokeLevel, uint pokeLevel)
	{
		return default(uint);
	}

	private static uint CalcGakusyusoutiExp(uint baseExp)
	{
		return default(uint);
	}

	private static uint getexp_calc_adjust_level(uint base_exp, ushort getpoke_lv, ushort deadpoke_lv)
	{
		return default(uint);
	}

	private static float calc_adjust_level_sub(float fValue)
	{
		return default(float);
	}

	private static uint ApplyBonus_Received(uint exp, uint playerLangId, uint pokeLangId)
	{
		return default(uint);
	}

	private static uint ApplyBonus_Siawasetamago(uint exp)
	{
		return default(uint);
	}

	private static uint ApplyBonus_EvoCanceled(uint exp)
	{
		return default(uint);
	}

	private static uint ApplyBonus_Friendship(uint exp)
	{
		return default(uint);
	}
}
