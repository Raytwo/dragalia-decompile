using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class BattleFlags
{
	public enum Flag : ushort
	{
		FIRST_POKEIN_DONE,
		NUM
	}

	private bool[] m_flags;

	public void Initialize()
	{
	}

	public void CopyFrom([In] ref BattleFlags src)
	{
	}

	public bool Get(Flag flag)
	{
		return default(bool);
	}

	public void Set(Flag flag)
	{
	}

	public void Remove(Flag flag)
	{
	}
}
