using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class PokeChangeRequest
{
	private readonly MainModule m_pMainModule;

	private BtlPokePos[] m_requestPos;

	private byte m_requestCount;

	public PokeChangeRequest(MainModule pMainModule)
	{
	}

	public void Clear()
	{
	}

	public void Request(BtlPokePos pos)
	{
	}

	public void RequestEmptyPos([In] ref PosPoke posPoke)
	{
	}

	private void addRequest(BtlPokePos pos)
	{
	}

	public bool IsExist()
	{
		return default(bool);
	}

	public bool IsExist(BTL_CLIENT_ID clientID)
	{
		return default(bool);
	}

	public byte GetCount()
	{
		return default(byte);
	}

	public byte GetCount(BTL_CLIENT_ID clientID)
	{
		return default(byte);
	}

	public BtlPokePos GetRequestPos(byte index)
	{
		return default(BtlPokePos);
	}
}
