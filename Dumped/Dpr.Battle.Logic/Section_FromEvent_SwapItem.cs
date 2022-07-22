using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_SwapItem : Section
{
	public class Description
	{
		public byte userPokeID;

		public byte targetPokeID;

		public bool isIncRecordCount_StealItemFromWildPoke;

		public bool isDisplayTokuseiWindow;

		public StrParam successMessage1;

		public StrParam successMessage2;

		public StrParam successMessage3;
	}

	public class Result
	{
		public bool isSucceeded;
	}

	public Section_FromEvent_SwapItem([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private void changeItem(BTL_POKEPARAM poke, ushort nextItemID)
	{
	}

	private void checkItemReaction(BTL_POKEPARAM poke)
	{
	}

	private void incRecord_StealItemFromWildPoke(byte targetPokeID, ushort targetItem)
	{
	}
}
