using System.Runtime.InteropServices;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class Section_RankEffect : Section
{
	public class Description
	{
		public byte atkPokeID;

		public BTL_POKEPARAM pTarget;

		public WazaRankEffect effect;

		public int volume;

		public RankEffectCause cause;

		public ushort itemID;

		public uint rankEffSerial;

		public bool canPutFailMessage;

		public bool bMigawariThrew;

		public SimpleEffectFailManager pSimpleEffectFailManager;

		public bool fStdMsg;

		public StrParam preMessage;

		public RankEffectViewType effectViewType;
	}

	public class Result
	{
		public bool isValid;

		public int effectedVolume;
	}

	public Section_RankEffect([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description desc)
	{
	}

	private bool checkEffective([In] ref Description desc)
	{
		return default(bool);
	}

	private int rankValueChangeEvent([In] ref Description desc)
	{
		return default(int);
	}

	private void rankEffectFixEvent([In] ref Description desc, int volume)
	{
	}

	private bool checkReflect([In] ref Description desc, int volume)
	{
		return default(bool);
	}

	private void reflectRankEffect([In] ref Description desc, int volume)
	{
	}
}
