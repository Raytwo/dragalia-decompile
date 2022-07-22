using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_SetItem : Section
{
	public class Description
	{
		public byte userPokeID;

		public byte targetPokeID;

		public ushort itemID;

		public bool isClearConsume;

		public bool isClearConsumeOtherPoke;

		public byte clearConsumePokeID;

		public bool isCallConsumedEvent;

		public bool isDisplayTokuseiWindow;

		public bool isConsumeItem;

		public StrParam successMessage;
	}

	public class Result
	{
		public bool isSucceeded;
	}

	public Section_FromEvent_SetItem([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private void changeItem(BTL_POKEPARAM poke, ushort nextItemID, bool isConsume)
	{
	}

	private void checkItemReaction(BTL_POKEPARAM poke)
	{
	}
}
