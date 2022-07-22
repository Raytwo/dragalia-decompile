using System.Collections.Generic;
using UnityEngine;

namespace NexAssets;

public class DataStore_Core : Common
{
	protected enum Functions
	{
		SearchObject,
		GetObject,
		PostObject,
		PostObject2,
		PostObject4,
		PostObject5,
		UpdateObject,
		GetRating,
		GetRatings,
		GetRatingWithLog,
		CompleteSuspendedPostObject,
		DeleteObject,
		DeleteObjects,
		ChangeMeta,
		ChangeMetas,
		GetMeta,
		GetMetas,
		GetMetasParam,
		RateObject,
		RateObjects,
		RateObjectWithPosting,
		RateObjectsWithPosting,
		ResetRating,
		ResetRatings,
		TouchObject,
		GetPersistenceInfo,
		GetPersistenceInfos,
		PerpetuateObject,
		UnperpetuateObject,
		GetPasswordInfo,
		GetPasswordInfos,
		SearchObjectLight
	}

	[SerializeField]
	private DataStoreBaseParam dataStoreBaseParam;

	private static Dictionary<int, FunctionInfo> FunctionInfos;

	private static List<ApiCallsFrequency> s_ApiCallsFrequencyList;

	public uint GetHttpThreadPrioritySetting()
	{
		return default(uint);
	}

	public uint GetHttpBufferSizeSetting()
	{
		return default(uint);
	}

	public uint GetTimeoutBytesPerSecondSetting()
	{
		return default(uint);
	}

	public int GetMinimumTimeoutMilliSecondSetting()
	{
		return default(int);
	}

	public uint GetHttpSendSocketBufferSizeSetting()
	{
		return default(uint);
	}

	public uint GetHttpRecvSocketBufferSizeSetting()
	{
		return default(uint);
	}

	public bool SetHttpThreadPriority()
	{
		return default(bool);
	}

	public bool SetHttpThreadPriority(uint priority)
	{
		return default(bool);
	}

	public bool GetHttpThreadPriority(ref uint priority)
	{
		return default(bool);
	}

	public bool SetHttpBufferSize()
	{
		return default(bool);
	}

	public bool SetHttpBufferSize(uint bufferSize)
	{
		return default(bool);
	}

	public bool GetHttpBufferSize(ref uint bufferSize)
	{
		return default(bool);
	}

	public bool SetDataTransferTimeout()
	{
		return default(bool);
	}

	public bool SetDataTransferTimeout(uint timeoutBytesPerSecond, int minimumTimeoutMilliSecond)
	{
		return default(bool);
	}

	public bool SetHttpSendSocketBufferSize()
	{
		return default(bool);
	}

	public bool SetHttpSendSocketBufferSize(uint size)
	{
		return default(bool);
	}

	public bool GetHttpSendSocketBufferSize(ref uint size)
	{
		return default(bool);
	}

	public bool SetHttpRecvSocketBufferSize()
	{
		return default(bool);
	}

	public bool SetHttpRecvSocketBufferSize(uint size)
	{
		return default(bool);
	}

	public bool GetHttpRecvSocketBufferSize(ref uint size)
	{
		return default(bool);
	}

	protected bool ApiCallsFrequencyCheck(int type)
	{
		return default(bool);
	}
}
