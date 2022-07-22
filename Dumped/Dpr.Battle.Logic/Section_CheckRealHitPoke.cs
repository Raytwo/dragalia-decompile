using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_CheckRealHitPoke : Section
{
	public class Description
	{
		public DamageCalcResult damageRecord;

		public DamageProcParams damageProcParams;
	}

	public class Result
	{
		public byte realHitPokeCount;
	}

	public Section_CheckRealHitPoke([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private uint storeDamageRecords(DamageProcParams damageProcParams, DamageCalcResult rec)
	{
		return default(uint);
	}

	private void storeDamageRecord(DamageProcParams param, uint paramIdx, DamageCalcResult rec, uint recIdx)
	{
	}
}
