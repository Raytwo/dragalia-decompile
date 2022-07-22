using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_ConsumeItem : Section
{
	public class Description
	{
		public byte userPokeID;

		public bool isUseActionDisable;

		public bool isKinomiCheckDisable;

		public bool isConsumeMessageEnable;

		public StrParam successMessage;
	}

	public class Result
	{
	}

	public Section_FromEvent_ConsumeItem([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private void removeItem(BTL_POKEPARAM poke)
	{
	}

	private void afterItemEquip(BTL_POKEPARAM poke, ushort itemID, bool isKinomiCheckEnable)
	{
	}
}
