using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace INL1;

public class IlcaNetSidePort
{
	public delegate void IlcaNetSidePortServiceCallback(byte[] bin);

	public enum CallbackFuncSetEnum
	{
		Success = 0,
		ArgumentError = -1,
		AlreadySetError = -2
	}

	public const uint DEFAULT_MAGICNUMBER = 572662306u;

	public const int DEFAULT_MYPORT = 7099;

	public const int DEFAULT_SERVERPORT = 7100;

	private static Socket ssoc;

	private static IPEndPoint thisIP;

	private static int myport;

	private static int serverPort;

	private static Stopwatch sp;

	private static Stopwatch sp2;

	private static Stopwatch sp3;

	private static bool InitializeNow;

	private static uint magicNunber;

	private static string Server;

	private static bool Enable;

	private static bool Suspend;

	private static byte[] sendbuff;

	private static byte[] recvbuff;

	private static EndPoint from;

	private static EndPoint serverIP;

	private static int cnt0;

	private const int retryFrameCounter = 600;

	private const int MAX_CALLBACK_NUM = 255;

	private static IlcaNetSidePortServiceCallback[] inspsc;

	static IlcaNetSidePort()
	{
	}

	public static void Start()
	{
	}

	public static void Start(uint magic)
	{
	}

	public static void Start(uint magic, int my_port)
	{
	}

	public static void Start(uint magic, int my_port, string servern, int serverp)
	{
	}

	public static void MagicNumberSetAndRestart(uint magic)
	{
	}

	public static void Stop()
	{
	}

	public static void SuspendON()
	{
	}

	public static void SuspendOFF()
	{
	}

	public static bool IsGo()
	{
		return default(bool);
	}

	private static void Init()
	{
	}

	private static void SocketInitWorkerTh()
	{
	}

	public static void InitRe()
	{
	}

	private static void Exit()
	{
	}

	private static void Final()
	{
	}

	public static void MagicNumberRefGet(ref uint magic)
	{
	}

	private static void SocketInit()
	{
	}

	private static void LocalIPAndServerAddresGet()
	{
	}

	private static void LocalIPAddresGet()
	{
	}

	private static void BindIP(ref IPEndPoint thisIP)
	{
	}

	public static void SendString(string msg, bool Broadcast = false)
	{
	}

	private static void SendServerIPRequest()
	{
	}

	private static IPEndPoint BroadcastAddressGet()
	{
		return null;
	}

	private static void SendServer(byte id1, byte id2, byte[] stream, [Optional] IPEndPoint target)
	{
	}

	private static void SocketClose()
	{
	}

	public static void Update()
	{
	}

	public static CallbackFuncSetEnum CallbackFuncSet(int id, IlcaNetSidePortServiceCallback callback)
	{
		return default(CallbackFuncSetEnum);
	}

	private static bool CallbackFuncCall(byte id, byte[] stream)
	{
		return default(bool);
	}
}
