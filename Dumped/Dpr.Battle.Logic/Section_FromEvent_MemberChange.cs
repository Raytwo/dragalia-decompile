using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_MemberChange : Section
{
	public class Description
	{
		public byte outPokeID;

		public bool isInterruptDisable;

		public bool isDisplayTokuseiWindow;

		public StrParam startMessage;

		public StrParam successMessage;
	}

	public class Result
	{
		public bool isSucceeded;
	}

	public Section_FromEvent_MemberChange([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private bool canMemberChange(byte pokeID)
	{
		return default(bool);
	}

	private bool memberOut(BTL_POKEPARAM outPoke, bool isInterruptDisable)
	{
		return default(bool);
	}
}
