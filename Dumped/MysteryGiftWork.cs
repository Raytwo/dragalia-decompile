using DPData;
using DPData.MysteryGift;
using Dpr.Battle.Logic;
using Pml.PokePara;

public static class MysteryGiftWork
{
	public const ushort CheckInternetGiftDataNo = 9999;

	public const long NgCheckSecond = 21600L;

	public const byte InputNgCount = 10;

	public static MysteryGiftSaveData m_mysteryGiftData
	{
		get
		{
			return default(MysteryGiftSaveData);
		}
		set
		{
		}
	}

	public static void AddRecvData(RecvData recvData)
	{
	}

	public static bool IsReceived(ushort deliveryId)
	{
		return default(bool);
	}

	public static bool IsExistRecvData()
	{
		return default(bool);
	}

	public static void SetReceiveFlag(MysteryGiftData giftData)
	{
	}

	public static RecvData[] GetRecvDatas()
	{
		return null;
	}

	public static void ReceiveItemGift(ushort itemId)
	{
	}

	public static void ReceiveDressUpItemGift(uint dressId)
	{
	}

	public static CanReceiveResult CanReceive(MysteryGiftCommonData commonData)
	{
		return default(CanReceiveResult);
	}

	public static void ResetNgCount()
	{
	}

	public static bool IsNgFlagOn()
	{
		return default(bool);
	}

	public static bool IncNgCount()
	{
		return default(bool);
	}

	public static RecvData CreateRecvData(MysteryGiftData data)
	{
		return default(RecvData);
	}

	public static ConvertResult ConvertMysteryGiftData(byte[] dataBytes, out MysteryGiftData mysteryGiftData)
	{
		return default(ConvertResult);
	}

	public static PokemonParam CreatePokemonParam(MysteryGiftPokemonData pokemonData)
	{
		return null;
	}

	public static void DebugOneDayHistory(int addDay = 0)
	{
	}

	public static void ResetReceivedFlag()
	{
	}

	public static void ResetOneDayReceivedDatas()
	{
	}

	private static void SetOnceReceiveFlag(ushort deliveryId)
	{
	}

	private static void SetOneDayReceiveFlag(ushort deliveryId, long timestamp)
	{
	}

	private static bool IsNgTime(long oldTime, long newTime)
	{
		return default(bool);
	}

	private static bool GetGameServerTime(out long timestamp)
	{
		return default(bool);
	}

	private static T ConvertData<T>(byte[] dataBytes, int start)
	{
		return (T)null;
	}

	private static void GetPokemonNameAndLanguage(MysteryGiftPokemonData pokemonData, MyStatus myStatus, out string nickName, out string parentName, out byte nickNameLang)
	{
	}

	private static void ConvertRecvPokemonData(MysteryGiftPokemonData pokemonData, out MonsData monsData)
	{
	}

	private static bool CheckCrc(byte[] data, ushort crc)
	{
		return default(bool);
	}

	private static int CalcCrcValue(byte[] dataBytes)
	{
		return default(int);
	}
}
