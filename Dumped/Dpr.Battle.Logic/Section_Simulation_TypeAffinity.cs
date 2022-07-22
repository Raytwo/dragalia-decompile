using System.Runtime.InteropServices;
using Pml;
using Pml.Battle;

namespace Dpr.Battle.Logic;

public sealed class Section_Simulation_TypeAffinity : Section
{
	public class Description
	{
		public byte atkPokeID;

		public byte defPokeID;

		public WazaNo waza;

		public bool onlyAttacker;
	}

	public class Result
	{
		public TypeAffinity.AffinityID affinity;
	}

	public Section_Simulation_TypeAffinity([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private TypeAffinity.AffinityID checkTypeAffinity(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaParam wazaParam, bool checkOnlyAttacker)
	{
		return default(TypeAffinity.AffinityID);
	}
}
