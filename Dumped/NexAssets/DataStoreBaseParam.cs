using System;
using UnityEngine;

namespace NexAssets;

[Serializable]
public class DataStoreBaseParam
{
	[SerializeField]
	private uint httpThreadPriority;

	[SerializeField]
	private uint httpBufferSize;

	[SerializeField]
	private uint timeoutBytesPerSecond;

	[SerializeField]
	private int minimumTimeoutMilliSecond;

	[SerializeField]
	private uint httpSendSocketBufferSize;

	[SerializeField]
	private uint httpRecvSocketBufferSize;

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
}
