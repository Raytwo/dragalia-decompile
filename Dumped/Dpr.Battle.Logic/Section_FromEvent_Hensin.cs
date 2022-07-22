using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_Hensin : Section
{
	public class Description
	{
		public byte userPokeID;

		public byte targetPokeID;

		public bool isDisplayTokuseiWindow;

		public StrParam successMessage;
	}

	public class Result
	{
		public bool isSucceeded;
	}

	public Section_FromEvent_Hensin([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private void afterTokuseiChanged_Event(BTL_POKEPARAM poke)
	{
	}

	private void afterTokuseiChanged_Item(BTL_POKEPARAM poke, TokuseiNo prevTokusei, TokuseiNo nextTokusei)
	{
	}
}
