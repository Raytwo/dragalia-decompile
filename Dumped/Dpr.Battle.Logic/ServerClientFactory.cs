using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public static class ServerClientFactory
{
	public class Input
	{
		public AdapterFactory adapterFactory;

		public BtlRule rule;

		public BtlCommMode commMode;

		public BtlMultiMode multiMode;

		public BtlBagMode bagMode;

		public bool isRecordPlayMode;

		public BTL_CLIENT_ID myClientId;

		public bool amIServer;

		public ulong randomSeed;

		public MainModule mainModule;

		public BattleEnv battleEnvForServer;

		public BattleEnv battleEnvForClient;

		public SendDataContainer sendDataContainerForServerSend;

		public SendDataContainer[] sendDataContainerForClientSend;

		public SendDataContainer[] sendDataContainerForClientReceive;
	}

	public class Output
	{
		public BTL_SERVER server;

		public BTL_CLIENT[] localClients;

		public BTL_CLIENT[] dummyClients;
	}

	public static void CreateServerClient([In] ref Input input, Output output)
	{
	}

	private static void InitOutput(Output output)
	{
	}

	private static void CreateLocalClients([In] ref Input input, Output output)
	{
	}

	private static BTL_CLIENT CreateLocalClient([In] ref Input input, BTL_SERVER server, BTL_CLIENT_ID clientId)
	{
		return null;
	}

	public static BTL_CLIENT CreateClientObject([In] ref Input input, BTL_SERVER server, BTL_CLIENT_ID clientId, byte clientType)
	{
		return null;
	}

	public static Adapter CreateClientAdapter([In] ref Input input, BTL_CLIENT_ID clientId, byte clientType)
	{
		return null;
	}

	private static void CreateDummyClients([In] ref Input input, Output output)
	{
	}

	private static BTL_CLIENT CreateDummyClient([In] ref Input input, BTL_SERVER server, BTL_CLIENT_ID clientId, BTL_CLIENT localClient)
	{
		return null;
	}

	private static void CreateRemoteClients([In] ref Input input, Output output)
	{
	}

	private static void SetupCommandCheckServer([In] ref Input input, Output output)
	{
	}
}
