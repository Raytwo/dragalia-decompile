using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace NexPlugin;

public static class DataStore
{
	public delegate void PostCB(AsyncResult asyncResult, ulong dataId);

	public delegate void ResultListCB(AsyncResult asyncResult, List<DataStoreResult> resultList);

	public delegate void SearchObjectCB(AsyncResult asyncResult, DataStoreSearchResult result);

	public delegate void GetObjectCB(AsyncResult asyncResult, byte[] data);

	public delegate void GetMetaCB(AsyncResult asyncResult, DataStoreMetaInfo info);

	public delegate void GetMetaListCB(AsyncResult asyncResult, List<DataStoreMetaInfo> info, List<DataStoreResult> resultList);

	public delegate void RatingInfoCB(AsyncResult asyncResult, DataStoreRatingInfo info);

	public delegate void RatingInfoAllSlotCB(AsyncResult asyncResult, Dictionary<sbyte, DataStoreRatingInfo> info);

	public delegate void RatingInfoWithLogCB(AsyncResult asyncResult, DataStoreRatingInfo info, DataStoreRatingLog log);

	public delegate void RatingInfoListCB(AsyncResult asyncResult, List<DataStoreRatingInfo> info, List<DataStoreResult> resultList);

	public delegate void RatingInfosListCB(AsyncResult asyncResult, List<Dictionary<sbyte, DataStoreRatingInfo>> info, List<DataStoreResult> resultList);

	public delegate void GetPersistenceInfoCB(AsyncResult asyncResult, DataStorePersistenceInfo info);

	public delegate void GetPersistenceInfoListCB(AsyncResult asyncResult, List<DataStorePersistenceInfo> info, List<DataStoreResult> resultList);

	public delegate void GetPasswordInfoCB(AsyncResult asyncResult, DataStorePasswordInfo info);

	public delegate void GetPasswordInfoListCB(AsyncResult asyncResult, List<DataStorePasswordInfo> info, List<DataStoreResult> resultList);

	public enum Permission
	{
		PERMISSION_PUBLIC,
		PERMISSION_FRIEND,
		PERMISSION_SPECIFIED,
		PERMISSION_PRIVATE,
		PERMISSION_SPECIFIED_FRIEND
	}

	[Flags]
	public enum DataFlag
	{
		DATA_FLAG_NONE = 0,
		DATA_FLAG_NEED_REVIEW = 1,
		DATA_FLAG_PERIOD_FROM_LAST_REFERRED = 2,
		DATA_FLAG_USE_READ_LOCK = 4,
		DATA_FLAG_USE_NOTIFICATION_ON_POST = 8,
		DATA_FLAG_USE_NOTIFICATION_ON_UPDATE = 0x10,
		DATA_FLAG_NOT_USE_FILESERVER = 0x20,
		DATA_FLAG_NEED_COMPLETION = 0x40
	}

	[Flags]
	public enum ModificationFlag
	{
		MODIFICATION_FLAG_NONE = 0,
		MODIFICATION_FLAG_NAME = 1,
		MODIFICATION_FLAG_ACCESS_PERMISSION = 2,
		MODIFICATION_FLAG_UPDATE_PERMISSION = 4,
		MODIFICATION_FLAG_PERIOD = 8,
		MODIFICATION_FLAG_METABINARY = 0x10,
		MODIFICATION_FLAG_TAGS = 0x20,
		MODIFICATION_FLAG_UPDATED_TIME = 0x40,
		MODIFICATION_FLAG_DATA_TYPE = 0x80,
		MODIFICATION_FLAG_STATUS = 0x200
	}

	public enum DataStatus
	{
		DATA_STATUS_NONE = 0,
		DATA_STATUS_PENDING = 2,
		DATA_STATUS_REJECTED = 5
	}

