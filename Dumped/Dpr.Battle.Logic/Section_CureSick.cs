using System.Runtime.InteropServices;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class Section_CureSick : Section
{
	public class Description
	{
		public byte pokeID;

		public WazaSickEx sick;

		public byte[] targetPokeID;

		public byte targetPokeCount;

		public ushort itemID;

		public bool isDisplayTokuseiWindow;

		public bool isStandardMessageDisable;

		public StrParam successSpMessage;
	}

	public class Result
	{
		public bool isCured;

		public bool[] isPokeCured;
	}

	public Section_CureSick([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description desc)
	{
	}

	private WazaSick transCureSick(BTL_POKEPARAM poke, ref WazaSickEx exCode)
	{
		return default(WazaSick);
	}

	private bool checkKodawariSick(BTL_POKEPARAM poke, WazaSick sick)
	{
		return default(bool);
	}

	private void putSpecialMessage([In] ref StrParam strParam)
	{
	}

	private void putStandardMessage(WazaSick sick, [In] ref BTL_SICKCONT sickCont, BTL_POKEPARAM poke, ushort itemID)
	{
	}

	private void checkItemReaction(BTL_POKEPARAM poke)
	{
	}
}
