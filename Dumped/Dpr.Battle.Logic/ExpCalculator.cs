using System.Runtime.InteropServices;
using Pml.Personal;
using Pml.PokePara;

namespace Dpr.Battle.Logic;

public static class ExpCalculator
{
	public class CalcExpWork
	{
		public uint exp;

		public byte hp;

		public byte pow;

		public byte def;

		public byte agi;

		public byte sp_pow;

		public byte sp_def;

		public byte g;

		public bool fBonus;

		public bool bGakusyuSouti;

		public bool bGakusyuSoutiOnly;

		public void Clear()
		{
		}

		public void Marge([In] ref CalcExpWork rhs)
		{
		}
	}

	public class CalcExpContainer
	{
		public CalcExpWork[] work;

		public void Clear()
		{
		}

		public bool IsExpExist()
		{
			return default(bool);
		}

		public void Marge([In] ref CalcExpContainer rhs)
		{
		}
	}

	public class CalcParam
	{
		public MyStatus myStatus;

		public MainModule mainModule;

		public BTL_PARTY party;

		public BTL_POKEPARAM deadPoke;

		public bool canGainEffortValue;

		public bool canGainGEffort;
	}

	private enum kStatusIndex
	{
		_HP,
		_POW,
		_DEF,
		_AGI,
		_SPOW,
		_SDEF,
		_PARAM_MAX
	}

	private struct calcEffortExp_PokeTableElem
	{
		public ParamID personalParamID;

		public PowerID pokeParamID;

		public ushort boostItemID;

		public calcEffortExp_PokeTableElem(ParamID personalParamID, PowerID pokeParamID, ushort boostItemID)
		{
		}
	}

	private static readonly calcEffortExp_PokeTableElem[] RelationTbl;

	private static readonly ParamID[] PERSONAL_PARAM_TABLE;

	public static bool CalcExp(CalcExpContainer result, [In] ref CalcParam param)
	{
		return default(bool);
	}

	private static void calcExp_Party(CalcExpContainer result, MyStatus myStatus, [In] ref MainModule mainModule, [In] ref BTL_PARTY party, [In] ref BTL_POKEPARAM deadPoke)
	{
	}

	private static void calcExp_Poke(CalcExpWork result, MyStatus myStatus, [In] ref MainModule mainModule, [In] ref BTL_POKEPARAM bpp, [In] ref BTL_POKEPARAM deadPoke)
	{
	}

	private static uint getPokeGiveExp([In] ref BTL_POKEPARAM bpp)
	{
		return default(uint);
	}

	private static bool isEvoCanceledPoke([In] ref BTL_POKEPARAM bpp)
	{
		return default(bool);
	}

	private static void calcEffortExp_Party(CalcExpContainer result, [In] ref BTL_PARTY party, [In] ref BTL_POKEPARAM deadPoke)
	{
	}

	private static void calcEffortExp_Poke(CalcExpWork result, [In] ref BTL_POKEPARAM bpp, [In] ref BTL_POKEPARAM deadPoke)
	{
	}

	private static void calcGEffort_Party(CalcExpContainer result, [In] ref BTL_PARTY party, [In] ref BTL_POKEPARAM deadPoke)
	{
	}

	private static void calcGEffort_Poke(CalcExpWork result, [In] ref BTL_POKEPARAM bpp, [In] ref BTL_POKEPARAM deadPoke)
	{
	}
}
