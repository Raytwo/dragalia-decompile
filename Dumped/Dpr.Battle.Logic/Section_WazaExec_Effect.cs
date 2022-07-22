using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaExec_Effect : Section
{
	public class Description
	{
		public BTL_POKEPARAM pAttacker;

		public ActionDesc pActionDesc;

		public WazaParam pWazaParam;

		public WazaEffectReservedPos pQueReservePos;

		public bool isWazaValid;
	}

	public class Result
	{
	}

	public Section_WazaExec_Effect([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void putWazaEffectCommand(WazaEffectParams pWazaEffect, WazaParam wazaParam, WazaEffectReservedPos pQueReservePos)
	{
	}

	private void eventOnWazaEffective(BTL_POKEPARAM poke, WazaParam wazaParam, ActionDesc actionDesc)
	{
	}

	private void onNotEffective(BTL_POKEPARAM poke, WazaParam wazaParam, ActionDesc actionDesc)
	{
	}
}
