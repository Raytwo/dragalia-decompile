using System.Runtime.InteropServices;
using Pml.Battle;

namespace Dpr.Battle.Logic;

public sealed class Section_CheckWazaDamageAffinity : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public BTL_POKEPARAM defender;

		public WazaParam wazaParam;

		public bool checkOnlyAttacker;
	}

	public class Result
	{
		public TypeAffinity.AffinityID typeAffinity;

		public bool isNoEffectByFloatingStatus;
	}

	public Section_CheckWazaDamageAffinity([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	public TypeAffinity.AffinityID rewiteWazaAffinityByFloatingStatus(ref bool isNoEffectByFloatingStatus, BTL_POKEPARAM attacker, BTL_POKEPARAM defender, byte wazaType, TypeAffinity.AffinityID affinity)
	{
		return default(TypeAffinity.AffinityID);
	}

	private bool checkFloating(BTL_POKEPARAM pPoke, bool isIncludeHikouType)
	{
		return default(bool);
	}

	public TypeAffinity.AffinityID rewiteWazaAffinityByTarSick(BTL_POKEPARAM defender, byte wazaType, TypeAffinity.AffinityID affinity)
	{
		return default(TypeAffinity.AffinityID);
	}
}
