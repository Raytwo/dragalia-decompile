using Pml.Battle;

namespace Dpr.Battle.Logic;

public class DamageProcParams
{
	public BTL_POKEPARAM[] bpp;

	public ushort[] dmg;

	public TypeAffinity.AffinityID[] affAry;

	public CriticalType[] criticalTypes;

	public KoraeruCause[] koraeru_cause;
}
