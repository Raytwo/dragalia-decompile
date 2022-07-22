using System.Runtime.InteropServices;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_RankEffect : Section
{
	public class Description
	{
		public byte pokeID;

		public byte targetPokeCount;

		public byte[] targetPokeID;

		public WazaRankEffect rankType;

		public sbyte rankVolume;

		public RankEffectCause cause;

		public ushort itemID;

		public uint effectSerial;

		public bool isDisplayTokuseiWindow;

		public bool isStandardMessageDisable;

		public bool isSpFailMessageDisplay;

		public bool byWazaEffect;

		public bool isPreEffectMessageEnable;

		public RankEffectViewType effectViewType;

		public bool isMigawariThrew;

		public StrParam message;
	}

	public class Result
	{
		public bool isSuccessed;
	}

	public Section_FromEvent_RankEffect([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private bool checkTokuseiWindowDisplay([In] ref Description description)
	{
		return default(bool);
	}

	private bool checkEffectiveAny(byte targetPokeCount, byte[] targetPokeID, WazaRankEffect rankType, sbyte rankVolume)
	{
		return default(bool);
	}

	private bool addRankEffect([In] ref Description description)
	{
		return default(bool);
	}

	private StrParam getPreMessage([In] ref Description description)
	{
		return null;
	}

	private bool addRankEffect(byte attackerID, BTL_POKEPARAM target, WazaRankEffect effect, int volume, RankEffectCause cause, ushort itemID, uint rankEffSerial, bool isSpFailMessageDisplay, bool isMigawariThrew, bool isStandardMessageEnable, StrParam preMessage, RankEffectViewType effectViewType)
	{
		return default(bool);
	}

	private BTL_POKEPARAM getPoke(byte pokeID)
	{
		return null;
	}
}
