using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using nn;
using nn.account;

namespace NexPlugin;

internal static class Detail
{
	public struct AsyncResultInt
	{
		private long pad;

		public uint asyncId;

		public AsyncResultNum asyncNum;

		public Result nnResult;

		public uint netErrCode;

		public int returnCode;

		public uint errorCode;

		public IntPtr pParam1;

		public IntPtr pParam2;

		public static AsyncResult GetAsyncResult(AsyncResultInt res)
		{
			return null;
		}

		public long GetLong(IntPtr pParam)
		{
			return default(long);
		}

		public ulong GetUlong(IntPtr pParam)
		{
			return default(ulong);
		}

		public int GetInt(IntPtr pParam)
		{
			return default(int);
		}

		public uint GetUint(IntPtr pParam)
		{
			return default(uint);
		}

		public void Trace()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}

	public struct NotificationEventInt : IExchangeList<NotificationEvent>
	{
		public ulong param1;

		public ulong param2;

		public uint type;

		public uint subType;

		public CppArray stringParam;

		public ulong pid;

		public static NotificationEvent ExchangePtrToStruct(IntPtr src)
		{
			return null;
		}

		public NotificationEvent ExchangeStruct()
		{
			return null;
		}
	}

	public static class Common
	{
		private static List<AsyncResultInt> asyncResultList;

		private static List<NotificationEvent> notificationEventList;

		private static extern bool InitializeNexAsyncInt(uint asyncId, int threadMode);

