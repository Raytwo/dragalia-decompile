using System.Runtime.InteropServices;
using Pml.Battle;

namespace Dpr.Battle.Logic;

public sealed class DamageCalcResult
{
	public class RECORD
	{
		public ushort damage;

		public byte pokeID;

		public TypeAffinity.AffinityID affinity;

		public KoraeruCause koraeruCause;

		public bool isCritical;

		public bool isCriticalByFriendship;

		public bool isFixDamage;

		public bool isMigawari;

		public void Clear()
		{
		}

		public void CopyFrom(RECORD src)
		{
		}
	}

	public byte realHitCount;

	public byte migawariHitCount;

	public RECORD[] record;

	public void CopyFrom([In] ref DamageCalcResult src)
	{
	}

	public void Merge([In] ref DamageCalcResult src)
	{
	}

	public uint GetTargetCount()
	{
		return default(uint);
	}

	public uint GetDamageSum()
	{
		return default(uint);
	}
}
