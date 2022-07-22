using System.Collections;
using UnityEngine;

namespace INL1;

public class IlcaNetServerDataStoreService
{
	public delegate void IlcaNetServerDataStoreServiceGMStationTradeCallback(bool isSuccess, GMstationTradeStatusEnum result, bool playerCoreDataDelete);

	public enum GMstationTradeStatusEnum
	{
		SUCCESS = 0,
		ERROR = 10,
		ERROR_CALL = 11,
		ERROR_SERVER = 12,
		ERROR_SIGNATURE = 13,
		ERROR_EMPTY = 14
	}

	private const int PokeCoreSize = 328;

	private static bool GMStationTrading;

	private static bool GMStationErrorSimulateFlag;

	private static byte[] downCoreBinary;

	private static byte[] downSignatureBinary;

	private static ushort recvPoint;

	public static bool GMStationTrade(MonoBehaviour callobj, int targetPoint, IlcaNetServerValidate.CheckRequest cReq, byte[] upSignatureBinary, IlcaNetServerDataStoreServiceGMStationTradeCallback userCallback, bool errorOn = false)
	{
		return default(bool);
	}

	private static IEnumerator GMStationTradeCore(int targetPoint, IlcaNetServerValidate.CheckRequest cReq, byte[] upSignatureBinary, IlcaNetServerDataStoreServiceGMStationTradeCallback userCallback)
	{
		return null;
	}

	public static bool GMStationTradeCoreDataInstanceGet(byte[] downloadCoreData)
	{
		return default(bool);
	}

	public static bool GMStationTradeCoreDataInstanceGet(byte[] downloadCoreData, ref ushort point)
	{
		return default(bool);
	}
}