		public static bool InitializeNexAsync(out uint asyncId, NexPlugin.Common.ThreadMode threadMode, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool FinalizeNexAsyncInt(uint asyncId);

		public static bool FinalizeNexAsync(out uint asyncId, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		public static extern void SetTerminateImmediately(uint terminate);

		private static extern uint DispatchInt(uint dispatchTimeout, uint dispatchFlags);

		public static uint Dispatch(uint dispatchTimeout, [Optional] NexPlugin.Common.DispachFlag? dispatchFlags)
		{
			return default(uint);
		}

		public static extern void DispatchAll();

		public static extern uint GetReadyJobsSize();

		private static extern bool UpdateAsyncResultInt(ref IntPtr pAsyncResult);

		public static bool UpdateAsyncResult()
		{
			return default(bool);
		}

		public static extern void InitAsyncResultByAsyncId(uint asyncId);

		public static void Wait(uint dispatchTimeOut, NexPlugin.Common.DispachFlag? dispatchFlags)
		{
		}

		private static extern bool GetNotificationEventInt(ref IntPtr pNotificationEvent);

		public static bool GetNotificationEvent()
		{
			return default(bool);
		}

		public static void Callback(AsyncResultInt res, object callback)
		{
		}
	}

	public interface IExchangeList<T>
	{
		T ExchangeStruct();
	}

	public struct CppArray
	{
		public int count;

		public IntPtr ptr;

		public CppArray(IntPtr src)
		{
		}

		public void ToArray<T>(ref T[] list, int size)
		{
		}

		public void ToList<T>(ref List<T> list)
		{
		}

		public List<T> ToList<T, U>() where U : IExchangeList<T>
		{
			return null;
		}

		public string ToStr()
		{
			return null;
		}

		public static CppArray StringToArray(List<IntPtr> useptr, string param)
		{
			return default(CppArray);
		}

		public static CppArray StringsToArray(List<IntPtr> useptr, List<string> param)
		{
			return default(CppArray);
		}

		public static CppArray ArrayToArray<T>(List<IntPtr> useptr, T[] param)
		{
			return default(CppArray);
		}

		public static CppArray ListToArray<T>(List<IntPtr> useptr, List<T> param)
		{
			return default(CppArray);
		}

		public static CppArray ListToArray<T, U>(List<IntPtr> useptr, List<T> param)
		{
			return default(CppArray);
		}
	}

	public static class DataStore
	{
		private struct DataStorePersistenceInfoInt : IExchangeList<DataStorePersistenceInfo>
		{
			private ulong dataId;

			private ulong principalId;

			private ushort persistenceSlotId;

			public DataStorePersistenceInfo ExchangeStruct()
			{
				return null;
			}

			public static DataStorePersistenceInfo ExchangePtrToStruct(IntPtr src)
			{
				return null;
			}

			public DataStorePersistenceInfoInt(DataStorePersistenceInfo param)
			{
			}
		}

		private struct DataStorePasswordInfoInt : IExchangeList<DataStorePasswordInfo>
		{
			private ulong dataId;

			private ulong accessPassword;

			private ulong updatePassword;

			public DataStorePasswordInfo ExchangeStruct()
			{
				return null;
			}

			public static DataStorePasswordInfo ExchangePtrToStruct(IntPtr src)
			{
				return null;
			}

			public DataStorePasswordInfoInt(DataStorePasswordInfo param)
			{
			}
		}

		private struct DataStorePermissionInt : IExchangeList<DataStorePermission>
		{
			private CppArray recipientIds;

			private uint permission;

			public DataStorePermission ExchangeStruct()
			{
				return null;
			}

			public DataStorePermissionInt(List<IntPtr> useptr, DataStorePermission param)
			{
			}
		}

		private struct DataStoreMetaInfoInt : IExchangeList<DataStoreMetaInfo>
		{
			private ulong dataId;

			private ulong ownerId;

			private uint size;

			private ushort dataType;

			private ushort period;

			private uint status;

			private uint referDataId;

			private uint flag;

			private DataStorePermissionInt accessPermission;

			private DataStorePermissionInt updatePermission;

			private CppArray name;

			private CppArray meta;

			private CppArray tags;

			private CppArray ratingInfo;

			private NpDateTime createdTime;

			private NpDateTime updatedTime;

			private NpDateTime expireTime;

			public static DataStoreMetaInfo ExchangePtrToStruct(IntPtr src)
			{
				return null;
			}

			public DataStoreMetaInfo ExchangeStruct()
			{
				return null;
			}
		}

		private struct DataStoreSearchResultInt
		{
			private CppArray result;

			private uint totalCount;

			private uint totalCountType;

			public static DataStoreSearchResult ExchangePtrToStruct(IntPtr src)
			{
				return null;
			}
		}

		private struct DataStoreRatingLogInt
		{
			private NpDateTime lockExpirationTime;

			private ulong pid;

			private int ratingValue;

			private bool isRated;

			public static DataStoreRatingLog ExchangePtrToStruct(IntPtr src)
			{
				return null;
			}
		}

		private struct DataStorePersistenceInitParamInt
		{
			private ushort persistenceSlotId;

			private byte deleteLastObject;

			public DataStorePersistenceInitParamInt(DataStorePersistenceInitParam param)
			{
			}
		}

		private struct DataStoreRatingInitParamInt
		{
			private long initialValue;

			private int rangeMin;

			private int rangeMax;

			private int flag;

			private int internalFlag;

			private int lockType;

			private short periodDuration;

			private sbyte periodHour;

			private sbyte slot;

			public DataStoreRatingInitParamInt(DataStoreRatingInitParam param)
			{
			}
		}

		private struct DataStorePreparePostParamInt
		{
			private DataStorePermissionInt accessPermission;

			private DataStorePermissionInt updatePermission;

			private DataStorePersistenceInitParamInt persistenceInitParam;

			private CppArray name;

			private CppArray tags;

			private CppArray ratingInitParams;

			private CppArray meta;

			private uint size;

			private uint dataFlag;

			private ushort dataType;

			private ushort period;

			public DataStorePreparePostParamInt(List<IntPtr> useptr, DataStorePreparePostParam param, uint size)
			{
			}

			public DataStorePreparePostParamInt(List<IntPtr> useptr, DataStorePreparePostParam param)
			{
			}
		}

		private struct ResultRangeInt
		{
			private uint offset;

			private uint size;

			public ResultRangeInt(ResultRange param)
			{
			}
		}

		private struct DataStoreSearchParamInt
		{
			private uint searchType;

			private uint ownerType;

			private CppArray ownerIds;

			private CppArray destinationIds;

			private NpDateTime createdAfter;

			private NpDateTime createdBefore;

			private NpDateTime updatedAfter;

			private NpDateTime updatedBefore;

			private uint sortOrderColumn;

			private uint sortOrder;

			private ResultRangeInt resultRange;

			private CppArray tags;

			private uint resultOption;

			private uint minimalRatingFrequency;

			private int totalCountEnabled;

			private int useCache;

			private CppArray dataTypes;

			public DataStoreSearchParamInt(List<IntPtr> useptr, DataStoreSearchParam param)
			{
			}
		}

		private struct DataStoreDeleteParamInt
		{
			private ulong dataId;

			private ulong updatePassword;

			public DataStoreDeleteParamInt(DataStoreDeleteParam param)
			{
			}
		}

		private struct DataStorePrepareUpdateParamInt
		{
			private ulong dataId;

			private ulong updatePassword;

			private uint size;

			public DataStorePrepareUpdateParamInt(DataStorePrepareUpdateParam param)
			{
			}
		}

		private struct DataStorePersistenceTargetInt
		{
			private ulong ownerId;

			private ushort persistenceSlotId;

			public DataStorePersistenceTargetInt(DataStorePersistenceTarget param)
			{
			}
		}

		private struct DataStorePrepareGetParamInt
		{
			private ulong dataId;

			private ulong accessPassword;

			private DataStorePersistenceTargetInt persistenceTarget;

			private int useDataId;

			public DataStorePrepareGetParamInt(DataStorePrepareGetParam param)
			{
			}
		}

		private struct DataStoreTouchObjectParamInt
		{
			private ulong dataId;

			private ulong accessPassword;

			public DataStoreTouchObjectParamInt(DataStoreTouchObjectParam param)
			{
			}
		}

		private struct DataStoreGetMetaParamInt
		{
			private ulong dataId;

			private ulong accessPassword;

			private DataStorePersistenceTargetInt persistenceTarget;

			private uint resultOption;

			private int useDataId;

			public DataStoreGetMetaParamInt(DataStoreGetMetaParam param)
			{
			}
		}

		private struct DataStoreChangeMetaCompareParamInt
		{
			private DataStorePermissionInt accessPermission;

			private DataStorePermissionInt updatePermission;

			private CppArray name;

			private CppArray tags;

			private CppArray metaBinary;

			private uint comparisonFlag;

			private uint status;

			private ushort dataType;

			private ushort period;

			public DataStoreChangeMetaCompareParamInt(List<IntPtr> useptr, DataStoreChangeMetaCompareParam param)
			{
			}
		}

		private struct DataStoreChangeMetaParamInt
		{
			private DataStorePermissionInt accessPermission;

			private DataStorePermissionInt updatePermission;

			private CppArray name;

			private CppArray tags;

			private CppArray metaBinary;

			private DataStoreChangeMetaCompareParamInt compareParam;

			private ulong dataId;

			private ulong updatePassword;

			private uint modifiesFlag;

			private uint dataStatus;

			private DataStorePersistenceTargetInt persistenceTarget;

			private ushort dataType;

			private ushort period;

			public DataStoreChangeMetaParamInt(List<IntPtr> useptr, DataStoreChangeMetaParam param)
			{
			}
		}

		private struct DataStoreRatingTargetInt
		{
			private ulong dataId;

			private sbyte slot;

			public DataStoreRatingTargetInt(DataStoreRatingTarget param)
			{
			}
		}

		private struct DataStoreRateObjectParamInt
		{
			private ulong accessPassword;

			private int ratingValue;

			public DataStoreRateObjectParamInt(DataStoreRateObjectParam param)
			{
			}
		}

		private static List<Dictionary<sbyte, DataStoreRatingInfo>> DataStore_ExchangeRatingInfosList(IntPtr src)
		{
			return null;
		}

		private static extern bool DataStore_PostObjectAsync(uint asyncId, IntPtr pNgsFacade, ref DataStorePreparePostParamInt pParam, IntPtr pUpBuf, int timeOut);

		public static bool PostObjectAsync<T>(out uint asyncId, IntPtr pNgsFacade, DataStorePreparePostParam param, T[] array, int timeOut = 0, [Optional] NexPlugin.DataStore.PostCB callback) where T : struct
		{
			return default(bool);
		}

		private static extern bool DataStore_PostMetaAsync(uint asyncId, IntPtr pNgsFacade, ref DataStorePreparePostParamInt pParam, int timeOut);

		public static bool PostMetaAsync(out uint asyncId, IntPtr pNgsFacade, DataStorePreparePostParam param, int timeOut = 0, [Optional] NexPlugin.DataStore.PostCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_PostMetaAsyncByDataID(uint asyncId, IntPtr pNgsFacade, ulong dataId, ref DataStorePreparePostParamInt pParam, int timeOut);

		public static bool PostMetaAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, DataStorePreparePostParam param, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_PostMetaAsyncByDataList(uint asyncId, IntPtr pNgsFacade, int useOneParam, ref CppArray dataIds, ref CppArray param, int transactional, int timeOut);

		public static bool PostMetaAsync(out uint asyncId, IntPtr pNgsFacade, bool useOneParam, List<ulong> dataIds, List<DataStorePreparePostParam> param, bool transactional = true, int timeOut = 0, [Optional] NexPlugin.DataStore.ResultListCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_CompleteSuspendedPostObjectAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray pParam, int timeOut);

		public static bool CompleteSuspendedPostObjectAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_SearchObjectAsync(uint asyncId, IntPtr pNgsFacade, ref DataStoreSearchParamInt pParam, int timeOut);

		public static bool SearchObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreSearchParam param, int timeOut = 0, [Optional] NexPlugin.DataStore.SearchObjectCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_SearchObjectLightAsync(uint asyncId, IntPtr pNgsFacade, ref DataStoreSearchParamInt pParam, int timeOut);

		public static bool SearchObjectLightAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreSearchParam param, int timeOut = 0, [Optional] NexPlugin.DataStore.SearchObjectCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_DeleteObjectAsync(uint asyncId, IntPtr pNgsFacade, ref DataStoreDeleteParamInt pParam, int timeOut);

		public static bool DeleteObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreDeleteParam param, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_DeleteObjectAsyncByDataList(uint asyncId, IntPtr pNgsFacade, ref CppArray param, int transactional, int timeOut);

		public static bool DeleteObjectAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreDeleteParam> param, bool transactional = true, int timeOut = 0, [Optional] NexPlugin.DataStore.ResultListCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_UpdateObjectAsync(uint asyncId, IntPtr pNgsFacade, ref DataStorePrepareUpdateParamInt pParam, IntPtr pUpBuf, int timeOut);

		public static bool UpdateObjectAsync<T>(out uint asyncId, IntPtr pNgsFacade, DataStorePrepareUpdateParam param, T[] array, int timeOut = 0, [Optional] AsyncResultCB callback) where T : struct
		{
			return default(bool);
		}

		private static extern bool DataStore_GetObjectAsync(uint asyncId, IntPtr pNgsFacade, ref DataStorePrepareGetParamInt pParam, ulong getBufSize, int timeOut);

		public static bool GetObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStorePrepareGetParam param, ulong getBufSize, int timeOut = 0, [Optional] NexPlugin.DataStore.GetObjectCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_TouchObjectAsync(uint asyncId, IntPtr pNgsFacade, ref DataStoreTouchObjectParamInt param, int timeOut);

		public static bool TouchObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreTouchObjectParam param, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_GetMetaAsync(uint asyncId, IntPtr pNgsFacade, ref DataStoreGetMetaParamInt pParam, int timeOut);

		public static bool GetMetaAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreGetMetaParam param, int timeOut = 0, [Optional] NexPlugin.DataStore.GetMetaCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_GetMetaAsyncByDataList(uint asyncId, IntPtr pNgsFacade, int useDataIds, ref CppArray dataIds, ref CppArray param, int timeOut);

		public static bool GetMetaAsync(out uint asyncId, IntPtr pNgsFacade, bool useDataIds, List<ulong> dataIds, List<DataStoreGetMetaParam> param, int timeOut = 0, [Optional] NexPlugin.DataStore.GetMetaListCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_ChangeMetaAsync(uint asyncId, IntPtr pNgsFacade, ref DataStoreChangeMetaParamInt pParam, int timeOut);

		public static bool ChangeMetaAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreChangeMetaParam param, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_ChangeMetaAsyncByDataList(uint asyncId, IntPtr pNgsFacade, int useDataIds, ref CppArray dataIds, ref CppArray param, int transactional, int timeOut);

		public static bool ChangeMetaAsync(out uint asyncId, IntPtr pNgsFacade, bool useDataIds, List<ulong> dataIds, List<DataStoreChangeMetaParam> param, bool transactional = true, int timeOut = 0, [Optional] NexPlugin.DataStore.ResultListCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_RateObjectAsync(uint asyncId, IntPtr pNgsFacade, ref DataStoreRatingTargetInt pTarget, ref DataStoreRateObjectParamInt pRateParam, int timeOut);

		public static bool RateObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, DataStoreRateObjectParam param, int timeOut = 0, [Optional] NexPlugin.DataStore.RatingInfoCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_RateObjectAsyncByDataList(uint asyncId, IntPtr pNgsFacade, int useOneObjectParam, ref CppArray target, ref CppArray param, int transactional, int timeOut);

		public static bool RateObjectAsync(out uint asyncId, IntPtr pNgsFacade, bool useOneObjectParam, List<DataStoreRatingTarget> target, List<DataStoreRateObjectParam> param, bool transactional = true, int timeOut = 0, [Optional] NexPlugin.DataStore.RatingInfoListCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_RateObjectWithPostingAsync(uint asyncId, IntPtr pNgsFacade, ref DataStoreRatingTargetInt pParam, ref DataStoreRateObjectParamInt pObject, ref DataStorePreparePostParamInt pPostParam, int timeOut);

		public static bool RateObjectWithPostingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget pParam, DataStoreRateObjectParam pObject, DataStorePreparePostParam pPostParam, int timeOut = 0, [Optional] NexPlugin.DataStore.RatingInfoCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_RateObjectsWithPostingAsync(uint asyncId, IntPtr pNgsFacade, int useOneParam, ref CppArray pParam, ref CppArray pObject, ref CppArray pPostParam, int transactional, int timeOut);

		public static bool RateObjectsWithPostingAsync(out uint asyncId, IntPtr pNgsFacade, bool useOneParam, List<DataStoreRatingTarget> pParam, List<DataStoreRateObjectParam> pObject, List<DataStorePreparePostParam> pPostParam, bool transactional, int timeOut = 0, [Optional] NexPlugin.DataStore.RatingInfoListCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_GetRatingAsync(uint asyncId, IntPtr pNgsFacade, ref DataStoreRatingTargetInt target, ulong accessPassword, int timeOut);

		public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, ulong accessPassword, int timeOut = 0, [Optional] NexPlugin.DataStore.RatingInfoCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_GetRatingAllSlotAsync(uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut);

		public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut = 0, [Optional] NexPlugin.DataStore.RatingInfoAllSlotCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_GetRatingAsyncByDataList(uint asyncId, IntPtr pNgsFacade, ref CppArray dataIds, int timeOut);

		public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, int timeOut = 0, [Optional] NexPlugin.DataStore.RatingInfosListCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_GetRatingWithLogAsync(uint asyncId, IntPtr pNgsFacade, ref DataStoreRatingTargetInt target, ulong accessPassword, int timeOut);

		public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, ulong accessPassword, int timeOut = 0, [Optional] NexPlugin.DataStore.RatingInfoWithLogCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_ResetRatingAsync(uint asyncId, IntPtr pNgsFacade, ref DataStoreRatingTargetInt target, ulong accessPassword, int timeOut);

		public static bool ResetRatingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, ulong accessPassword, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_ResetRatingAllSlotAsync(uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut);

		public static bool ResetRatingAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_ResetRatingAsyncByDataList(uint asyncId, IntPtr pNgsFacade, ref CppArray dataIds, int transactional, int timeOut);

		public static bool ResetRatingAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, bool transactional = true, int timeOut = 0, [Optional] NexPlugin.DataStore.ResultListCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_GetPersistenceInfoAsync(uint asyncId, IntPtr pNgsFacade, ulong principalId, ushort slotId, int timeOut);

		public static bool GetPersistenceInfoAsync(out uint asyncId, IntPtr pNgsFacade, ulong principalId, ushort persistenceSlotId, int timeOut = 0, [Optional] NexPlugin.DataStore.GetPersistenceInfoCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_GetPersistenceInfoAsyncByDataList(uint asyncId, IntPtr pNgsFacade, ulong principalId, ref CppArray persistenceSlotIds, int timeOut);

		public static bool GetPersistenceInfoAsync(out uint asyncId, IntPtr pNgsFacade, ulong principalId, List<ushort> persistenceSlotIds, int timeOut = 0, [Optional] NexPlugin.DataStore.GetPersistenceInfoListCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_PerpetuateObjectAsync(uint asyncId, IntPtr pNgsFacade, ushort slotId, ulong dataId, int deleteFlag, int timeOut);

		public static bool PerpetuateObjectAsync(out uint asyncId, IntPtr pNgsFacade, ushort persistenceSlotId, ulong dataId, bool deleteLastObject = true, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_UnperpetuateObjectAsync(uint asyncId, IntPtr pNgsFacade, ushort slotId, int deleteFlag, int timeOut);

		public static bool UnperpetuateObjectAsync(out uint asyncId, IntPtr pNgsFacade, ushort persistenceSlotId, bool deleteLastObject = false, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_GetPasswordInfoAsync(uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut);

		public static bool GetPasswordInfoAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut = 0, [Optional] NexPlugin.DataStore.GetPasswordInfoCB callback)
		{
			return default(bool);
		}

		private static extern bool DataStore_GetPasswordInfoAsyncByDataList(uint asyncId, IntPtr pNgsFacade, ref CppArray pParam, int timeOut);

		public static bool GetPasswordInfoAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, int timeOut = 0, [Optional] NexPlugin.DataStore.GetPasswordInfoListCB callback)
		{
			return default(bool);
		}

		private static void DataStore_PostResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void DataStore_ResultListResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void DataStore_SearchObjectResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void DataStore_GetObjectResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void DataStore_GetMetaResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void DataStore_GetMetaByDataListResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void DataStore_RatingInfoResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void DataStore_RatingInfoAllSlotResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void DataStore_RatingInfoListResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void DataStore_RatingInfosListResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void DataStore_RatingInfoWithLogResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void DataStore_GetPersistenceInfoResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void DataStore_GetPersistenceInfoListResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void DataStore_GetPasswordInfoResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void DataStore_GetPasswordInfoListResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		public static void Callback(AsyncResultInt res, object callback)
		{
		}
	}

	public static class NgsFacade
	{
		private static extern bool Ngs_LoginAsync(uint asyncId, uint gameServerId, ref CppArray accessKey, ulong nsaId, ref CppArray nsaIdToken, int timeOut);

		public static bool LoginAsync(out uint asyncId, uint gameServerId, string accessKey, NetworkServiceAccountId nsaId, byte[] nsaIdToken, int timeOut = 30000, [Optional] NexPlugin.NgsFacade.LoginCB callback)
		{
			return default(bool);
		}

		private static extern bool Ngs_LogoutAsync(uint asyncId, IntPtr pNgsFacade);

		public static bool LogoutAsync(out uint asyncId, IntPtr pNgsFacade, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool Ngs_TestConnectivityAsync(uint asyncId, IntPtr pNgsFacade);

		public static bool TestConnectivityAsync(out uint asyncId, IntPtr pNgsFacade, [Optional] NexPlugin.NgsFacade.TestConnectivityCB callback)
		{
			return default(bool);
		}

		private static void NGSLoginResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void TestConnectivityResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		public static void Callback(AsyncResultInt res, object callback)
		{
		}
	}

	public static class Ranking
	{
		private struct RankingRankDataInt : IExchangeList<RankingRankData>
		{
			private ulong uniqueId;

			private uint category;

			private uint score;

			private ulong param;

			private NpDateTime updateTime;

			private CppArray commonData;

			private ulong principalId;

			private uint order;

			private byte group0;

			private byte group1;

			public RankingRankData ExchangeStruct()
			{
				return null;
			}

			public RankingRankDataInt(List<IntPtr> useptr, RankingRankData param)
			{
			}
		}

		private struct RankingResultInt : IExchangeList<RankingResult>
		{
			private CppArray rankDataList;

			private NpDateTime sinceTime;

			private uint totalCount;

			public static RankingResult ExchangePtrToStruct(IntPtr src)
			{
				return null;
			}

			public RankingResult ExchangeStruct()
			{
				return null;
			}

			public RankingResultInt(List<IntPtr> useptr, RankingResult param)
			{
			}
		}

		private struct RankingCachedResultInt : IExchangeList<RankingCachedResult>
		{
			public NpDateTime createdTime;

			public NpDateTime expiredTime;

			public RankingResultInt rankingResult;

			public uint maxLength;

			public static RankingCachedResult ExchangePtrToStruct(IntPtr src)
			{
				return null;
			}

			public RankingCachedResult ExchangeStruct()
			{
				return null;
			}

			public RankingCachedResultInt(List<IntPtr> useptr, RankingCachedResult param)
			{
			}
		}

		private struct RankingScoreDataInt
		{
			private ulong param;

			private uint category;

			private uint score;

			private byte orderBy;

			private byte updateMode;

			private byte group0;

			private byte group1;

			public RankingScoreDataInt(RankingScoreData param)
			{
			}
		}

		private struct RankingOrderParamInt
		{
			private byte orderCalc;

			private byte groupIndex;

			private byte groupNum;

			private byte timeScope;

			private uint offset;

			private byte length;

			public RankingOrderParamInt(RankingOrderParam param)
			{
			}
		}

		private struct RankingChangeAttributesParamInt
		{
			private ulong param;

			private byte modificationFlag;

			private byte group0;

			private byte group1;

			public RankingChangeAttributesParamInt(RankingChangeAttributesParam param)
			{
			}
		}

		private static extern bool Ranking_UploadCommonDataAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray commonData, ulong nexUniqueId, int timeOut);

		public static bool UploadCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, List<byte> commonData, ulong nexUniqueId, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool Ranking_DeleteCommonDataAsync(uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId, int timeOut);

		public static bool DeleteCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool Ranking_GetCommonDataAsync(uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId, int timeOut);

		public static bool GetCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId, int timeOut = 0, [Optional] NexPlugin.Ranking.GetCommonDataCB callback)
		{
			return default(bool);
		}

		private static extern bool Ranking_UploadScoreAsync(uint asyncId, IntPtr pNgsFacade, ref RankingScoreDataInt scoreData, ulong nexUniqueId, int timeOut);

		public static bool UploadScoreAsync(out uint asyncId, IntPtr pNgsFacade, RankingScoreData scoreData, ulong nexUniqueId, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool Ranking_DeleteScoreAsync(uint asyncId, IntPtr pNgsFacade, int useCategory, uint category, ulong nexUniqueId, int timeOut);

		public static bool DeleteScoreAsync(out uint asyncId, IntPtr pNgsFacade, bool useCategory, uint category, ulong nexUniqueId, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool Ranking_GetRankingAsync(uint asyncId, IntPtr pNgsFacade, uint rankingMode, uint category, ref RankingOrderParamInt orderParam, ulong nexUniqueId, ulong principalId, int timeOut);

		public static bool GetRankingAsync(out uint asyncId, IntPtr pNgsFacade, NexPlugin.Ranking.RankingMode rankingMode, uint category, RankingOrderParam orderParam, ulong nexUniqueId, ulong principalId, int timeOut = 0, [Optional] NexPlugin.Ranking.GetRankingCB callback)
		{
			return default(bool);
		}

		private static extern bool Ranking_GetRankingByPIDListAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray principalIdList, uint rankingMode, uint category, ref RankingOrderParamInt orderParam, ulong nexUniqueId, int timeOut);

		public static bool GetRankingByPIDListAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> principalIdList, NexPlugin.Ranking.RankingMode rankingMode, uint category, RankingOrderParam orderParam, ulong nexUniqueId, int timeOut = 0, [Optional] NexPlugin.Ranking.GetRankingCB callback)
		{
			return default(bool);
		}

		private static extern bool Ranking_GetRankingByUIDListAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray nexUniqueIdList, uint rankingMode, uint category, ref RankingOrderParamInt orderParam, ulong nexUniqueId, int timeOut);

		public static bool GetRankingByUIDListAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> nexUniqueIdList, NexPlugin.Ranking.RankingMode rankingMode, uint category, RankingOrderParam orderParam, ulong nexUniqueId, int timeOut = 0, [Optional] NexPlugin.Ranking.GetRankingCB callback)
		{
			return default(bool);
		}

		private static extern bool Ranking_GetApproxOrderAsync(uint asyncId, IntPtr pNgsFacade, uint category, ref RankingOrderParamInt orderParam, uint score, ulong nexUniqueId, ulong principalId, int timeOut);

		public static bool GetApproxOrderAsync(out uint asyncId, IntPtr pNgsFacade, uint category, RankingOrderParam orderParam, uint score, ulong nexUniqueId, ulong principalId, int timeOut = 0, [Optional] NexPlugin.Ranking.GetApproxOrderCB callback)
		{
			return default(bool);
		}

		private static extern bool Ranking_GetStatsAsync(uint asyncId, IntPtr pNgsFacade, uint category, ref RankingOrderParamInt orderParam, uint flags, int timeOut);

		public static bool GetStatsAsync(out uint asyncId, IntPtr pNgsFacade, uint category, RankingOrderParam orderParam, NexPlugin.Ranking.StatsFlag flags, int timeOut = 0, [Optional] NexPlugin.Ranking.GetStatsCB callback)
		{
			return default(bool);
		}

		private static extern bool Ranking_ChangeAttributesAsync(uint asyncId, IntPtr pNgsFacade, int useCategory, uint category, ref RankingChangeAttributesParamInt changeParam, ulong nexUniqueId, int timeOut);

		public static bool ChangeAttributesAsync(out uint asyncId, IntPtr pNgsFacade, bool useCategory, uint category, RankingChangeAttributesParam changeParam, ulong nexUniqueId, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool Ranking_GetCachedTopXRankingAsync(uint asyncId, IntPtr pNgsFacade, uint category, ref RankingOrderParamInt orderParam, int timeOut);

		public static bool GetCachedTopXRankingAsync(out uint asyncId, IntPtr pNgsFacade, uint category, RankingOrderParam orderParam, int timeOut = 0, [Optional] NexPlugin.Ranking.GetCachedTopXRankingCB callback)
		{
			return default(bool);
		}

		private static extern bool Ranking_GetCachedTopXRankingsAsync(uint asyncId, IntPtr pNgsFacade, int useOneRankingOrderParam, ref CppArray categories, ref CppArray orderParams, int timeOut);

		public static bool GetCachedTopXRankingsAsync(out uint asyncId, IntPtr pNgsFacade, bool useOneRankingOrderParam, List<uint> categories, List<RankingOrderParam> orderParams, int timeOut = 0, [Optional] NexPlugin.Ranking.GetCachedTopXRankingsCB callback)
		{
			return default(bool);
		}

		private static extern RankingCachedResult.LocalUpdateState Ranking_LocalUpdate(ref IntPtr pNewResult, ref RankingCachedResultInt cachedResult, ref RankingOrderParamInt orderParam, ref RankingScoreDataInt scoreData, ulong pid, ulong nexUniqueId, ref NpDateTime utcCurrentTime, ref CppArray pCommonData);

		public static RankingCachedResult.LocalUpdateState LocalUpdate(out RankingCachedResult newResult, RankingCachedResult result, RankingOrderParam orderParam, RankingScoreData scoreData, ulong pid, ulong nexUniqueId, NpDateTime utcCurrentTime, List<byte> pCommonData)
		{
			return default(RankingCachedResult.LocalUpdateState);
		}

		private static extern void Ranking_DeleteCachedResult(IntPtr cachedResult);

		private static void Ranking_GetCommonDataResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void Ranking_GetRankingResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void Ranking_GetApproxOrderResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void Ranking_GetStatsResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void Ranking_GetCachedTopXRankingResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void Ranking_GetCachedTopXRankingsResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		public static void Callback(AsyncResultInt res, object callback)
		{
		}
	}

	public static class Ranking2
	{
		private struct Ranking2CommonDataInt
		{
			public CppArray binaryData;

			public CppArray userName;

			public static Ranking2CommonData ExchangePtrToStruct(IntPtr src)
			{
				return null;
			}

			public Ranking2CommonData ExchangeStruct()
			{
				return null;
			}

			public Ranking2CommonDataInt(List<IntPtr> useptr, Ranking2CommonData param)
			{
			}
		}

		private struct Ranking2RankDataInt : IExchangeList<Ranking2RankData>
		{
			private Ranking2CommonDataInt commonData;

			private ulong misc;

			private ulong nexUniqueId;

			private uint rank;

			private uint score;

			private ulong principalId;

			public Ranking2RankData ExchangeStruct()
			{
				return null;
			}
		}

		private struct Ranking2InfoInt
		{
			private CppArray ranking2RankDataList;

			private uint numRankedIn;

			private uint lowestRank;

			private int season;

			public static Ranking2Info ExchangePtrToStruct(IntPtr src)
			{
				return null;
			}
		}

		private struct Ranking2CategorySettingInt
		{
			private uint minScore;

			private uint maxScore;

			private ushort lowestRank;

			private byte maxSeasonsToGoBack;

			private byte resetMode;

			private byte resetHour;

			private byte resetDay;

			private ushort resetMonth;

			private byte scoreorder;

			public static Ranking2CategorySetting ExchangePtrToStruct(IntPtr src)
			{
				return null;
			}
		}

		private struct Ranking2ChartInfoInt : IExchangeList<Ranking2ChartInfo>
		{
			private uint index;

			private uint category;

			private uint season;

			private uint samplingRate;

			private uint scoreOrder;

			private uint estimateLength;

			private uint estimateHighestScore;

			private uint estimateLowestScore;

			private uint estimateMedianScore;

			private uint highestBinsScore;

			private uint lowestBinsScore;

			private uint binsWidth;

			private uint attribute1;

			private uint attribute2;

			private NpDateTime createTime;

			private double estimateAverageScore;

			private CppArray quantities;

			private byte binsSize;

			public static Ranking2ChartInfo ExchangePtrToStruct(IntPtr src)
			{
				return null;
			}

			public Ranking2ChartInfo ExchangeStruct()
			{
				return null;
			}
		}

		private struct Ranking2ScoreDataInt
		{
			private uint category;

			private uint score;

			private ulong misc;

			public Ranking2ScoreDataInt(Ranking2ScoreData param)
			{
			}
		}

		private struct Ranking2GetParamInt
		{
			private ulong nexUniqueId;

			private ulong principalId;

			private uint category;

			private uint offset;

			private uint length;

			private uint optionFlags;

			private uint sortFlags;

			private byte mode;

			private byte numSeasonsToGoBack;

			public Ranking2GetParamInt(List<IntPtr> useptr, Ranking2GetParam param)
			{
			}
		}

		private struct Ranking2GetByListParamInt
		{
			private uint category;

			private uint offset;

			private uint length;

			private uint optionFlags;

			private uint sortFlags;

			private byte numSeasonsToGoBack;

			public Ranking2GetByListParamInt(List<IntPtr> useptr, Ranking2GetByListParam param)
			{
			}
		}

		private static extern bool Ranking2_PutScoreAsync(uint asyncId, IntPtr pNgsFacade, ref Ranking2ScoreDataInt pParam, ulong nexUniqueId, int timeOut);

		public static bool PutScoreAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2ScoreData scoreData, ulong nexUniqueId, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool Ranking2_PutScoreListAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray pParam, ulong nexUniqueId, int timeOut);

		public static bool PutScoreAsync(out uint asyncId, IntPtr pNgsFacade, List<Ranking2ScoreData> scoreDataList, ulong nexUniqueId, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool Ranking2_PutCommonDataAsync(uint asyncId, IntPtr pNgsFacade, ref Ranking2CommonDataInt commonData, ulong nexUniqueId, int timeOut);

		public static bool PutCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2CommonData commonData, ulong nexUniqueId, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool Ranking2_GetCommonDataAsync(uint asyncId, IntPtr pNgsFacade, uint optionFlags, ulong principalId, ulong nexUniqueId, int timeOut);

		public static bool GetCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, NexPlugin.Ranking2.Ranking2GetOptionFlags optionFlags, ulong principalId, ulong nexUniqueId, int timeOut = 0, [Optional] NexPlugin.Ranking2.GetCommonDataCB callback)
		{
			return default(bool);
		}

		private static extern bool Ranking2_DeleteCommonDataAsync(uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId, int timeOut);

		public static bool DeleteCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool Ranking2_GetRankingAsync(uint asyncId, IntPtr pNgsFacade, ref Ranking2GetParamInt getParam, int timeOut);

		public static bool GetRankingAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2GetParam getParam, int timeOut = 0, [Optional] NexPlugin.Ranking2.GetRankingCB callback)
		{
			return default(bool);
		}

		private static extern bool Ranking2_GetRankingByListAsync(uint asyncId, IntPtr pNgsFacade, ref Ranking2GetByListParamInt getParam, ref CppArray principalIdList, int timeOut);

		public static bool GetRankingAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2GetByListParam getParam, List<ulong> principalIdList, int timeOut = 0, [Optional] NexPlugin.Ranking2.GetRankingCB callback)
		{
			return default(bool);
		}

		private static extern bool Ranking2_GetCategorySettingAsync(uint asyncId, IntPtr pNgsFacade, uint category, int timeOut);

		public static bool GetCategorySettingAsync(out uint asyncId, IntPtr pNgsFacade, uint category, int timeOut = 0, [Optional] NexPlugin.Ranking2.GetCategorySettingCB callback)
		{
			return default(bool);
		}

		private static extern bool Ranking2_GetRankingChartAsync(uint asyncId, IntPtr pNgsFacade, ref Ranking2ChartInfoInput info, int timeOut);

		public static bool GetRankingChartAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2ChartInfoInput info, int timeOut = 0, [Optional] NexPlugin.Ranking2.GetRanking2ChartInfoCB callback)
		{
			return default(bool);
		}

		private static extern bool Ranking2_GetRankingChartsAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray info, int timeOut);

		public static bool GetRankingChartAsync(out uint asyncId, IntPtr pNgsFacade, List<Ranking2ChartInfoInput> info, int timeOut = 0, [Optional] NexPlugin.Ranking2.GetRanking2ChartInfoListCB callback)
		{
			return default(bool);
		}

		private static extern bool Ranking2_GetEstimateScoreRankAsync(uint asyncId, IntPtr pNgsFacade, ref Ranking2EstimateScoreRankInput info, int timeOut);

		public static bool GetEstimateScoreRankAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2EstimateScoreRankInput info, int timeOut = 0, [Optional] NexPlugin.Ranking2.GetRanking2EstimateScoreRankCB callback)
		{
			return default(bool);
		}

		private static void Ranking2_GetCommonDataResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void Ranking2_GetRankingResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void Ranking2_GetCategorySettingResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void Ranking2_GetRanking2ChartInfoResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void Ranking2_GetRanking2ChartInfoListResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void Ranking2_GetRanking2EstimateScoreRankResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		public static void Callback(AsyncResultInt res, object callback)
		{
		}
	}

