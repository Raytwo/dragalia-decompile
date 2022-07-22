using Pml;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public static class WAZADATA
{
	public static WazaTarget GetWazaTarget(WazaNo id)
	{
		return default(WazaTarget);
	}

	public static uint GetHPRecoverRatio(WazaNo id)
	{
		return default(uint);
	}

	public static byte GetHPReactionRatio(WazaNo id)
	{
		return default(byte);
	}

	public static byte GetDamageReactionRatio(WazaNo id)
	{
		return default(byte);
	}

	public static uint GetDamageRecoverRatio(WazaNo id)
	{
		return default(uint);
	}

	public static uint GetShrinkPer(WazaNo id)
	{
		return default(uint);
	}

	public static WazaSick GetSick(WazaNo id)
	{
		return default(WazaSick);
	}

	public static int GetSickPer(WazaNo id)
	{
		return default(int);
	}

	public static byte GetType(WazaNo id)
	{
		return default(byte);
	}

	public static WazaCategory GetCategory(WazaNo id)
	{
		return default(WazaCategory);
	}

	public static WazaDamageType GetDamageType(WazaNo id)
	{
		return default(WazaDamageType);
	}

	public static SickContParam GetSickCont(WazaNo id)
	{
		return default(SickContParam);
	}

	public static WazaRankEffect GetRankEffect(WazaNo id, uint idx, out int volume)
	{
		return default(WazaRankEffect);
	}

	public static byte GetRankEffectCount(WazaNo id)
	{
		return default(byte);
	}

	public static int GetRankEffectPer(WazaNo id, uint idx)
	{
		return default(int);
	}

	public static uint GetPower(WazaNo id)
	{
		return default(uint);
	}

	public static ushort GetHitPer(WazaNo id)
	{
		return default(ushort);
	}

	public static uint GetHitCountMax(WazaNo id)
	{
		return default(uint);
	}

	public static uint GetHitCountMin(WazaNo id)
	{
		return default(uint);
	}

	public static int GetAISeqNo(WazaNo id)
	{
		return default(int);
	}

	public static bool GetFlag(WazaNo id, WazaFlag flag)
	{
		return default(bool);
	}

	public static bool IsValid(WazaNo id)
	{
		return default(bool);
	}

	public static bool IsAlwaysHit(WazaNo id)
	{
		return default(bool);
	}

	public static bool IsMustCritical(WazaNo id)
	{
		return default(bool);
	}

	public static byte GetCriticalRank(WazaNo id)
	{
		return default(byte);
	}

	public static uint GetMaxPP(WazaNo id, uint ppup_cnt)
	{
		return default(uint);
	}

	public static BtlWeather GetWeather(WazaNo id)
	{
		return default(BtlWeather);
	}

	public static int GetPriority(WazaNo id)
	{
		return default(int);
	}

	public static bool IsDamage(WazaNo id)
	{
		return default(bool);
	}

	public static byte GetGPower(WazaNo wazano)
	{
		return default(byte);
	}
}
