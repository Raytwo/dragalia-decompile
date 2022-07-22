using System.Runtime.InteropServices;
using Pml.PokePara;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public static class GShockMessageSummarizer
{
	private struct RankEffectDesc
	{
		public GShock.Effect gShockEffect;

		public WazaRankEffect rankEffect;

		public int rankVolume;

		public ushort defaultEffectNo;

		public ushort message_unit;

		public ushort message_summarized;

		public RankEffectDesc(GShock.Effect gShockEffect, WazaRankEffect rankEffect, int rankVolume, ushort defaultEffectNo, ushort message_unit, ushort message_summarized)
		{
		}
	}

	private class SickDesc
	{
		public ushort effectNo;

		public ushort message_unit;

		public ushort message_summarized;

		public SickDesc(ushort effectNo, ushort message_unit, ushort message_summarized)
		{
		}
	}

	private class CureSickDesc
	{
		public Sick sick;

		public ushort message_unit;
	}

	private class OthersDesc
	{
		public GShock.Effect gShockEffect;

		public ushort message_unit;

		public ushort message_summarized;
	}

	private static readonly RankEffectDesc[] RANK_EFFECT_DESC;

	private static readonly SickDesc[] SICK_DESC;

	private static CureSickDesc[] CURESICK_DESC;

	private static readonly OthersDesc[] OTHERS_DESC;

	private static bool rank_GetDesc(ref RankEffectDesc pParam, GShock.Effect gShockEffect)
	{
		return default(bool);
	}

	private static void rank_SetupMessage_Unit(StrParam pStrParam, GShock.Effect gShockEffect, byte pokeID, int volume)
	{
	}

	private static void rank_GetMessageParam(StrParam pStrParam, GShock.Effect gShockEffect)
	{
	}

	private static void rank_SetupMessage(out byte pDefaultEffectCount, out byte pUniqueEffectPokeID, [In] ref GShockEffectParam gShockEffectParam)
	{
	}

	private static void rank_SetupMessage(StrParam pStrParam, [In] ref GShockEffectParam gShockEffectParam)
	{
	}

	private static bool sick_GetDesc(out SickDesc pParam, ushort effectNo)
	{
		return default(bool);
	}

	private static void sick_SetupMessage_Unit(StrParam pStrParam, ushort effectNo, ushort pokeID)
	{
	}

	private static void sick_SetupMessage_Plural(StrParam pStrParam, ushort effectNo)
	{
	}

	private static void sick_GetMessageParam(out byte pTargetCount, out byte pEffectNoCount, out byte pUniqueEffectPokeID, out ushort pUniqueEffectNo, [In] ref GShockEffectParam gShockEffectParam)
	{
	}

	private static void sick_SetupMessage(StrParam pStrParam, [In] ref GShockEffectParam gShockEffectParam)
	{
	}

	private static bool cureSick_GetDesc(CureSickDesc pParam, Sick sick)
	{
		return default(bool);
	}

	private static void cureSick_SetupMessage_Unit(StrParam pStrParam, Sick sick, ushort pokeID)
	{
	}

	private static void cureSick_GetMessageParam(out byte pTargetCount, out byte pUniqueEffectPokeID, out Sick pUniqueCuredSick, [In] ref GShockEffectParam gShockEffectParam)
	{
	}

	private static void cureSick_SetupMessage(StrParam pStrParam, [In] ref GShockEffectParam gShockEffectParam)
	{
	}

	private static bool others_GetDesc(OthersDesc pParam, GShock.Effect gShockEffect)
	{
		return default(bool);
	}

	private static void others_SetupMessage_Unit(StrParam pStrParam, GShock.Effect gShockEffect, byte pokeID)
	{
	}

	private static void others_SetupMessage_Plural(StrParam pStrParam, GShock.Effect gShockEffect)
	{
	}

	private static void others_GetMessageParam(out byte pTargetCount, out byte pUniqueEffectPokeID, [In] ref GShockEffectParam gShockEffectParam)
	{
	}

	private static void others_SetupMessage(StrParam pStrParam, [In] ref GShockEffectParam gShockEffectParam)
	{
	}

	public static void SetupMessage(StrParam pStrParam, GShockEffectParam param)
	{
	}
}