	public static class SmartDeviceVoiceChat
	{
		private struct SmartDeviceVoiceChatJoinRoomResultInt
		{
			private ulong roomId;

			public SmartDeviceVoiceChatJoinRoomResultInt(SmartDeviceVoiceChatJoinRoomResult param)
			{
			}

			public static SmartDeviceVoiceChatJoinRoomResult ExchangePtrToStruct(IntPtr src)
			{
				return null;
			}
		}

		private struct SmartDeviceVoiceChatShowAppPageResultInt
		{
			private int status;

			public SmartDeviceVoiceChatShowAppPageResultInt(SmartDeviceVoiceChatShowAppPageResult param)
			{
			}

			public static SmartDeviceVoiceChatShowAppPageResult ExchangePtrToStruct(IntPtr src)
			{
				return null;
			}
		}

		private struct SmartDeviceVoiceChatJoinRoomParamInt
		{
			private ulong sessionId;

			private uint gameMode;

			private uint channelId;

			public SmartDeviceVoiceChatJoinRoomParamInt(SmartDeviceVoiceChatJoinRoomParam param)
			{
			}
		}

		private struct SmartDeviceVoiceChatLeaveRoomParamInt
		{
			private ulong roomId;

			public SmartDeviceVoiceChatLeaveRoomParamInt(SmartDeviceVoiceChatLeaveRoomParam param)
			{
			}
		}

