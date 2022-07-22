using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using NexPlugin;
using UnityEngine;
using nn;
using nn.account;

namespace NexAssets;

public class Common : MonoBehaviour
{
	public enum CALL_DISPATCH
	{
		UPDATE = 1,
		LATEUPDATE
	}

	public struct NEX_INIT_PARAM
	{
		public NP_NGSINFO ngsInfo;

		public uint pluginMemSize;

		public NexPlugin.Common.ThreadMode threadMode;

		public CALL_DISPATCH callDispatch;

		public uint dispatchTimeOut;

		public NexPlugin.Common.DispachFlag dispatchFlag;

		public bool autoLogin;

		public bool autoLogout;

		public int coreNo;
	}

	protected delegate ASYNCSTATE ExecAsyncFunc(AsyncResult asyncResult, CORE_ARG arg);

	public delegate void LostConnectCallback();

	public delegate void NGSDisconnectCallback(ulong principalId);

	public struct NgsFacadeInfo
	{
		public ulong principalId;

		public IntPtr pNgsFacade;

		public bool isLogin;
	}

	public struct NP_NGSINFO
	{
		public uint gameServerId;

		public string accessKey;

		public int timeOut;
	}

	public enum ASYNCSTATE
	{
		NONE = -1,
		INVALID,
		INVALID_ARGUMENT,
		PLUGINCALL_SUCCESS,
		PLUGINCALL_ERROR,
		NOT_NEXINIT,
		NOT_LOGIN,
		INIT_NEX_START,
		INIT_NEX_ERROR,
		NGS_USER_CANCEL,
		NGS_USERHANDLE_ERROR,
		NGS_ENSUREAVAILABLE_ERROR,
		NGS_GETID_ERROR,
		NGS_ENSURIDTOKENCACHE_ERROR,
		NGS_LOADIDTOKENCACHE_ERROR,
		NGS_LOGIN_START,
		NGS_LOGIN_ERROR
	}

	protected class CORE_ARG
	{
		public AsyncResultNum asyncNum;

		public uint asyncId;

		public IntPtr pNgsFacade;

		public ExecAsyncFunc func;

		public T Clone<T>()
		{
			return (T)null;
		}
	}

	private class NEX_INIT_ARG : CORE_ARG
	{
		public AsyncResultCB callback;
	}

	private class GETUID_ARG : CORE_ARG
	{
		public int timeOut;

		public Utility.AcquireNexUniqueIdCB callback;
	}

	private class GETUIDWITHPASSWD_ARG : CORE_ARG
	{
		public int timeOut;

		public Utility.AcquireNexUniqueIdWithPasswordCB callback;
	}

	private class ASCUIDWITHPID_ARG : CORE_ARG
	{
		public UniqueIdInfo info;

		public int timeOut;

		public AsyncResultCB callback;
	}

	private class ASCUIDWITHPIDLIST_ARG : CORE_ARG
	{
		public List<UniqueIdInfo> info;

		public int timeOut;

		public AsyncResultCB callback;
	}

	private class GETASCUIDWITHPID_ARG : CORE_ARG
	{
		public int timeOut;

		public Utility.GetAssociatedNexUniqueIdWithMyPrincipalIdCB callback;
	}

	private class GETASCUIDWITHPIDLIST_ARG : CORE_ARG
	{
		public int timeOut;

		public Utility.GetAssociatedNexUniqueIdWithMyPrincipalIdListCB callback;
	}

	private class GETINTEGERSETTINGS_ARG : CORE_ARG
	{
		public uint index;

		public int timeOut;

		public Utility.GetIntegerSettingsCB callback;
	}

	protected struct ApiCallsFrequency
	{
		public int type;

		public float time;
	}

	protected struct FunctionInfo
	{
		public int type;

		public int limit;

		public int time;

		public string name;
	}

	private enum Functions
	{
		TestConnectivity,
		AcquireNexUniqueId,
		AcquireNexUniqueIdWithPassword,
		AssociateNexUniqueIdWithMyPrincipalId,
		AssociateNexUniqueIdWithMyPrincipalId2,
		GetAssociatedNexUniqueIdWithMyPrincipalId,
		GetAssociatedNexUniqueIdWithMyPrincipalId2,
		GetIntegerSettings
	}

