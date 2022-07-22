using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Dpr.NetworkUtils;
using INL1;
using UnityEngine;

namespace Dpr.UI;

public class GiftNetworkController : MonoBehaviour
{
	private const ushort FailedDataNoValue = ushort.MaxValue;

	private List<ushort> checkDataNoList;

	private byte[] fileDataBytes;

	private List<byte[]> giftDataByteList;

	private Action<int, ushort> onCompleteCheckSerial;

	private Action<byte[][]> onCompleteGetGiftListItemInfos;

	private bool isCheckSerialCodeRequested;

	public int ProgressCount
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void CallInternetGo(Action<bool, SessionErrorType> onFinishedInternetGo)
	{
	}

	public bool IsConnect()
	{
		return default(bool);
	}

	public void CheckSerialRequest(string serialCode, Action<int, ushort> onComplete)
	{
	}

	private void SerialServerCallback(bool isSuccess, IlcaNetServerCallbackEventType eve, IlcaNetServerCallbackResult serverResult, long responseCode, string responseStr)
	{
	}

	public void UpdateSerialCodeUsed()
	{
	}

	public void GetGiftListItemInfos(ushort[] dataNos, Action<byte[][]> onComplete)
	{
	}

	private void GetGiftListItemInfosCallback(bool isSuccess, IlcaNetServerCallbackEventType eve, IlcaNetServerCallbackResult serverResult, long responseCode, string responseStr)
	{
	}

	private void NextReadFile()
	{
	}
}
