using System;
using System.Runtime.InteropServices;
using NexPlugin;
using UnityEngine;
using nn;
using nn.account;

namespace INL1;

public class IlcaNetBase
{
	public delegate ushort IlcaNetUserRandomNumFunc();

	public class PinnedKey
	{
		private GCHandle m_Handle;

		private uint m_KeyDataSize;

		private byte[] m_KeyData;

		public PinnedKey(byte[] keyData)
		{
		}

		~PinnedKey()
		{
		}

		public IntPtr GetKeyDataPtr()
		{
			return default(IntPtr);
		}

		public uint GetKeyDataSize()
		{
			return default(uint);
		}
	}

	private enum ErrorMode
	{
		PiaPluginResult,
		nnResult
	}

	protected enum GeneraNexInitializeResult
	{
		AsyncStart = 0,
		AlreadyInit = 1,
		Error = 10,
		ErrorInit = 10,
		ErrorAsync = 11
	}

	protected static MonoBehaviour inl_callobj;

	protected static bool isPlatformLibraryInitialized;

	protected static bool isPlatformLibraryFullInitialized;

	protected static bool isNetSessionInitialized;

	protected static bool isNetStationInitialized;

	protected static bool isEmergencyFinalizeRequest;

	protected static PiaPlugin.Result lastEmergencyResult;

	protected static IlcaNetSessionSetting netSetting;

	protected static IlcaNetSessionSetting netSettingBackup;

	protected static uint nowStationNumber;

	protected static UserHandle netUserHandle;

	protected static int LocalCommunicationVersionNumber;

	protected static bool isErrorViewerAsync;

	protected static bool isErrorViewerDispNow;

	protected static bool isErrorViewerDispCancel;

	protected static bool isNamerakaMode;

	public const int MaxGamers = 16;

	protected const int WorkerThreadSleepTime = 16;

	protected static bool isMainThreadDispatchActive;

	private static bool lastErrorViewerApplet;

	protected static int debugNetworkBadEmulationLevel;

	protected static byte debugNatTraversalFailureRatioForHost;

	protected static byte debugNatTraversalFailureRatioForClient;

	protected static bool debugIsNatTypeCheckFailure;

	protected static bool debugIsDnsResolutionFailure;

	protected static IlcaNetUserRandomNumFunc userRandomNumLocalFunc;

	private const byte NexVersionMajor = 4;

	private const byte NexVersionMinor = 6;

	private const byte NexVersionMicro = 5;

	private static ErrorMode modeErrorViewerWorker;

	private static PiaPlugin.Result resErrorViewerWorker;

	private static Result nnResultErrorViewerWorker;

	private static uint svcode;

	private static string svdialog;

	private static string svscreen;

	private static string svlang;

	protected static UniqueIdInfo netNexUIdInfo;

	protected static ulong netNexUniqueId;

	protected static ulong netNexUniqueIdPassword;

	protected static string netNsaIDtoken;

	protected static UserHandle netNsaIDtokenUserHandle;

	private static AsyncResultCB GeneralNexInitialize2Func;

	public static void Init(int version)
	{
	}

	protected static void CallObjSet(MonoBehaviour callobj)
	{
	}

	protected static void EmergencyCall(PiaPlugin.Result result)
	{
	}

	protected static void EmergencyInit()
	{
	}

	protected static bool EmergencyCheck()
	{
		return default(bool);
	}

	protected static void EmergencyFinal()
	{
	}

	protected static bool IsPlatformLibraryInitialized()
	{
		return default(bool);
	}

	protected static bool IsNetSessionInitialized()
	{
		return default(bool);
	}

	protected static bool IsNetStationInitialized()
	{
		return default(bool);
	}

	public static void OnDestroy()
	{
	}

	public static uint MemoryUsage()
	{
		return default(uint);
	}

	public static void NonBlockWorkerThreadUse(bool flag)
	{
	}

	public static void RandomNumLocalFuncSet([Optional] IlcaNetUserRandomNumFunc func)
	{
	}

	private static ushort RandomNumLocal()
	{
		return default(ushort);
	}

	public static void ErrorViewerAsycnSet(bool flag)
	{
	}

	public static void ErrorViewerDispCancel(bool flag)
	{
	}

	protected static PiaPlugin.Result PlatformInitialize()
	{
		return default(PiaPlugin.Result);
	}

	protected static PiaPlugin.Result PlatformInitialize2()
	{
		return default(PiaPlugin.Result);
	}

	protected static void ErrorViewer(PiaPlugin.Result result)
	{
	}

	protected static void ErrorViewer(Result nnRes)
	{
	}

	private static void ErrorViewerWorker()
	{
	}

	public static bool LastErrorViewerAppletGet()
	{
		return default(bool);
	}

	public static void LastErrorViewerAppletSet(bool flag)
	{
	}

	public static bool ErrorViewerOriginal(uint code, string dialog, string screen, string lang)
	{
		return default(bool);
	}

	private static void DisplayErrorAppletWorkerThread()
	{
	}

	protected static GeneraNexInitializeResult GeneralNexInitialize(AsyncResultCB func)
	{
		return default(GeneraNexInitializeResult);
	}

	protected static GeneraNexInitializeResult GeneralNexInitialize2(AsyncResultCB func)
	{
		return default(GeneraNexInitializeResult);
	}

	private static void GeneralNexInitialize2Callback(AsyncResult rsul)
	{
	}

	protected static bool IsNexServerConnected()
	{
		return default(bool);
	}

	protected static void GeneraNexTerminateImmediatelySet()
	{
	}

	public static void DebugLog(string msg)
	{
	}
}
