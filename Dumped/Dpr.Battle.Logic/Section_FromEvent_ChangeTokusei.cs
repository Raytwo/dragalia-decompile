using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_ChangeTokusei : Section
{
	public class Description
	{
		public byte userPokeID;

		public byte targetPokeID;

		public TokuseiNo tokuseiID;

		public TokuseiChangeCause cause;

		public bool isEffectiveToSameTokusei;

		public bool isSkipMemberInEvent;

		public bool isDisplayTokuseiWindow;

		public StrParam successMessage;
	}

	public class Result
	{
		public bool isChanged;
	}

	public Section_FromEvent_ChangeTokusei([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private void afterTokuseiChanged_Item(BTL_POKEPARAM poke, TokuseiNo prevTokusei, TokuseiNo nextTokusei)
	{
	}
}
