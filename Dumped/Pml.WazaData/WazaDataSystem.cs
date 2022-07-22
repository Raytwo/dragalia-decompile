using XLSXContent;

namespace Pml.WazaData;

public static class WazaDataSystem
{
	public const int RANK_STORE_MAX = 3;

	public const int HITRATIO_MUST = 101;

	public const int CRITICAL_MUST = 6;

	public static WazaTable s_wazaTable;

	public static void Initialize(WazaTable wazaTable)
	{
	}

	public static void Finalize_()
	{
	}

	public static WazaTable.SheetWaza Get(WazaNo id)
	{
		return null;
	}

	public static bool IsValid(WazaNo id)
	{
		return default(bool);
	}

	public static bool GetFlag(WazaNo id, WazaFlag flag)
	{
		return default(bool);
	}

	public static uint GetMaxPP(WazaNo id, uint maxupcnt)
	{
		return default(uint);
	}

	public static uint GetPower(WazaNo id)
	{
		return default(uint);
	}

	public static byte GetType(WazaNo id)
	{
		return default(byte);
	}

	public static WazaDamageType GetDamageType(WazaNo id)
	{
		return default(WazaDamageType);
	}

	public static WazaCategory GetCategory(WazaNo id)
	{
		return default(WazaCategory);
	}

	public static int GetPriority(WazaNo id)
	{
		return default(int);
	}

	public static ushort GetHitPer(WazaNo id)
	{
		return default(ushort);
	}

	public static bool IsAlwaysHit(WazaNo id)
	{
		return default(bool);
	}

	public static uint GetHitCountMax(WazaNo id)
	{
		return default(uint);
	}

	public static uint GetHitCountMin(WazaNo id)
	{
		return default(uint);
	}

	public static bool IsMustCritical(WazaNo id)
	{
		return default(bool);
	}

	public static uint GetShrinkPer(WazaNo id)
	{
		return default(uint);
	}

	public static bool IsDamage(WazaNo id)
	{
		return default(bool);
	}

	public static byte GetCriticalRank(WazaNo id)
	{
		return default(byte);
	}

	public static WazaWeather GetWeather(WazaNo wazano)
	{
		return default(WazaWeather);
	}

	public static WazaSick GetSick(WazaNo id)
	{
		return default(WazaSick);
	}

	public static int GetSickPer(WazaNo id)
	{
		return default(int);
	}

	public static SickContParam GetSickCont(WazaNo id)
	{
		return default(SickContParam);
	}

	public static byte GetRankEffectCount(WazaNo id)
	{
		return default(byte);
	}

	public static WazaRankEffect GetRankEffect(WazaNo id, uint idx, out int volume)
	{
		return default(WazaRankEffect);
	}

	public static int GetRankEffectPer(WazaNo id, uint idx)
	{
		return default(int);
	}

	public static uint GetDamageRecoverRatio(WazaNo id)
	{
		return default(uint);
	}

	public static uint GetHPRecoverRatio(WazaNo id)
	{
		return default(uint);
	}

	public static WazaTarget GetTarget(WazaNo id)
	{
		return default(WazaTarget);
	}

	public static int GetAISeqNo(WazaNo id)
	{
		return default(int);
	}

	public static byte GetDamageReactionRatio(WazaNo id)
	{
		return default(byte);
	}

	public static byte GetHPReactionRatio(WazaNo id)
	{
		return default(byte);
	}

	public static byte GetGPower(WazaNo id)
	{
		return default(byte);
	}

	public static ushort[] GetYubiWoHuruPermitWazaTable()
	{
		return null;
	}

	public static uint GetContestWazaNo(WazaNo id)
	{
		return default(uint);
	}
}
