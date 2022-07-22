using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaExec_Category_SimpleRecover : Section
{
	public class Description
	{
		public WazaParam wazaParam;

		public BTL_POKEPARAM attacker;

		public PokeSet targets;
	}

	public class Result
	{
	}

	public Section_WazaExec_Category_SimpleRecover([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private uint calcRecoverVolume(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaNo wazano)
	{
		return default(uint);
	}

	private void getRecoverMessage(StrParam pMessage, BTL_POKEPARAM pAttacker, BTL_POKEPARAM pTarget, WazaNo wazano)
	{
	}

	private bool recoverHP(BTL_POKEPARAM target, ushort recoverHP, [In] ref StrParam recoverMsg)
	{
		return default(bool);
	}
}
