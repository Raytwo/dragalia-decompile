using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using NexAssets;
using NexPlugin;
using UnityEngine;

namespace INL1;

public class IlcaNetServerDataStore : IlcaNetServer
{
	public class PreparePostParam : NexPlugin.DataStorePreparePostParam
	{
	}

	public class SearchParam : NexPlugin.DataStoreSearchParam
	{
	}

	public class PrepareGetParam : DataStorePrepareGetParam
	{
	}

	public class DeleteParam : DataStoreDeleteParam
	{
	}

	public class PrepareUpdateParam : DataStorePrepareUpdateParam
	{
	}

	public class GetMetaParam : DataStoreGetMetaParam
	{
	}

	public class ChangeMetaParam : NexPlugin.DataStoreChangeMetaParam
	{
	}

	public class RateObjectParam : DataStoreRateObjectParam
	{
	}

	public delegate void IlcaNetDataStoreCompleteCallback(bool isSuccess, IlcaNetDataStoreCallbackEventType eve, ulong dataId, DataStoreSearchResult searchResult, byte[] data);

	public delegate void IlcaNetDataStoreCompleteCallback2(bool isSuccess, IlcaNetDataStoreCallbackEventType eve, DataStoreMetaInfo minfo, Dictionary<sbyte, DataStoreRatingInfo> rinfo);

	private static IlcaNetDataStoreCompleteCallback compDataStoreCallback;

	private static IlcaNetDataStoreCompleteCallback2 compDataStoreCallback2;

	private static Stopwatch sp;

	private static TimeSpan span;

	private static MonoBehaviour s_callobj;

	private static DataStore_Upload uploader;

	private static DataStore_Download downloader;

	private static List<DataStoreRatingTarget> directSetRatingList;

	private static RateObjectParam directSetRatingParameter;

	private static ulong directGetRatingParameter;

	private static GetMetaParam directGetMetaParameter;

	private static ChangeMetaParam directChangeMetaParameter;

	private static byte[] dataUpdate;

	private static PrepareUpdateParam directUpdateParameter;

	private static byte[] dataUpload;

	private static PreparePostParam directUploadParameter;

	private static SearchParam directSearchParameter;

	private static ulong dataDownloadID;

	private static uint maxDownloadDataBufferSize;

	private static PrepareGetParam directDownloadParameter;

	private static ulong dataDeleteID;

	private static DeleteParam directDeleteParameter;

	private static IEnumerator UpdateDataStore()
	{
		return null;
	}

	private static void UpdateSetRating()
	{
	}

	public static bool SetRatingAsync(MonoBehaviour callobj, List<DataStoreRatingTarget> targetList, RateObjectParam directSetRatingParameterArg, IlcaNetDataStoreCompleteCallback2 compCallback)
	{
		return default(bool);
	}

	private static bool SetRatingAsync(MonoBehaviour callobj, IlcaNetDataStoreCompleteCallback2 compCallback, List<DataStoreRatingTarget> targetList, RateObjectParam directSetRatingParameterArg)
	{
		return default(bool);
	}

	private static void ErrorFinalSetRatingCallback()
	{
	}

	private static void CompSetRatingCallback(AsyncResult asyncResult, List<DataStoreRatingInfo> info, List<DataStoreResult> resultList)
	{
	}

	private static void UpdateGetRating()
	{
	}

	public static bool GetRatingAsync(MonoBehaviour callobj, ulong directGetRatingParameter, IlcaNetDataStoreCompleteCallback2 compCallback)
	{
		return default(bool);
	}

	private static bool GetRatingAsync(MonoBehaviour callobj, IlcaNetDataStoreCompleteCallback2 compCallback, ulong directGetRatingParameter)
	{
		return default(bool);
	}

	private static void ErrorFinalGetRatingCallback()
	{
	}

	private static void CompGetRatingCallback(AsyncResult asyncResult, Dictionary<sbyte, DataStoreRatingInfo> info)
	{
	}

	private static void UpdateGetMeta()
	{
	}

	public static bool GetMetaAsync(MonoBehaviour callobj, GetMetaParam directGetMetaParameter, IlcaNetDataStoreCompleteCallback2 compCallback)
	{
		return default(bool);
	}