		private struct SmartDeviceVoiceChatChangeVoiceChatChannelParamInt
		{
			private ulong roomId;

			private uint channelId;

			public SmartDeviceVoiceChatChangeVoiceChatChannelParamInt(SmartDeviceVoiceChatChangeVoiceChatChannelParam param)
			{
			}
		}

		private struct SmartDeviceVoiceChatShowAppPageParamInt
		{
			private UserHandle userHandle;

			public SmartDeviceVoiceChatShowAppPageParamInt(ref SmartDeviceVoiceChatShowAppPageParam param)
			{
			}
		}

		private static extern bool SmartDeviceVoiceChat_ShowAppPageAsync(uint asyncId, ref SmartDeviceVoiceChatShowAppPageParamInt pParam);

		public static bool ShowAppPageAsync(out uint asyncId, SmartDeviceVoiceChatShowAppPageParam param, [Optional] NexPlugin.SmartDeviceVoiceChat.ShowAppPageCB callback)
		{
			return default(bool);
		}

		private static extern bool SmartDeviceVoiceChat_ChangeVoiceChatChannelAsync(uint asyncId, ref SmartDeviceVoiceChatChangeVoiceChatChannelParamInt pParam, int timeOut);

		public static bool ChangeVoiceChatChannelAsync(out uint asyncId, SmartDeviceVoiceChatChangeVoiceChatChannelParam param, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool SmartDeviceVoiceChat_GetAvailabilityAsync(uint asyncId, int timeOut);

		public static bool GetAvailabilityAsync(out uint asyncId, int timeOut = 0, [Optional] NexPlugin.SmartDeviceVoiceChat.GetAvailabilityCB callback)
		{
			return default(bool);
		}

		private static extern bool SmartDeviceVoiceChat_JoinRoomAsync(uint asyncId, ref SmartDeviceVoiceChatJoinRoomParamInt pParam, int timeOut = 0);

		public static bool JoinRoomAsync(out uint asyncId, SmartDeviceVoiceChatJoinRoomParam param, int timeOut = 0, [Optional] NexPlugin.SmartDeviceVoiceChat.JoinRoomCB callback)
		{
			return default(bool);
		}

		private static extern bool SmartDeviceVoiceChat_LeaveRoomAsync(uint asyncId, ref SmartDeviceVoiceChatLeaveRoomParamInt pParam, int timeOut = 0);

		public static bool LeaveRoomAsync(out uint asyncId, SmartDeviceVoiceChatLeaveRoomParam param, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool SmartDeviceVoiceChat_LeaveRoom(ref SmartDeviceVoiceChatLeaveRoomParamInt pParam);

		public static bool LeaveRoom(SmartDeviceVoiceChatLeaveRoomParam param)
		{
			return default(bool);
		}

		private static void SmartDeviceVoiceChat_GetAvailabilityResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void SmartDeviceVoiceChat_JoinRoomResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void SmartDeviceVoiceChat_ShowAppPageResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		public static void Callback(AsyncResultInt res, object callback)
		{
		}
	}

	public static class Subscriber
	{
		private struct SubscriberContentInt : IExchangeList<SubscriberContent>
		{
			private ulong contentId;

			private NpDateTime postTime;

			private CppArray topics;

			private CppArray binary;

			private CppArray message;

			private ulong pid;

			public SubscriberContent ExchangeStruct()
			{
				return null;
			}
		}

		private struct SubscriberPostContentParamInt
		{
			private CppArray topics;

			private CppArray contentBinary;

			private CppArray contentMessage;

			public SubscriberPostContentParamInt(List<IntPtr> useptr, SubscriberPostContentParam param)
			{
			}
		}

		public struct SubscriberGetContentParamInt
		{
			private uint size;

			private uint offset;

			private ulong minimumContentId;

			private uint topic;

			public SubscriberGetContentParamInt(SubscriberGetContentParam param)
			{
			}
		}

		private struct SubscriberUserStatusInfoInt : IExchangeList<SubscriberUserStatusInfo>
		{
			private CppArray keys;

			private CppArray values;

			private ulong pid;

			public static SubscriberUserStatusInfo ExchangePtrToStruct(IntPtr src)
			{
				return null;
			}

			public SubscriberUserStatusInfo ExchangeStruct()
			{
				return null;
			}
		}

		private struct SubscriberUserStatusParamInt
		{
			private CppArray value;

			private byte key;

			public SubscriberUserStatusParamInt(List<IntPtr> useptr, SubscriberUserStatusParam param)
			{
			}
		}

		private static List<List<SubscriberContent>> Exchange(IntPtr src)
		{
			return null;
		}

		private static extern bool Subscriber_PostContentAsync(uint asyncId, IntPtr pNgsFacade, ref SubscriberPostContentParamInt pParam, int timeOut);

		public static bool PostContentAsync(out uint asyncId, IntPtr pNgsFacade, SubscriberPostContentParam param, int timeOut = 0, [Optional] NexPlugin.Subscriber.PostContentCB callback)
		{
			return default(bool);
		}

		private static extern bool Subscriber_GetContentAsync(uint asyncId, IntPtr pNgsFacade, ref SubscriberGetContentParamInt pParam, int timeOut);

		public static bool GetContentAsync(out uint asyncId, IntPtr pNgsFacade, SubscriberGetContentParam param, int timeOut = 0, [Optional] NexPlugin.Subscriber.GetContentCB callback)
		{
			return default(bool);
		}

		private static extern bool Subscriber_GetContentsAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray pParam, int timeOut);

		public static bool GetContentAsync(out uint asyncId, IntPtr pNgsFacade, List<SubscriberGetContentParam> param, int timeOut = 0, [Optional] NexPlugin.Subscriber.GetContentsCB callback)
		{
			return default(bool);
		}

		private static extern bool Subscriber_DeleteContentAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray topics, ulong contentId, int timeOut);

