using Dpr.Battle.Logic.Net;

namespace Dpr.Battle.Logic;

public sealed class AdapterFactory
{
	private Adapter[] m_adapter;

	private Client m_iPtrNetClient;

	public AdapterFactory(Client iPtrNetClient)
	{
	}

	public void Dispose()
	{
	}

	public Adapter Create(BtlCommMode commMode, byte clientID)
	{
		return null;
	}
}