	private static bool GetMetaAsync(MonoBehaviour callobj, IlcaNetDataStoreCompleteCallback2 compCallback, GetMetaParam directGetMetaParameter)
	{
		return default(bool);
	}

	private static void ErrorFinalGetMetaCallback()
	{
	}

	private static void CompGetMetaCallback(AsyncResult asyncResult, DataStoreMetaInfo info)
	{
	}

	private static void UpdateChangeMeta()
	{
	}

	public static bool ChangeMetaAsync(MonoBehaviour callobj, ChangeMetaParam directChangeMetaParameter, IlcaNetDataStoreCompleteCallback2 compCallback)
	{
		return default(bool);
	}

	private static bool ChangeMetaAsync(MonoBehaviour callobj, IlcaNetDataStoreCompleteCallback2 compCallback, ChangeMetaParam directChangeMetaParameter)
	{
		return default(bool);
	}

	private static void ErrorFinalChangeMetaCallback()
	{
	}

	private static void CompChangeMetaCallback(AsyncResult asyncResult)
	{
	}

	private static void UpdateUpdate()
	{
	}

	public static bool UpdateAsync(MonoBehaviour callobj, byte[] data, PrepareUpdateParam directUpdataParameter, IlcaNetDataStoreCompleteCallback compCallback)
	{
		return default(bool);
	}

	private static bool UpdateAsync(MonoBehaviour callobj, byte[] data, IlcaNetDataStoreCompleteCallback compCallback, PrepareUpdateParam directUpdateParameter)
	{
		return default(bool);
	}

	private static void ErrorFinalUpdateCallback()
	{
	}

	private static void CompUpdateCallback(AsyncResult asyncResult)
	{
	}

	private static void UpdateUpload()
	{
	}

	public static bool UploadAsync(MonoBehaviour callobj, byte[] data, PreparePostParam directUploadParameter, IlcaNetDataStoreCompleteCallback compCallback)
	{
		return default(bool);
	}

	private static bool UploadAsync(MonoBehaviour callobj, byte[] data, IlcaNetDataStoreCompleteCallback compCallback, PreparePostParam directUploadParameter)
	{
		return default(bool);
	}

	private static void ErrorFinalUploadCallback()
	{
	}

	private static void CompUploadCallback(AsyncResult asyncResult, ulong dataId)
	{
	}

	private static void UpdateSearch()
	{
	}

	public static bool SearchAsync(MonoBehaviour callobj, SearchParam directSearchParameter, IlcaNetDataStoreCompleteCallback compCallback)
	{
		return default(bool);
	}

	private static bool SearchAsync(MonoBehaviour callobj, IlcaNetDataStoreCompleteCallback compCallback, SearchParam directSearchParameter)
	{
		return default(bool);
	}

	private static void ErrorFinalSearceCallback()
	{
	}

	private static void CompSearchCallback(AsyncResult asyncResult, DataStoreSearchResult searchResult)
	{
	}

	private static void UpdateDownload()
	{
	}

	public static bool DownloadAsync(MonoBehaviour callobj, PrepareGetParam directDownloadParameter, uint dataBufferSize, IlcaNetDataStoreCompleteCallback compCallback)
	{
		return default(bool);
	}

	private static bool DownloadAsync(MonoBehaviour callobj, ulong dataID, uint dataBufferSize, IlcaNetDataStoreCompleteCallback compCallback, PrepareGetParam directDownloadParameter)
	{
		return default(bool);
	}

	private static void ErrorFinalDownloadCallback()
	{
	}

	private static void CompDownloadCallback(AsyncResult asyncResult, byte[] buf)
	{
	}

	private static void UpdatetDelete()
	{
	}

	public static bool DeleteAsync(MonoBehaviour callobj, DeleteParam directDeleteParameter, IlcaNetDataStoreCompleteCallback compCallback)
	{
		return default(bool);
	}

	private static bool DeleteAsync(MonoBehaviour callobj, ulong dataID, IlcaNetDataStoreCompleteCallback compCallback, DeleteParam directDeleteParameter)
	{
		return default(bool);
	}

	private static void ErrorFinalDeleteCallback()
	{
	}

	private static void CompDeleteCallback(AsyncResult asyncResult)
	{
	}
}
