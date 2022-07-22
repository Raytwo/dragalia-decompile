namespace Dpr.Battle.Logic;

public static class rec
{
	public enum FieldType
	{
		BTL_RECFIELD_NULL,
		BTL_RECFIELD_ACTION,
		BTL_RECFIELD_BTLSTART,
		BTL_RECFIELD_TIMEOVER,
		BTL_RECFIELD_SIZEOVER
	}

	public enum Timing
	{
		RECTIMING_None,
		RECTIMING_StartTurn,
		RECTIMING_PokeInCover,
		RECTIMING_PokeInChange,
		RECTIMING_BtlIn,
		RECTIMING_PokeChangeAfterFirstPokeIn
	}

	public enum HeaderIndex
	{
		HEADER_TIMING_CODE,
		HEADER_FIELD_TAG,
		HEADER_SIZE
	}

	public enum RecFieldType
	{
		RECFIELD_NULL,
		RECFIELD_ACTION,
		RECFIELD_BTLSTART,
		RECFIELD_TIMEOVER,
		RECFIELD_SIZEOVER,
		RECFIELD_MAX
	}

	public sealed class Data
	{
		private ushort m_writePtr;

		private bool m_fSizeOver;

		private byte dmy;

		private unsafe byte* m_buf;

		public unsafe void Write(void* data, uint size)
		{
		}

		public unsafe Timing GetTimingCode(void* data)
		{
			return default(Timing);
		}

		public bool IsCorrect()
		{
			return default(bool);
		}

		public unsafe void* GetDataPtr(ref uint size)
		{
			//IL_0002: Expected I, but got O
			return (void*)unchecked((nint)null);
		}
	}

	public sealed class Reader
	{
		private unsafe byte* m_recordData;

		private uint m_dataSize;

		private bool m_fReadOver;

		private uint[] m_readPtr;

		private unsafe byte*[] m_readBuf;

		public void ResetError()
		{
		}

		public void SetDataSize(uint size)
		{
		}

		public unsafe void Init(void* recordData, uint dataSize)
		{
		}

		public void Reset()
		{
		}

		public bool CheckBtlInCmd(byte clientID)
		{
			return default(bool);
		}

		public unsafe BTL_ACTION_PARAM* ReadAction(byte clientID, out byte numAction, out bool fChapter, out bool isBtlInCmd)
		{
			//IL_0002: Expected I, but got O
			return (BTL_ACTION_PARAM*)unchecked((nint)null);
		}

		public uint GetTurnCount()
		{
			return default(uint);
		}

		public bool IsReadComplete(byte clientID)
		{
			return default(bool);
		}
	}

	public sealed class SendTool
	{
		private static readonly int BUFSIZE;

		private byte m_writePtr;

		private byte m_clientBit;

		private byte m_numClients;

		private byte m_type;

		private bool m_fChapter;

		private bool m_fError;

		private unsafe byte* m_buffer;

		public void Init(bool fChapter)
		{
		}

		public unsafe byte* PutBtlInTiming(ref uint dataSize)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		public unsafe byte* PutBtlInChapter(ref uint dataSize, bool fChapter)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		public unsafe void PutSelActionData(byte clientID, BTL_ACTION_PARAM* action, byte numAction)
		{
		}

		public unsafe byte* FixSelActionData(Timing timingCode, ref uint dataSize)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		public unsafe byte* PutTimeOverData(ref uint dataSize)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		public unsafe void RestoreStart(void* data, uint dataSize)
		{
		}

		public unsafe bool RestoreFwd(ref uint rp, out byte clientID, out byte numAction, BTL_ACTION_PARAM* action)
		{
			return default(bool);
		}
	}

	private const int FALSE = 0;

	private const int TRUE = 1;

	public static byte MakeRecFieldTag(RecFieldType type, byte numClient, bool fChapter)
	{
		return default(byte);
	}

	public static void ReadRecFieldTag(byte tagCode, out FieldType type, out byte numClient, out bool fChapter)
	{
	}

	public static byte MakeClientActionTag(byte clientID, byte numAction)
	{
		return default(byte);
	}

	public static void ReadClientActionTag(byte tagCode, out byte clientID, out byte numAction)
	{
	}

	public static byte MakeRecTimingCode(Timing timing, bool isRecordTargetData)
	{
		return default(byte);
	}

	public static void ReadRecTimingCode(byte timingCode, ref Timing timing, ref bool isRecordTargetData)
	{
	}
}
