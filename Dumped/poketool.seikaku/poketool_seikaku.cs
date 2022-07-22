using Pml.PokePara;

namespace poketool.seikaku;

public static class poketool_seikaku
{
	public enum Seikaku2nd
	{
		TABERU,
		HIRUNE,
		INEMURI,
		TIRAKASU,
		NONBIRI,
		TIKARAZIMAN,
		ABARERU,
		OKORIPPOI,
		KENKA,
		TINOKE,
		ZYOUBU,
		UTAREDUYOI,
		NEBARIDUYOI,
		SINBOUDUYOI,
		GAMANDUYOI,
		KAKEKKO,
		MONOOTO,
		OTTYOKOTYOI,
		OTYOUSIMONO,
		NIGERU,
		KOUKISIN,
		ITAZURA,
		NUKEMEGANAI,
		KANGAEGOTO,
		KITYOUMEN,
		KIGATUYOI,
		MIEPPARI,
		MAKENKI,
		MAKEZUGIRAI,
		GOUZYOU,
		NUM
	}

	private static readonly PowerID[] s_power_priority;

	private static readonly uint[][] s_priority_array;

	public static Seikaku2nd GetSeikaku2nd(CoreParam poke)
	{
		return default(Seikaku2nd);
	}

	private static Seikaku2nd GetSeikaku2nd(uint personalRand, uint talent_hp, uint talent_atk, uint talent_def, uint talent_spatk, uint talent_spdef, uint talent_agi)
	{
		return default(Seikaku2nd);
	}

	public static PowerID GetPowerBySeikaku2nd(Seikaku2nd seikaku2nd)
	{
		return default(PowerID);
	}
}
