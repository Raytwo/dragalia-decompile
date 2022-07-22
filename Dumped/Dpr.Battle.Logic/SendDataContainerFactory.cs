namespace Dpr.Battle.Logic;

public static class SendDataContainerFactory
{
	private const uint CONTAINER_BUFFER_NUM = 2u;

	private static SendDataContainer s_containerForServerSend;

	private static SendDataContainer[] s_containerForClientSend;

	private static SendDataContainer[] s_containerForClientRecieve;

	public static void CreateContainer()
	{
	}

	public static void DeleteContainer()
	{
	}

	public static SendDataContainer GetServerSendContainer()
	{
		return null;
	}

	public static SendDataContainer GetClientSendContainer(BTL_CLIENT_ID clientId)
	{
		return null;
	}

	public static SendDataContainer GetClientReceiveContainer(BTL_CLIENT_ID clientId)
	{
		return null;
	}
}