		public static bool DeleteContentAsync(out uint asyncId, IntPtr pNgsFacade, List<uint> topics, ulong contentId, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool Subscriber_GetFriendUserStatusesAsync(uint asyncId, IntPtr pNgsFacade, int timeOut);

		public static bool GetFriendUserStatusesAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, [Optional] NexPlugin.Subscriber.GetSubscriberUserStatusInfoCB callback)
		{
			return default(bool);
		}

		private static extern bool Subscriber_GetFriendUserStatusesWithKeyAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray keys, int timeOut);

		public static bool GetFriendUserStatusesAsync(out uint asyncId, IntPtr pNgsFacade, List<byte> keys, int timeOut = 0, [Optional] NexPlugin.Subscriber.GetSubscriberUserStatusInfoCB callback)
		{
			return default(bool);
		}

		private static extern bool Subscriber_GetUserStatusesAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray users, ref CppArray keys, int timeOut);

		public static bool GetUserStatusesAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> users, List<byte> keys, int timeOut = 0, [Optional] NexPlugin.Subscriber.GetSubscriberUserStatusInfoCB callback)
		{
			return default(bool);
		}

		private static extern bool Subscriber_UpdateUserStatusAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray param, int isNotify, int timeOut);

		public static bool UpdateUserStatusAsync(out uint asyncId, IntPtr pNgsFacade, List<SubscriberUserStatusParam> param, bool isNotify, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool Subscriber_GetFriendUserStatusesCacheMode(IntPtr pNgsFacade, ref int result);

		public static bool GetFriendUserStatusesCacheMode(IntPtr pNgsFacade, out bool result)
		{
			return default(bool);
		}

		private static extern bool Subscriber_GetFriendUserStatusesCacheLastResult(IntPtr pNgsFacade, ref Result result);

		public static bool GetFriendUserStatusesCacheLastResult(IntPtr pNgsFacade, out Result result)
		{
			return default(bool);
		}

		private static extern bool Subscriber_GetFriendUserStatuses(IntPtr pNgsFacade, ref IntPtr infos, ref Result result);

		public static bool GetFriendUserStatuses(IntPtr pNgsFacade, out List<SubscriberUserStatusInfo> infos, out Result result)
		{
			return default(bool);
		}

		private static extern bool Subscriber_GetFriendUserStatusesWithKey(IntPtr pNgsFacade, ref CppArray users, ref IntPtr infos, ref Result result);

		public static bool GetFriendUserStatuses(IntPtr pNgsFacade, List<ulong> users, out List<SubscriberUserStatusInfo> infos, out Result result)
		{
			return default(bool);
		}

		private static extern void Subscriber_DeleteSubscriberUserStatusInfo(IntPtr info);

		private static void Subscriber_PostContentResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void Subscriber_GetContentResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void Subscriber_GetContentsResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void Subscriber_UserStatusInfoResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		public static void Callback(AsyncResultInt res, object callback)
		{
		}
	}

	public class Util_UnmanagedManager
	{
		public static IntPtr AllocHGlobal(int size, bool output = true)
		{
			return default(IntPtr);
		}

		public static bool FreeHGlobal(IntPtr p, bool output = true)
		{
			return default(bool);
		}

		public static int GetAllocedCount()
		{
			return default(int);
		}

		public static int GetUsedAllocsize()
		{
			return default(int);
		}
	}

	public static class Utility
	{
		private struct UniqueIdInfoInt : IExchangeList<UniqueIdInfo>
		{
			private ulong nexUniqueId;

			private ulong nexUniqueIdPassword;

			public UniqueIdInfo ExchangeStruct()
			{
				return null;
			}

			public static UniqueIdInfo ExchangePtrToStruct(IntPtr src)
			{
				return null;
			}

			public UniqueIdInfoInt(UniqueIdInfo param)
			{
			}
		}

		private struct IntegerSettings
		{
			public int value;

			public ushort key;
		}

		private static extern bool Utility_AcquireNexUniqueIdAsync(uint asyncId, IntPtr pNgsFacade, int timeOut);

		public static bool AcquireNexUniqueIdAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, [Optional] NexPlugin.Utility.AcquireNexUniqueIdCB callback)
		{
			return default(bool);
		}

		private static extern bool Utility_AcquireNexUniqueIdWithPasswordAsync(uint asyncId, IntPtr pNgsFacade, int timeOut);

		public static bool AcquireNexUniqueIdWithPasswordAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, [Optional] NexPlugin.Utility.AcquireNexUniqueIdWithPasswordCB callback)
		{
			return default(bool);
		}

		private static extern bool Utility_AssociateNexUniqueIdWithMyPrincipalIdAsync(uint asyncId, IntPtr pNgsFacade, ref UniqueIdInfoInt pParam, int timeOut);

		public static bool AssociateNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, UniqueIdInfo param, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool Utility_AssociateNexUniqueIdWithMyPrincipalIdListAsync(uint asyncId, IntPtr pNgsFacade, ref CppArray pParam, int timeOut);

		public static bool AssociateNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, List<UniqueIdInfo> param, int timeOut = 0, [Optional] AsyncResultCB callback)
		{
			return default(bool);
		}

		private static extern bool Utility_GetAssociatedNexUniqueIdWithMyPrincipalIdAsync(uint asyncId, IntPtr pNgsFacade, int timeOut);

		public static bool GetAssociatedNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, [Optional] NexPlugin.Utility.GetAssociatedNexUniqueIdWithMyPrincipalIdCB callback)
		{
			return default(bool);
		}

		private static extern bool Utility_GetAssociatedNexUniqueIdWithMyPrincipalIdListAsync(uint asyncId, IntPtr pNgsFacade, int timeOut);

		public static bool GetAssociatedNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, [Optional] NexPlugin.Utility.GetAssociatedNexUniqueIdWithMyPrincipalIdListCB callback)
		{
			return default(bool);
		}

		private static extern bool Utility_GetIntegerSettingsAsync(uint asyncId, IntPtr pNgsFacade, uint integerSettingIndex, int timeOut);

		public static bool GetIntegerSettingsAsync(out uint asyncId, IntPtr pNgsFacade, uint integerSettingIndex, int timeOut = 0, [Optional] NexPlugin.Utility.GetIntegerSettingsCB callback)
		{
			return default(bool);
		}

		private static void AcquireNexUniqueIdResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void AcquireNexUniqueIdWithPasswordResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void GetAssociatedNexUniqueIdWithMyPrincipalIdResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void GetAssociatedNexUniqueIdWithMyPrincipalIdListResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		private static void GetIntegerSettingsResult(ref AsyncResultInt asyncResult, object callback)
		{
		}

		public static void Callback(AsyncResultInt res, object callback)
		{
		}
	}

	public const string DLL_NAME = "__Internal";

	private static List<NotificationEventCB> s_NotificationEventCB;

	private static Dictionary<uint, object> s_NexAsyncCall;

	private static uint m_AsyncId;

	public static void GetAsyncResult(ref AsyncResultInt asyncResult, object callback)
	{
	}

	public static bool RegisterNotificationEventHandler(NotificationEventCB callback)
	{
		return default(bool);
	}

	public static bool UnregisterNotificationEventHandler(NotificationEventCB callback)
	{
		return default(bool);
	}

	public static void NotificationEventListCallback(List<NotificationEvent> notificationEventList)
	{
	}

	public static void AddNexResultCallback(uint asyncId, object callback)
	{
	}

	public static void AsyncResultCallback(ref List<AsyncResultInt> AsyncResultList)
	{
	}

	public static uint PublishAsyncId()
	{
		return default(uint);
	}

	public static int GetNexAsyncCallCount()
	{
		return default(int);
	}

	public static void DumpNexAsyncCallList()
	{
	}

	public static void NP_LOG(string str)
	{
	}

	public static void NP_LOG(string format, object[] arg)
	{
	}

	public static T ExchangePtrToStruct<T>(IntPtr src)
	{
		return (T)null;
	}

	public static IntPtr CopyStruct<T>(T[] param)
	{
		return default(IntPtr);
	}
}
