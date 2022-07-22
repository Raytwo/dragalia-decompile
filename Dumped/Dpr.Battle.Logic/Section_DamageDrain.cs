using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_DamageDrain : Section
{
	public class Description
	{
		public WazaParam wazaParam;

		public BTL_POKEPARAM attacker;

		public BTL_POKEPARAM defender;

		public uint damage;
	}

	public class Result
	{
	}

	public Section_DamageDrain([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private uint calcRecoverVolume(WazaParam wazaParam, uint damage)
	{
		return default(uint);
	}

	private bool drain(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, uint damage)
	{
		return default(bool);
	}
}
