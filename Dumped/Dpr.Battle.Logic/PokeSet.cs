using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public class PokeSet
{
	public enum DamageType
	{
		DMGTYPE_NONE,
		DMGTYPE_REAL,
		DMGTYPE_MIGAWARI
	}

	private BTL_POKEPARAM[] m_bpp;

	private ushort[] m_damage;

	private ushort[] m_migawariDamage;

	private byte[] m_damageType;

	private ushort[] m_sortWork;

	private byte m_count;

	private byte m_countMax;

	private byte m_getIdx;

	private byte m_targetPosCount;

	public void Clear()
	{
	}

	public void Add(BTL_POKEPARAM bpp)
	{
	}

	public void AddWithDamage(BTL_POKEPARAM bpp, ushort damage, bool fMigawariDamage)
	{
	}

	public void Remove(BTL_POKEPARAM bpp)
	{
	}

	public BTL_POKEPARAM Get(uint idx)
	{
		return null;
	}

	public void SeekStart()
	{
	}

	public BTL_POKEPARAM SeekNext()
	{
		return null;
	}

	public bool GetDamage(BTL_POKEPARAM bpp, out uint damage)
	{
		return default(bool);
	}

	public bool GetDamageReal(BTL_POKEPARAM bpp, out uint damage)
	{
		return default(bool);
	}

	public DamageType GetDamageType(BTL_POKEPARAM bpp)
	{
		return default(DamageType);
	}

	public uint GetCount()
	{
		return default(uint);
	}

	public uint GetCountMax()
	{
		return default(uint);
	}

	public uint GetAliveCount()
	{
		return default(uint);
	}

	public void SetDefaultTargetCount(byte cnt)
	{
	}

	public bool IsRemovedAll()
	{
		return default(bool);
	}

	public uint CopyAlive(PokeSet dst)
	{
		return default(uint);
	}

	public uint CopyFriends([In] ref MainModule mainModule, BTL_POKEPARAM bpp, PokeSet dst)
	{
		return default(uint);
	}

	public uint CopyEnemys([In] ref MainModule mainModule, BTL_POKEPARAM bpp, PokeSet dst)
	{
		return default(uint);
	}

	public void RemoveDisablePoke([In] ref PosPoke posPoke)
	{
	}

	public void Swap(byte index1, byte index2)
	{
	}

	public void CopyFrom([In] ref PokeSet src)
	{
	}
}
