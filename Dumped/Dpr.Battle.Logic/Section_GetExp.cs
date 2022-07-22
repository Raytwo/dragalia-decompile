using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_GetExp : Section
{
	public class Description
	{
		public BTL_PARTY pParty;

		public ExpCalculator.CalcExpContainer pExpContainer;
	}

	public class Result
	{
		public bool isExpGet;
	}

	public Section_GetExp([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void addEffortPower(BTL_PARTY party, [In] ref ExpCalculator.CalcExpContainer expContainer)
	{
	}

	private void addEffortPower(BTL_POKEPARAM bpp, [In] ref ExpCalculator.CalcExpWork expWork)
	{
	}

	private void addExp_ByFaced(ref bool isExpGet, ref bool isExist_OnlyGakusyuSoutiExp, BTL_PARTY pParty, [In] ref ExpCalculator.CalcExpContainer expContainer)
	{
	}

	private void addExp_ByGakusyuSouti(ref bool isExpGet, BTL_PARTY pParty, [In] ref ExpCalculator.CalcExpContainer expContainer)
	{
	}

	private void addExp(BTL_POKEPARAM poke, uint exp)
	{
	}

	private bool checkRightsOfGettinExp(out uint exp, out bool isGakusyuSoutiOnly, [In] ref BTL_POKEPARAM poke, [In] ref ExpCalculator.CalcExpWork expWork)
	{
		return default(bool);
	}

	private void putActCommand_InitParam()
	{
	}

	private void putActCommand_SetParam(BTL_PARTY pParty, ExpCalculator.CalcExpContainer pExpContainer)
	{
	}

	private void putActCommand_Execute()
	{
	}
}
