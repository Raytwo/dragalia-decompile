using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class TimeLimit
{
	private ushort[] m_clientLimitTime;

	public void CopyFrom([In] ref TimeLimit src)
	{
	}

	public void Clear()
	{
	}

	public ushort GetClientLimitTime(byte clientID)
	{
		return default(ushort);
	}

	public void SetClientLimitTime(byte clientID, ushort time)
	{
	}
}
