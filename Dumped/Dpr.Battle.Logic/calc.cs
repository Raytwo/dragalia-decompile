using System.Runtime.InteropServices;
using Pml;
using Pml.Battle;
using Pml.Item;
using Pml.Personal;
using Pml.PokePara;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public static class calc
{
	public class ESCAPEINFO
	{
		public uint count;

		public byte[] clientID;
	}

	private struct StatusRankTableElem
	{
		public byte num;

		public byte denom;

		public StatusRankTableElem(byte num, byte denom)
		{
		}
	}

	private struct HitPerTableElem
	{
		public byte num;

		public byte denom;

		public HitPerTableElem(byte num, byte denom)
		{
		}
	}

	private static Random g_RandSys;

	private static Random g_PublicRand;

	private static WazaNo[] g_WazaStoreWork;

	private static bool g_SakasaBtlFlag;

	public static PowerID[] PokePowerIDTable;

	private static readonly StatusRankTableElem[] StatusRankTable;

	private static readonly HitPerTableElem[] HitPerTable;

	private static readonly byte[] CheckCriticalTable;

	private static readonly byte[] PENALTY_COEF;

	public static void BITFLG_Construction(byte[] flags)
	{
	}

	public static void BITFLG_Set(byte[] flags, uint index)
	{
	}

	public static bool BITFLG_Check(byte[] flags, uint index)
	{
		return default(bool);
	}

	public static void BITFLG_Off(byte[] flags, uint index)
	{
	}

	public static uint ABS(int value)
	{
		return default(uint);
	}

	public static void InitSys(Random randSys, bool bSakasaBtl)
	{
	}

	public static void ResetSys(ulong randSeed)
	{
	}

	public static void QuitSys()
	{
	}

	public static Random GetRandGenerator()
	{
		return null;
	}

	public static TypeAffinity.AffinityID TypeAff(PokeType wazaType, PokeType pokeType)
	{
		return default(TypeAffinity.AffinityID);
	}

	public static TypeAffinity.AffinityID TypeAffMul(TypeAffinity.AffinityID aff1, TypeAffinity.AffinityID aff2)
	{
		return default(TypeAffinity.AffinityID);
	}

	public static TypeAffinity.AffinityID TypeAffPair(byte wazaType, PokeTypePair pokeType)
	{
		return default(TypeAffinity.AffinityID);
	}

	public static byte GetResistTypes(PokeType type, byte[] dst)
	{
		return default(byte);
	}

	public static uint DamageBase(uint wazaPower, uint atkPower, uint atkLevel, uint defGuard)
	{
		return default(uint);
	}

	public static uint AffDamage(uint rawDamage, TypeAffinity.AffinityID aff)
	{
		return default(uint);
	}

	public static uint GetPublicRand(uint range)
	{
		return default(uint);
	}

	public static uint GetRand(uint range)
	{
		return default(uint);
	}

	public static uint RandRange(uint min, uint max)
	{
		return default(uint);
	}

	public static uint MulRatio(uint value, int ratio)
	{
		return default(uint);
	}

	public static uint MulRatio_OverZero(uint value, int ratio)
	{
		return default(uint);
	}

	public static uint MulRatioInt(uint value, uint ratio)
	{
		return default(uint);
	}

	public static void MakeDefaultWazaSickCont(WazaSick sick, BTL_POKEPARAM attacker, out BTL_SICKCONT cont)
	{
	}

	public static BTL_SICKCONT MakeWazaSickCont_Poke(byte pokeID, byte causePokeID)
	{
		return default(BTL_SICKCONT);
	}

	public static BTL_SICKCONT MakeDefaultPokeSickCont(Sick sick, byte causePokeID, bool isCantUseRand = false)
	{
		return default(BTL_SICKCONT);
	}

	public static ushort StatusRank(ushort defaultVal, byte rank)
	{
		return default(ushort);
	}

	public static uint QuotMaxHP_Zero(BTL_POKEPARAM bpp, uint denom, bool useBeforeGParam = false)
	{
		return default(uint);
	}

	public static uint QuotMaxHP(BTL_POKEPARAM bpp, uint denom, bool useBeforeGParam = false)
	{
		return default(uint);
	}

	public static byte HitPer(byte defPer, byte rank)
	{
		return default(byte);
	}

	public static bool CheckCritical(byte rank, int ratio)
	{
		return default(bool);
	}

	public static int ITEM_GetParam(ushort item, Pml.Item.ItemData.PrmID paramID)
	{
		return default(int);
	}

	public static bool ITEM_IsBall(ushort itemID)
	{
		return default(bool);
	}

	public static bool ITEM_IsReriveItem(ushort itemID)
	{
		return default(bool);
	}

	public static bool ITEM_IsMail(ushort item)
	{
		return default(bool);
	}

	public static uint PERSONAL_GetParam(int mons_no, int form_no, ParamID paramID)
	{
		return default(uint);
	}

	public static uint PERSONAL_GetMinExp(int monsno, int formno, byte level)
	{
		return default(uint);
	}

	public static bool PERSONAL_IsEvoCancelPokemon(int mons_no, ushort formno, byte level)
	{
		return default(bool);
	}

	public static bool IsBasicSickID(WazaSick sickID)
	{
		return default(bool);
	}

	public static ushort RecvWeatherDamage(BTL_POKEPARAM bpp, BtlWeather weather)
	{
		return default(ushort);
	}

	public static int GetWeatherDmgRatio(BtlWeather weather, byte wazaType)
	{
		return default(int);
	}

	public static bool IsShineWeather(BtlWeather weather)
	{
		return default(bool);
	}

	public static bool IsRainWeather(BtlWeather weather)
	{
		return default(bool);
	}

	public static void WazaSickContToBppSickCont(SickContParam wazaSickCont, BTL_POKEPARAM attacker, out BTL_SICKCONT sickCont)
	{
	}

	public static byte HitCountStd(byte numHitMax)
	{
		return default(byte);
	}

	public static WazaSick CheckMentalSick(BTL_POKEPARAM bpp)
	{
		return default(WazaSick);
	}

	public static TypeAffinity.AboutAffinityID TypeAffAbout(TypeAffinity.AffinityID aff)
	{
		return default(TypeAffinity.AboutAffinityID);
	}

	public static bool IsOccurPer(uint per)
	{
		return default(bool);
	}

	public static int Roundup(int value, int min)
	{
		return default(int);
	}

	public static int Rounddown(int val, int max)
	{
		return default(int);
	}

	public static int RoundValue(int val, int min, int max)
	{
		return default(int);
	}

	public static WazaTarget GetWazaTarget(WazaNo waza, BTL_POKEPARAM attacker)
	{
		return default(WazaTarget);
	}

	public static WazaTarget GetNoroiTargetType(BTL_POKEPARAM attacker)
	{
		return default(WazaTarget);
	}

	public static BtlPokePos DecideWazaTargetAuto(MainModule mainModule, POKECON pokeCon, BTL_POKEPARAM bpp, WazaNo waza, bool IsClient = false)
	{
		return default(BtlPokePos);
	}

	public static uint PokeIDx6_Pack32bit(byte[] pokeIDList)
	{
		return default(uint);
	}

	public static void PokeIDx6_Unpack32bit(uint pack, byte[] pokeIDList)
	{
	}

	public static bool is_include(WazaNo[] tbl, uint tblElems, WazaNo wazaID)
	{
		return default(bool);
	}

	public static WazaNo RandWaza(WazaNo[] omitWazaTbl, ushort tblElems)
	{
		return default(WazaNo);
	}

	public static BtlPokePos DecideWazaTargetAutoForClient(MainModule mainModule, POKECON pokeCon, BTL_POKEPARAM bpp, WazaNo waza, ref ulong pRandContextSaveWork)
	{
		return default(BtlPokePos);
	}

	public static bool RULE_IsNeedSelectTarget(BtlRule rule)
	{
		return default(bool);
	}

	public static byte RULE_HandPokeIndex(BtlRule rule, byte numCoverPos)
	{
		return default(byte);
	}

	public static uint calcWinMoney_Sub([In] ref BSP_TRAINER_DATA trData, [In] ref PokeParty party)
	{
		return default(uint);
	}

	public static uint CalcWinMoney(BATTLE_SETUP_PARAM sp)
	{
		return default(uint);
	}

	public static uint CalcLoseMoney(BATTLE_SETUP_PARAM sp, POKECON pokeCon)
	{
		return default(uint);
	}

	private static uint CalcPenaltyMoney(uint level_max)
	{
		return default(uint);
	}
}
