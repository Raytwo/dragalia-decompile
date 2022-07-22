using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public class ClientSendData
{
	public struct ACTION_SELECT
	{
		public byte actionNum;

		public byte pad_0;

		public byte pad_1;

		public byte pad_2;

		public byte pad_3;

		public byte pad_4;

		public byte pad_5;

		public byte pad_6;

		public _003CactionParam_003Ee__FixedBuffer actionParam;

		public const int ACTIONPARAM_NUM = 10;
	}

	public struct CLIENT_LIMIT_TIME
	{
		public ushort limitTime;
	}

	public struct RAID_BALL_SELECT
	{
		public bool isThrow;

		public ushort itemID;

		public void CopyFrom(RAID_BALL_SELECT src)
		{
		}
	}

	public static void Copy(ref RAID_BALL_SELECT pDest, [In] ref RAID_BALL_SELECT src)
	{
	}
}
