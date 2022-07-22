using System.Collections;
using System.Threading;
using NexPlugin;
using UnityEngine;
using nn.account;

namespace INL1;

public class IlcaNetServer : IlcaNetBase
{
	protected enum NexState
	{
		Idle,
		StartDeleteData,
		RunningDeleteData,
		EndDeleteData,
		StartDownloadData,
		RunningDownloadData,
		EndDownloadData,
		StartSearchData,
		RunningSearchData,
		EndSearchData,
		StartUploadData,
		RunningUploadData,
		EndUploadData,
		StartUpdateData,
		RunningUpdateData,
		EndUpdateData,
		StartGetMetaData,
		RunningGetMetaData,
		EndGetMetaData,
		StartChangeMetaData,
		RunningChangeMetaData,
		EndChangeMetaData,
		StartGetRatingData,
		RunningGetRatingData,
		EndGetRatingData,
		StartSetRatingData,
		RunningSetRatingData,
		EndSetRatingData,
		StartCrashDataStore,
		RunningCrashDataStore,
		EndCrashDataStore,
		StartRetrieveRank,
		RunningRetrieveRank,
		EndRetrieveRank,
		StartUploadRank,
		RunningUploadRank,
		EndUploadRank,
		StartUploadCommon,
		RunningUploadCommon,
		EndUploadCommon,
		StartRetrieveContent,
		RunningRetrieveContent,
		EndRetrieveContent,
		StartUpload,
		RunningUpload,
		EndUpload,
		StartEstimateRank,
		RunningEstimateRank,
		EndEstimateRank,
		StartCrashRank,
		RunningCrashRank,
		EndCrashRank
	}

	public enum IlcaNetServerFinalAsyncNeedEnum
	{
		None,
		NeedInit,
		NeedLogout
	}

	public delegate void IlcaNetServerFinalAsyncCallback();

	public delegate void UserNexUniqueIdAcquireCallback(bool isSuccess, ulong nexUniqueId, ulong nexUniqueIdPassword);

	public delegate void IlcaNetServerAsyncCallback(bool isSuccess, IlcaNetServerCallbackEventType eve, IlcaNetServerCallbackResult result, long responseCode, string responseStr);

	protected static NexState serverState;

	private static AsyncResult serverAsyncResult;

	private static IlcaNetServerFinalAsyncCallback finalCallback;

	private static Thread FinalAsyncCoRoutineCoreUpdateDispatchWTh;

	private static bool isFinalAsyncCoRoutineCoreCallbackCompleted;

	private static Thread finalAsyncFWTh;

	private static bool isFinalAsyncFinishWorkerCompleted;

	private static UserNexUniqueIdAcquireCallback unuiaCallback;

	private static AsyncContext pOutContext;

	public static bool Init(MonoBehaviour callobj, UserHandle uh, ulong nexUniqueId, ulong nexUniqueIdPassword)
	{
		return default(bool);
	}

	protected static void Init(MonoBehaviour callobj, UserHandle uh, UserNexUniqueIdAcquireCallback func)
	{
	}

	private static void InitSub(MonoBehaviour callobj, UserHandle uh)
	{
	}

	protected static void NexAssetsAutoLoginLogoutControl()
	{
	}

	public static void NexAssetsAutoLoginControl(bool on)
	{
	}

	public static void NexAssetsAutoLogoutControl(bool on)
	{
	}

	public static void MainThreadDispatchControl(bool on)
	{
	}

	public static bool MainThreadDispatchControlState()
	{
		return default(bool);
	}

	protected static void StartX()
	{
	}

	private static void LostCallback()
	{
	}

	private static void LostCallbackNGS(ulong principalId)
	{
	}

	public static bool IsRunning()
	{
		return default(bool);
	}

	protected static void baseCallback(AsyncResult asyncResult)
	{
	}

	public static IlcaNetServerFinalAsyncNeedEnum IsFinalAsyncNeed()
	{
		return default(IlcaNetServerFinalAsyncNeedEnum);
	}

	public static bool FinalAsyncCoRoutine(MonoBehaviour callobj, IlcaNetServerFinalAsyncCallback callback)
	{
		return default(bool);
	}

	private static bool FinalAsyncCoRoutineCoreUpdateDispatchWorkerSet()
	{
		return default(bool);
	}

	private static void FinalAsyncCoRoutineCoreUpdateDispatchWorkerTh()
	{
	}

	private static void FinalAsyncCoRoutineCoreCallback(AsyncResult asyncResult)
	{
	}

	private static bool FinalAsyncFinishWorkerSet()
	{
		return default(bool);
	}

	private static void FinalAsyncFinishWorkerTh()
	{
	}

	private static IEnumerator FinalAsyncCoRoutineCore(IlcaNetServerFinalAsyncCallback callback)
	{
		return null;
	}

	public static void Final()
	{
	}

	public static void NexErrorHandling(AsyncResult asyncResult)
	{
	}

	private static bool IlcaNetNexUniqueIdAcquireAsync(UserNexUniqueIdAcquireCallback func)
	{
		return default(bool);
	}

	private static void IlcaNetNexUniqueIdAcquireAsyncCallback_noPassword(AsyncResult asyncResult, ulong nexUniqueId)
	{
	}

	private static void IlcaNetNexUniqueIdAcquireAsyncCallback(AsyncResult asyncResult, UniqueIdInfo uniqueIdInfo)
	{
	}

	private static void IlcaNetNexUniqueIdAcquireAsyncAfterCallback(AsyncResult asyncResult)
	{
	}

	private static void IlcaNetNexUniqueIdAcquireAsyncAfterAfterSuccessCallback()
	{
	}

	private static void IlcaNetNexUniqueIdAcquireAsyncAfterAfterFailureCallback()
	{
	}

	protected static bool NSAIDtokenGetAsync(MonoBehaviour callobj, UserHandle uh, IlcaNetServerAsyncCallback callback)
	{
		return default(bool);
	}

	public static bool NSAIDtokenGetAsync(MonoBehaviour callobj, IlcaNetServerAsyncCallback callback)
	{
		return default(bool);
	}

	private static IEnumerator NSAIDtokenGetAsyncCore(UserHandle uh, IlcaNetServerAsyncCallback callback)
	{
		return null;
	}
}
