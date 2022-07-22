namespace Dpr.Battle.Logic;

public sealed class BTLV_STRPARAM
{
	public ushort strID;

	public byte wait;

	public byte strType;

	public byte argCnt;

	public int[] args;

	public static void Setup(BTLV_STRPARAM sp, BtlStrType strType, ushort strID)
	{
	}

	public static void AddArg(BTLV_STRPARAM sp, int arg)
	{
	}

	public static void SetWait(BTLV_STRPARAM sp, byte wait)
	{
	}
}