	public const int NC_VERSION = 500;

	protected static string s_OperationPlatform;

	private static bool s_NexUpdateF;

	public static NEX_INIT_PARAM s_NexInitParam;

	protected static NexInitializer s_NexInitializer;

	protected static AsyncResult s_AutoLoginResult;

	protected static ASYNCSTATE s_AutoLoginState;

	protected static bool s_AutoLogout;

	protected static int s_AutoLogoutCount;

	protected static List<CORE_ARG> s_CoreArgList;

	private static LostConnectCallback m_LostConnectCB;

	private static NGSDisconnectCallback m_NGSDisconnectCB;

	protected static List<NgsFacadeInfo> s_NgsFacadeInfoList;

	protected static NgsFacadeInfo s_LastLoginNgsFacadeInfo;

	protected static IntPtr s_DefaultUser;

	private static UserHandle s_AutoLoginUser;

	public static bool s_updateAlive;

	public static string s_operatingSystem;

	private static Dictionary<int, FunctionInfo> FunctionInfos;

	private static List<ApiCallsFrequency> s_ApiCallsFrequencyList;

	private NEX_INIT_PARAM GetNexInitParam()
	{
		return default(NEX_INIT_PARAM);
	}

	public static NP_NGSINFO GetNgsInfo()
	{
		return default(NP_NGSINFO);
	}

	public static NgsFacadeInfo GetLastLoginNgsFacadeInfo()
	{
		return default(NgsFacadeInfo);
	}

	public static void SetDefaultUser(IntPtr pNgsFacade)
	{
	}

	public static IntPtr GetDefaultUser()
	{
		return default(IntPtr);
	}

	public static void SetAutoLoginUserHandle(UserHandle userHandle)
	{
	}

	public static UserHandle GetAutoLoginUserHandle()
	{
		return default(UserHandle);
	}

	public static bool GetAutoLoginResult(out ASYNCSTATE state, out AsyncResult result)
	{
		return default(bool);
	}

	public bool IsAsyncStateError(ASYNCSTATE state)
	{
		return default(bool);
	}

	protected void Awake()
	{
	}

	protected void Update()
	{
	}

	protected void LateUpdate()
	{
	}

	public static bool InitializeNex()
	{
		return default(bool);
	}

	public static bool InitializeNex(uint pluginMemSize, NexPlugin.Common.ThreadMode threadMode, int coreNo = 1)
	{
		return default(bool);
	}

