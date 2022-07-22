using Pml.Battle;

namespace Dpr.Battle.Logic;

public sealed class HITCHECK_PARAM
{
	public byte countMax;

	public byte count;

	public bool needCheckEveryTime;

	public bool isPluralHitWaza;

	public TypeAffinity.AffinityID pluralHitAffinity;

	public bool isDeadMessageDisplay;

	public bool isAffinityMessageDisplay;

	public bool IsPluralHitWaza(byte max)
	{
		return default(bool);
	}

	public bool IsPluralHitException()
	{
		return default(bool);
	}

	public bool IsFirstTime()
	{
		return default(bool);
	}

	public void SetPluralHitAffinity(TypeAffinity.AffinityID affinity)
	{
	}
}
