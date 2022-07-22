using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_CheckNoEffect_Sub : Section
{
	public class Description
	{
		public WazaParam wazaParam;

		public BTL_POKEPARAM attacker;

		public PokeSet targets;

		public DmgAffRec affinityRecorder;

		public EventID eventID;

		public bool isMustHitEnable;
	}

	public class Result
	{
	}

	public Section_CheckNoEffect_Sub([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool checkNoEffect(WazaParam wazaParam, BTL_POKEPARAM attacker, BTL_POKEPARAM target, DmgAffRec affinityRecorder, EventID eventID, bool fEnableMessage)
	{
		return default(bool);
	}
}
