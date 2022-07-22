using Pml;

namespace Dpr.Battle.Logic;

public static class GShock
{
	public enum Effect : byte
	{
		NONE,
		WEATHER_SHINE,
		WEATHER_RAIN,
		WEATHER_SNOW,
		WEATHER_SAND,
		FIELD_ELEC,
		FIELD_GRASS,
		FIELD_MIST,
		FIELD_PSYCO,
		RANKUP_ATK,
		RANKUP_DEF,
		RANKUP_SPATK,
		RANKUP_SPDEF,
		RANKUP_AGI,
		RANKUP_CRITICAL,
		RANKDOWN_ATK,
		RANKDOWN_DEF,
		RANKDOWN_SPATK,
		RANKDOWN_SPDEF,
		RANKDOWN_AGI,
		RANKDOWN_AGI2,
		RANKDOWN_AVOID,
		SICK_DOKU,
		SICK_MAHI,
		SICK_DOKU_MAHI,
		SICK_DOKU_MAHI_NEMURI,
		SICK_KONRAN,
		SICK_MEROMERO,
		SIDE_HONOO,
		SIDE_IWA,
		AURORAVEIL,
		STEALTHROCK,
		STEALTHROCK_HAGANE,
		JURYOKU,
		NEKONIKOBAN,
		TOOSENBOU,
		AKUBI,
		ICHAMON,
		SYUUKAKU,
		SUNAZIGOKU,
		HONOONOUZU,
		KIRIBARAI,
		DECREMENT_PP,
		RECOVER_HP,
		CURE_SICK
	}

	private struct GSHOCK_EFFECT_TABLE_ELEM
	{
		public WazaNo wazano;

		public Effect effect;

		public GSHOCK_EFFECT_TABLE_ELEM(WazaNo wazano, Effect effect)
		{
		}
	}

	private struct GSHOCK_EFFECT_TABLE_SP_ELEM
	{
		public MonsNo monsno;

		public ushort formno;

		public byte wazaType;

		public Effect shockEffect;

		public int specialWazaNameIndex;

		public GSHOCK_EFFECT_TABLE_SP_ELEM(MonsNo monsno, ushort formno, byte wazaType, Effect shockEffect, int specialWazaNameIndex)
		{
		}
	}

	private static readonly GSHOCK_EFFECT_TABLE_ELEM[] GSHOCK_EFFECT_TABLE;

	private static readonly GSHOCK_EFFECT_TABLE_SP_ELEM[] GSHOCK_EFFECT_TABLE_SP;

	public static Effect GetEffect(BTL_POKEPARAM poke, WazaNo wazano)
	{
		return default(Effect);
	}

	public static int GetSpecialWazaNameIndex(MonsNo monsno, ushort formno, bool isG, bool isSpGEnable, WazaNo wazano)
	{
		return default(int);
	}

	public static byte GetSpecialGWazaBaseType(MonsNo monsno, ushort formno)
	{
		return default(byte);
	}
}
