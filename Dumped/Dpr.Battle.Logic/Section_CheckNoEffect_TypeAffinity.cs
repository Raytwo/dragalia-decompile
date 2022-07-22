using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_CheckNoEffect_TypeAffinity : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public WazaParam wazaParam;

		public DmgAffRec affinityRecorder;

		public PokeSet targets;

		public ActionRecorder actionRecorder;
	}

	public class Result
	{
	}

	public Section_CheckNoEffect_TypeAffinity([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void putNoEffectMessage(BTL_POKEPARAM target, [In] ref DmgAffRec affinityRecorder)
	{
	}

	private void putNoEffectMessageByFlying(BTL_POKEPARAM defender)
	{
	}

	private void incNoEffectCount(BTL_POKEPARAM attacker, BTL_POKEPARAM target)
	{
	}

	private void checkBattleTalk(byte pokeID)
	{
	}
}
