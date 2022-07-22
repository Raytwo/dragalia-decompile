using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_CheckNoEffect_Core : Section
{
	public class Description
	{
		public WazaParam wazaParam;

		public BTL_POKEPARAM attacker;

		public BTL_POKEPARAM target;

		public DmgAffRec affinityRecorder;

		public EventID eventID;

		public bool fEnableMessage;
	}

	public class Result
	{
		public bool isNoEffect;
	}

	public Section_CheckNoEffect_Core([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void displayMessage(byte pokeID, bool isTokuseiWindowDisplay, [In] ref StrParam strParam)
	{
	}
}
