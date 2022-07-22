using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_FormChange : Section
{
	public class Description
	{
		public byte pokeID;

		public byte formNo;

		public bool isDontResetFormByOut;

		public bool isEnableInCaseOfDead;

		public bool isDisplayTokuseiWindow;

		public bool isDisplayChangeEffect;

		public StrParam successMessage;
	}

	public class Result
	{
		public bool isChanged;
	}

	public Section_FromEvent_FormChange([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private void formChange([In] ref Description description)
	{
	}
}