	public static bool InitializeNexAsync([Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool InitializeNexAsync(uint pluginMemSize, NexPlugin.Common.ThreadMode threadMode, int coreNo = 1, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	private static bool InitializeNexAsync(uint pluginMemSize, NexPlugin.Common.ThreadMode threadMode, int coreNo, NEX_INIT_ARG arg)
	{
		return default(bool);
	}

	public static bool FinalizeNexAsync([Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool FinalizeNex()
	{
		return default(bool);
	}

	public ASYNCSTATE LoginAsync([Optional] NgsFacade.LoginCB callback)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE LoginAsync(NP_NGSINFO ngsInfo, [Optional] NgsFacade.LoginCB callback)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE LoginAsync(UserHandle userHandle, [Optional] NgsFacade.LoginCB callback)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE LoginAsync(UserHandle userHandle, NP_NGSINFO ngsInfo, [Optional] NgsFacade.LoginCB callback)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE LoginAsync(NetworkServiceAccountId nsaId, byte[] nsaIdToken, [Optional] NgsFacade.LoginCB callback)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE LoginAsync(NP_NGSINFO ngsInfo, NetworkServiceAccountId nsaId, byte[] nsaIdToken, [Optional] NgsFacade.LoginCB callback)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE LoginAsync(ref uint asyncId, NP_NGSINFO ngsInfo, [Optional] NgsFacade.LoginCB callback)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE LoginAsync(ref uint asyncId, UserHandle userHandle, NP_NGSINFO ngsInfo, [Optional] NgsFacade.LoginCB callback)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE LoginAsync(ref uint asyncId, NP_NGSINFO ngsInfo, NetworkServiceAccountId nsaId, byte[] nsaIdToken, [Optional] NgsFacade.LoginCB callback)
	{
		return default(ASYNCSTATE);
	}

	public static ASYNCSTATE LogoutAsync([Optional] AsyncResultCB callback, [Optional] IntPtr pNgsFacade)
	{
		return default(ASYNCSTATE);
	}

	public static void Wait()
	{
	}

	public ASYNCSTATE AcquireNexUniqueIdAsync([Optional] Utility.AcquireNexUniqueIdCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE AcquireNexUniqueIdAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE AcquireNexUniqueIdWithPasswordAsync([Optional] Utility.AcquireNexUniqueIdWithPasswordCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE AcquireNexUniqueIdWithPasswordAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE AssociateNexUniqueIdWithMyPrincipalIdAsync(UniqueIdInfo info, [Optional] AsyncResultCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE AssociateNexUniqueIdWithMyPrincipalIdAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE AssociateNexUniqueIdsWithMyPrincipalIdAsync(List<UniqueIdInfo> info, [Optional] AsyncResultCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE AssociateNexUniqueIdsWithMyPrincipalIdAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetAssociatedNexUniqueIdWithMyPrincipalIdAsync([Optional] Utility.GetAssociatedNexUniqueIdWithMyPrincipalIdCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE GetAssociatedNexUniqueIdWithMyPrincipalIdAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetAssociatedNexUniqueIdsWithMyPrincipalIdAsync([Optional] Utility.GetAssociatedNexUniqueIdWithMyPrincipalIdListCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE GetAssociatedNexUniqueIdsWithMyPrincipalIdAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetIntegerSettingsAsync(uint index, [Optional] Utility.GetIntegerSettingsCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE GetIntegerSettingsAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public static bool IsValidNexUniqueId(ulong nexUniqueId)
	{
		return default(bool);
	}

	public ASYNCSTATE TestConnectivityAsync([Optional] NgsFacade.TestConnectivityCB callback, [Optional] IntPtr pNgsFacade)
	{
		return default(ASYNCSTATE);
	}

	public static ulong GetPrincipalId([Optional] IntPtr pNgsFacade)
	{
		return default(ulong);
	}

	public static void SetConnectionLostCallback(LostConnectCallback callback)
	{
	}

	public static void SetNGSDisconnectCallback(NGSDisconnectCallback callback)
	{
	}

	protected ASYNCSTATE ExecAfterLogin(CORE_ARG coreArg)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE InitializeNexsInf(ref uint async_id)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE GetLoginUserParam(UserHandle userHandle, out NetworkServiceAccountId nsaId, out byte[] tokenCache, bool autoLogin = false)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE NGSLoginInf(ref uint async_id)
	{
		return default(ASYNCSTATE);
	}

	private void SetAutoLoginResultError(Result res)
	{
	}

	protected static ASYNCSTATE GetAsyncState(bool ret)
	{
		return default(ASYNCSTATE);
	}

	private void CoreInitCB(AsyncResult asyncResult)
	{
	}

	private void CoreLoginCB(AsyncResult asyncResult, ulong pid, IntPtr pNgsFacade)
	{
	}

	private void CoreLostConnectCB(AsyncResult asyncResult)
	{
	}

	private void CoreLogoutCB(AsyncResult asyncResult)
	{
	}

	protected static int GetCallCount(FunctionInfo info, List<ApiCallsFrequency> list)
	{
		return default(int);
	}

	protected bool ApiCallsFrequencyCheck(FunctionInfo api, List<ApiCallsFrequency> list)
	{
		return default(bool);
	}

	private bool ApiCallsFrequencyCheck(int type)
	{
		return default(bool);
	}

	protected static void NC_LOG(string str)
	{
	}

	protected static void NC_LOG(string format, object[] arg)
	{
	}
}
