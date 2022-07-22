using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class EscapeInfo
{
	private class PARAM
	{
		public uint count;

		public byte[] clientID;
	}

	private PARAM m_param;

	public uint GetCount()
	{
		return default(uint);
	}

	private void clear()
	{
	}

	public void Clear()
	{
	}

	public void Add(byte clientID)
	{
	}

	public BtlResult CheckWinner([In] ref MainModule mainModule, byte myClientID, BtlCompetitor competitorType)
	{
		return default(BtlResult);
	}

	public void Copy(EscapeInfo dst)
	{
	}
}
