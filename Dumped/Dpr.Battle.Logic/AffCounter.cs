using System.Runtime.InteropServices;
using Pml.Battle;

namespace Dpr.Battle.Logic;

public sealed class AffCounter
{
	private class Data
	{
		public ushort putVoid;

		public ushort putAdvantage;

		public ushort putDisadvantage;

		public ushort recvVoid;

		public ushort recvAdvantage;

		public ushort recvDisadvantage;

		public void CopyFrom(Data src)
		{
		}
	}

	private const int COUNTER_MAX = 9999;

	private Data m_data;

	public ushort GetVoid()
	{
		return default(ushort);
	}

	public ushort GetAdvantage()
	{
		return default(ushort);
	}

	public ushort GetDisadvantage()
	{
		return default(ushort);
	}

	public ushort GetRecvVoid()
	{
		return default(ushort);
	}

	public ushort GetRecvAdvantage()
	{
		return default(ushort);
	}

	public ushort GetRecvDisadvantage()
	{
		return default(ushort);
	}

	public void CopyFrom([In] ref AffCounter src)
	{
	}

	public void Clear()
	{
	}

	public void CountUp([In] ref MainModule mainModule, BTL_POKEPARAM attacker, BTL_POKEPARAM defender, TypeAffinity.AffinityID affinity)
	{
	}

	private void CountUp_Core(ref ushort pCnt)
	{
	}
}