	[Flags]
	public enum ComparisonFlag
	{
		COMPARISON_FLAG_NONE = 0,
		COMPARISON_FLAG_NAME = 1,
		COMPARISON_FLAG_ACCESS_PERMISSION = 2,
		COMPARISON_FLAG_UPDATE_PERMISSION = 4,
		COMPARISON_FLAG_PERIOD = 8,
		COMPARISON_FLAG_METABINARY = 0x10,
		COMPARISON_FLAG_TAGS = 0x20,
		COMPARISON_FLAG_DATA_TYPE = 0x40,
		COMPARISON_FLAG_STATUS = 0x100,
		COMPARISON_FLAG_ALL = 0xFFFF
	}

	public enum SearchType
	{
		SEARCH_TYPE_PUBLIC = 1,
		SEARCH_TYPE_SEND_FRIEND = 2,
		SEARCH_TYPE_SEND_SPECIFIED = 3,
		SEARCH_TYPE_SEND_SPECIFIED_FRIEND = 4,
		SEARCH_TYPE_SEND = 5,
		SEARCH_TYPE_FRIEND = 6,
		SEARCH_TYPE_RECEIVED_SPECIFIED = 7,
		SEARCH_TYPE_RECEIVED = 8,
		SEARCH_TYPE_PRIVATE = 9,
		SEARCH_TYPE_OWN = 10,
		SEARCH_TYPE_OWN_PENDING = 12,
		SEARCH_TYPE_OWN_REJECTED = 13,
		SEARCH_TYPE_OWN_ALL = 14
	}

	public enum SearchTarget
	{
		SEARCH_TARGET_ANYBODY,
		SEARCH_TARGET_FRIEND
	}

	public enum SearchSortColumn
	{
		SEARCH_SORT_COLUMN_DATAID = 0,
		SEARCH_SORT_COLUMN_CREATED_TIME = 5,
		SEARCH_SORT_COLUMN_UPDATED_TIME = 6,
		SEARCH_SORT_COLUMN_RATING0 = 64,
		SEARCH_SORT_COLUMN_RATING1 = 65,
		SEARCH_SORT_COLUMN_RATING2 = 66,
		SEARCH_SORT_COLUMN_RATING3 = 67,
		SEARCH_SORT_COLUMN_RATING4 = 68,
		SEARCH_SORT_COLUMN_RATING5 = 69,
		SEARCH_SORT_COLUMN_RATING6 = 70,
		SEARCH_SORT_COLUMN_RATING7 = 71,
		SEARCH_SORT_COLUMN_RATING8 = 72,
		SEARCH_SORT_COLUMN_RATING9 = 73,
		SEARCH_SORT_COLUMN_RATING10 = 74,
		SEARCH_SORT_COLUMN_RATING11 = 75,
		SEARCH_SORT_COLUMN_RATING12 = 76,
		SEARCH_SORT_COLUMN_RATING13 = 77,
		SEARCH_SORT_COLUMN_RATING14 = 78,
		SEARCH_SORT_COLUMN_RATING15 = 79,
		SEARCH_SORT_COLUMN_RATING_AVERAGE0 = 96,
		SEARCH_SORT_COLUMN_RATING_AVERAGE1 = 97,
		SEARCH_SORT_COLUMN_RATING_AVERAGE2 = 98,
		SEARCH_SORT_COLUMN_RATING_AVERAGE3 = 99,
		SEARCH_SORT_COLUMN_RATING_AVERAGE4 = 100,
		SEARCH_SORT_COLUMN_RATING_AVERAGE5 = 101,
		SEARCH_SORT_COLUMN_RATING_AVERAGE6 = 102,
		SEARCH_SORT_COLUMN_RATING_AVERAGE7 = 103,
		SEARCH_SORT_COLUMN_RATING_AVERAGE8 = 104,
		SEARCH_SORT_COLUMN_RATING_AVERAGE9 = 105,
		SEARCH_SORT_COLUMN_RATING_AVERAGE10 = 106,
		SEARCH_SORT_COLUMN_RATING_AVERAGE11 = 107,
		SEARCH_SORT_COLUMN_RATING_AVERAGE12 = 108,
		SEARCH_SORT_COLUMN_RATING_AVERAGE13 = 109,
		SEARCH_SORT_COLUMN_RATING_AVERAGE14 = 110,
		SEARCH_SORT_COLUMN_RATING_AVERAGE15 = 111
	}

