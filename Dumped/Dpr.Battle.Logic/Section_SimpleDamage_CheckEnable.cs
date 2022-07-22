using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_SimpleDamage_CheckEnable : Section
{
	public class Description
	{
		public BTL_POKEPARAM poke;

		public uint damage;

		public DamageCause damageCause;
	}

	public class Result
	{
		public bool isEnable;
	}

	public Section_SimpleDamage_CheckEnable([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}
}
