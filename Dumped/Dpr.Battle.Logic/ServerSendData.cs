using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public static class ServerSendData
{
	public struct CLIENT_LIMIT_TIME
	{
		public _003ClimitTime_003Ee__FixedBuffer limitTime;
	}

	public struct CONFIRM_COUNTER_POKECHANGE
	{
		public byte enemyPutPokeID;
	}

	public struct POKECHANGE_REQUEST
	{
		public byte requestPosNum;

		public _003CrequestPos_003Ee__FixedBuffer requestPos;
	}

	public struct RAIDBOSS_CAPTURE_RESULT
	{
		public _003CisThrow_003Ee__FixedBuffer isThrow;

		public _003Citemno_003Ee__FixedBuffer itemno;

		public _003CisCaptured_003Ee__FixedBuffer isCaptured;

		public _003CyureCount_003Ee__FixedBuffer yureCount;
	}

	public static void CLIENT_LIMIT_TIME_Copy(ref CLIENT_LIMIT_TIME dest, [In] ref CLIENT_LIMIT_TIME src)
	{
	}

	public static void RAIDBOSS_CAPTURE_RESULT_Copy(ref RAIDBOSS_CAPTURE_RESULT dest, [In] ref RAIDBOSS_CAPTURE_RESULT src)
	{
	}
}
