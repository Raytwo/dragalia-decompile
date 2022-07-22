using Pml.Battle;

namespace Dpr.Battle.Logic;

public sealed class DmgAffRec
{
	private class AffinityData
	{
		public TypeAffinity.AffinityID typeAffinity;

		public bool isNoEffectByFloatingStatus;
	}

	private AffinityData[] m_affinityData;

	public void Init()
	{
	}

	public void Add(byte pokeID, TypeAffinity.AffinityID aff, bool isNoEffectByFloatingStatus)
	{
	}

	public TypeAffinity.AffinityID Get(byte pokeID)
	{
		return default(TypeAffinity.AffinityID);
	}

	public TypeAffinity.AffinityID GetIfEnable(byte pokeID)
	{
		return default(TypeAffinity.AffinityID);
	}

	public bool IsNoEffectByFloatingStatus(byte pokeID)
	{
		return default(bool);
	}
}
