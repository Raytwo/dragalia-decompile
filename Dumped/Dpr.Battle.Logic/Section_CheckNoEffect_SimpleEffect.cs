using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_CheckNoEffect_SimpleEffect : Section
{
	public class Description
	{
		public ActionDesc actionDesc;

		public WazaParam wazaParam;

		public BTL_POKEPARAM attacker;

		public PokeSet targets;
	}

	public class Result
	{
	}

	public Section_CheckNoEffect_SimpleEffect([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void removeNoEffectTarget(ActionDesc actionDesc, WazaParam wazaParam, BTL_POKEPARAM attacker, PokeSet targets)
	{
	}

	private void checkEffective(out bool pIsEffective, out SimpleEffectFailManager.Result pFailResult, BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaParam wazaParam, uint actionSerialNo)
	{
	}

	private void putFailMessage(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaParam wazaParam, uint actionSerialNo, SimpleEffectFailManager.Result failResult)
	{
	}

	private void putFailMessage_Others(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaParam wazaParam, uint actionSerialNo)
	{
	}
}