	public enum SearchSortOrder
	{
		SEARCH_SORT_ORDER_ASC,
		SEARCH_SORT_ORDER_DESC
	}

	[Flags]
	public enum ResultFlag
	{
		RESULT_FLAG_TAGS = 1,
		RESULT_FLAG_RATINGS = 2,
		RESULT_FLAG_METABINARY = 4,
		RESULT_FLAG_PERMITTED_IDS = 8
	}

	public enum RatingLockType
	{
		RATING_LOCK_NONE,
		RATING_LOCK_INTERVAL,
		RATING_LOCK_PERIOD,
		RATING_LOCK_PERMANENT
	}

	public enum RatingFlag
	{
		RATING_FLAG_MODIFIABLE = 4,
		RATING_FLAG_ROUND_MINUS = 8,
		RATING_FLAG_DISABLE_SELF_RATING = 0x10
	}

	[Flags]
	internal enum RatingInternalFlag
	{
		RATING_INTERNAL_FLAG_USE_RANGE_MIN = 2,
		RATING_INTERNAL_FLAG_USE_RANGE_MAX = 4
	}

	public enum RatingLockPeriod
	{
		RATING_LOCK_PERIOD_MON = -1,
		RATING_LOCK_PERIOD_TUE = -2,
		RATING_LOCK_PERIOD_WED = -3,
		RATING_LOCK_PERIOD_THU = -4,
		RATING_LOCK_PERIOD_FRI = -5,
		RATING_LOCK_PERIOD_SAT = -6,
		RATING_LOCK_PERIOD_SUN = -7,
		RATING_LOCK_PERIOD_DAY1 = -17
	}

	public enum SearchResultTotalCountType
	{
		SEARCH_RESULT_TOTAL_EXACT,
		SEARCH_RESULT_TOTAL_MINIMUM,
		SEARCH_RESULT_TOTAL_ESTIMATE,
		SEARCH_RESULT_TOTAL_DISABLED
	}

	public const ushort MAX_PERIOD = 365;

	public const uint MAX_METABIN_SIZE = 1024u;

	public const uint DATASTOREPERMISSION_RECIPIENTIDS_MAX = 100u;

	public const ulong INVALID_DATAID = 0uL;

	public const ushort INVALID_DATA_TYPE = ushort.MaxValue;

	public const ulong INVALID_PASSWORD = 0uL;

	public const uint MAX_NAME_LENGTH = 64u;

	public const uint MAX_SEARCH_RESULT_SIZE = 100u;

	public const uint MAX_SEARCH_ANY_RESULT_SIZE = 20u;

	public const uint MAX_SEARCH_DATA_TYPE_SIZE = 10u;

	public const uint NUM_TAG_SLOT = 16u;

	public const uint RATING_SLOT_MAX = 15u;

	public const uint NUM_RATING_SLOT = 16u;

	public const uint MAX_TAG_LENGTH = 24u;

	public const ushort DEFAULT_PERIOD = 90;

	public const uint DEFAULT_HTTP_THREAD_PRIORITY = 16u;

	public const uint DEFAULT_RELAY_BUFFER_SIZE = 16384u;

	public const uint DEFAULT_HTTP_BUFFER_SIZE = 32768u;

	public const uint DEFAULT_DATA_TRANSFER_TIMEOUT_BYTES_PER_SECOND = 167u;

	public const int DEFAULT_DATA_TRANSFER_MINIMUM_TIMEOUT = 60000;

	public const uint DEFAULT_HTTP_SEND_SOCKET_BUFFER_SIZE = 65536u;

	public const uint DEFAULT_HTTP_RECV_SOCKET_BUFFER_SIZE = 65536u;

	public const ushort INVALID_PERSISTENCE_SLOT_ID = ushort.MaxValue;

