using System.Runtime.InteropServices;
using Pml;
using Pml.Battle;

namespace Dpr.Battle.Logic;

public sealed class Section_CalcDamage : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public PokeSet targets;

		public WazaParam wazaParam;

		public DmgAffRec affRec;

		public int damageRatio;

		public AffCounter affCounter;
	}

	public class Result
	{
		public DamageCalcResult calcResult;
	}

	public Section_CalcDamage([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool checkCritical(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaNo waza, ref bool bFriendshipAct)
	{
		return default(bool);
	}

	public bool getCalcDamage(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaParam wazaParam, TypeAffinity.AffinityID typeAff, int targetDmgRatio, bool isCritical, bool isMigawariExist, out ushort damage)
	{
		return default(bool);
	}

	private uint roundDamage(BTL_POKEPARAM defender, uint damage)
	{
		return default(uint);
	}

	private uint roundDamage_byMigawari(BTL_POKEPARAM defender, uint damage)
	{
		return default(uint);
	}
}
