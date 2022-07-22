using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class WazaRobParam
{
	public byte robberCount;

	public byte[] robberPokeID;

	public BtlPokePos[] targetPos;

	public byte[] targetPokeID;

	public void Add(byte robberPokeID, byte targetPokeID, BtlPokePos targetPos)
	{
	}

	public void CopyFrom([In] ref WazaRobParam src)
	{
	}

	public void Clear()
	{
	}
}