	public const ushort NUM_PERSISTENCE_SLOT = 16;

	public const uint BATCH_PROCESSING_CAPACITY_POST_OBJECT = 16u;

	public const uint BATCH_PROCESSING_CAPACITY = 100u;

	public const ulong RESULTRANGE_ANY_OFFSET = 4294967295uL;

	public const uint RESULTRANGE_DEFAULT_SIZE = 20u;

	public static bool PostObjectAsync<T>(out uint asyncId, IntPtr pNgsFacade, DataStorePreparePostParam param, T[] array, int timeOut = 0, [Optional] PostCB callback) where T : struct
	{
		return default(bool);
	}

	public static bool PostMetaAsync(out uint asyncId, IntPtr pNgsFacade, DataStorePreparePostParam param, int timeOut = 0, [Optional] PostCB callback)
	{
		return default(bool);
	}

	public static bool PostMetaAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, DataStorePreparePostParam param, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool PostMetaAsync(out uint asyncId, IntPtr pNgsFacade, Dictionary<ulong, DataStorePreparePostParam> param, bool transactional = true, int timeOut = 0, [Optional] ResultListCB callback)
	{
		return default(bool);
	}

	public static bool PostMetaAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, DataStorePreparePostParam param, bool transactional = true, int timeOut = 0, [Optional] ResultListCB callback)
	{
		return default(bool);
	}

	public static bool CompleteSuspendedPostObjectAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool SearchObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreSearchParam param, int timeOut = 0, [Optional] SearchObjectCB callback)
	{
		return default(bool);
	}

	public static bool SearchObjectLightAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreSearchParam param, int timeOut = 0, [Optional] SearchObjectCB callback)
	{
		return default(bool);
	}

	public static bool DeleteObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreDeleteParam param, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool DeleteObjectAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool DeleteObjectAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreDeleteParam> param, bool transactional = true, int timeOut = 0, [Optional] ResultListCB callback)
	{
		return default(bool);
	}

	public static bool DeleteObjectAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, bool transactional = true, int timeOut = 0, [Optional] ResultListCB callback)
	{
		return default(bool);
	}

	public static bool UpdateObjectAsync<T>(out uint asyncId, IntPtr pNgsFacade, DataStorePrepareUpdateParam param, T[] array, int timeOut = 0, [Optional] AsyncResultCB callback) where T : struct
	{
		return default(bool);
	}

	public static bool GetObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStorePrepareGetParam param, ulong getBufSize, int timeOut = 0, [Optional] GetObjectCB callback)
	{
		return default(bool);
	}

	public static bool TouchObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreTouchObjectParam param, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool GetMetaAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreGetMetaParam param, int timeOut = 0, [Optional] GetMetaCB callback)
	{
		return default(bool);
	}

	public static bool GetMetaAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, DataStoreGetMetaParam param, int timeOut = 0, [Optional] GetMetaListCB callback)
	{
		return default(bool);
	}

	public static bool GetMetaAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreGetMetaParam> param, int timeOut = 0, [Optional] GetMetaListCB callback)
	{
		return default(bool);
	}

	public static bool ChangeMetaAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreChangeMetaParam param, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool ChangeMetaAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, DataStoreChangeMetaParam param, bool transactional = true, int timeOut = 0, [Optional] ResultListCB callback)
	{
		return default(bool);
	}

	public static bool ChangeMetaAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreChangeMetaParam> param, bool transactional = true, int timeOut = 0, [Optional] ResultListCB callback)
	{
		return default(bool);
	}

	public static bool RateObjectAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, DataStoreRateObjectParam param, int timeOut = 0, [Optional] RatingInfoCB callback)
	{
		return default(bool);
	}

	public static bool RateObjectAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreRatingTarget> target, DataStoreRateObjectParam param, bool transactional = true, int timeOut = 0, [Optional] RatingInfoListCB callback)
	{
		return default(bool);
	}

	public static bool RateObjectAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreRatingTarget> target, List<DataStoreRateObjectParam> param, bool transactional = true, int timeOut = 0, [Optional] RatingInfoListCB callback)
	{
		return default(bool);
	}

	public static bool RateObjectWithPostingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, DataStoreRateObjectParam rateParam, DataStorePreparePostParam postParam, int timeOut = 0, [Optional] RatingInfoCB callback)
	{
		return default(bool);
	}

	public static bool RateObjectsWithPostingAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreRatingTarget> target, List<DataStoreRateObjectParam> rateParam, List<DataStorePreparePostParam> postParam, bool transactional = true, int timeOut = 0, [Optional] RatingInfoListCB callback)
	{
		return default(bool);
	}

	public static bool RateObjectsWithPostingAsync(out uint asyncId, IntPtr pNgsFacade, List<DataStoreRatingTarget> target, DataStoreRateObjectParam rateParam, DataStorePreparePostParam postParam, bool transactional = true, int timeOut = 0, [Optional] RatingInfoListCB callback)
	{
		return default(bool);
	}

	public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, ulong accessPassword = 0uL, int timeOut = 0, [Optional] RatingInfoCB callback)
	{
		return default(bool);
	}

	public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut = 0, [Optional] RatingInfoAllSlotCB callback)
	{
		return default(bool);
	}

	public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, int timeOut = 0, [Optional] RatingInfosListCB callback)
	{
		return default(bool);
	}

	public static bool GetRatingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, ulong accessPassword = 0uL, int timeOut = 0, [Optional] RatingInfoWithLogCB callback)
	{
		return default(bool);
	}

	public static bool ResetRatingAsync(out uint asyncId, IntPtr pNgsFacade, DataStoreRatingTarget target, ulong accessPassword = 0uL, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool ResetRatingAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool ResetRatingAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, bool transactional = true, int timeOut = 0, [Optional] ResultListCB callback)
	{
		return default(bool);
	}

	public static bool GetPersistenceInfoAsync(out uint asyncId, IntPtr pNgsFacade, ulong principalId, ushort persistenceSlotId, int timeOut = 0, [Optional] GetPersistenceInfoCB callback)
	{
		return default(bool);
	}

	public static bool GetPersistenceInfoAsync(out uint asyncId, IntPtr pNgsFacade, ulong principalId, List<ushort> persistenceSlotIds, int timeOut = 0, [Optional] GetPersistenceInfoListCB callback)
	{
		return default(bool);
	}

	public static bool PerpetuateObjectAsync(out uint asyncId, IntPtr pNgsFacade, ushort persistenceSlotId, ulong dataId, bool deleteLastObject = true, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool UnperpetuateObjectAsync(out uint asyncId, IntPtr pNgsFacade, ushort persistenceSlotId, bool deleteLastObject = false, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool GetPasswordInfoAsync(out uint asyncId, IntPtr pNgsFacade, ulong dataId, int timeOut = 0, [Optional] GetPasswordInfoCB callback)
	{
		return default(bool);
	}

	public static bool GetPasswordInfoAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> dataIds, int timeOut = 0, [Optional] GetPasswordInfoListCB callback)
	{
		return default(bool);
	}

	public static extern bool SetHttpThreadPriority(uint priority);

	public static extern bool GetHttpThreadPriority(ref uint priority);

	public static extern bool SetRelayBufferSize(uint relayBufferSize);

	public static extern bool GetRelayBufferSize(ref uint relayBufferSize);

	public static extern bool SetHttpBufferSize(uint httpBufferSize);

	public static extern bool GetHttpBufferSize(ref uint httpBufferSize);

	public static extern bool SetDataTransferTimeout(uint timeoutBytesPerSecond, int minimumTimeoutMilliSecond);

	public static extern bool SetHttpSendSocketBufferSize(uint size);

	public static extern bool GetHttpSendSocketBufferSize(ref uint size);

	public static extern bool SetHttpRecvSocketBufferSize(uint size);

	public static extern bool GetHttpRecvSocketBufferSize(ref uint size);
}
