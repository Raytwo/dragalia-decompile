using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_DelayWazaDamage : Section
{
	public class Description
	{
		public byte attackerPokeID;

		public byte targetPokeID;

		public BtlPokePos attackerPos;

		public WazaNo wazaID;
	}

	public class Result
	{
		public bool isSucceeded;
	}

	public Section_FromEvent_DelayWazaDamage([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private bool checkWazaInvalid(DmgAffRec pAffinityRecorder, BTL_POKEPARAM pAttacker, WazaParam pWazaParam, ActionDesc actionDesc, PokeSet pTaragets)
	{
		return default(bool);
	}

	private void damageWaza(BTL_POKEPARAM attacker, WazaParam wazaParam, DmgAffRec affinityRecorder, PokeSet targets, ActionDesc actionDesc)
	{
	}
}
