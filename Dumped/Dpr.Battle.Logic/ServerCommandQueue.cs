namespace Dpr.Battle.Logic;

public sealed class ServerCommandQueue
{
	public const int MSGARG_MAX_NUM = 9;

	public const ushort INVALID_PTR_VALUE = ushort.MaxValue;

	public const uint QUE_READING_STATE_NULL = uint.MaxValue;

	private uint m_writePtr;

	private uint m_readPtr;

	private unsafe byte* m_buffer;

	internal const byte RESERVE_INFO_SIZE = 3;

	private static readonly ServerCommandArgsFormat[] ServerCmdToFmtTbl;

	private static byte SC_ARGFMT_GetArgCount(ServerCommandArgsFormat format)
	{
		return default(byte);
	}

	public void Initialize()
	{
	}

	public unsafe void Copy(void* data, ushort dataLength)
	{
	}

	public unsafe void* GetData()
	{
		//IL_0002: Expected I, but got O
		return (void*)unchecked((nint)null);
	}

	public uint GetDataSize()
	{
		return default(uint);
	}

	public bool IsContainActCommand(ushort startPos, ushort endPos)
	{
		return default(bool);
	}

	public ServerCommand Read(int[] args, uint argsBufferSize, ref uint cmdReadState)
	{
		return default(ServerCommand);
	}

	public ServerCommand Read(int[] args, uint argsBufferSize)
	{
		return default(ServerCommand);
	}

	public bool IsReadFinished()
	{
		return default(bool);
	}

	public void Put_Common(ServerCommand cmd, int[] LegacyParamArray)
	{
	}

	public void Put_MsgImpl(ServerCommand cmd, int[] inArgs)
	{
	}

	public void Put_WazaSyncChapter()
	{
	}

	public ushort ReservePutPos(ServerCommand cmd)
	{
		return default(ushort);
	}

	public void Put_ToReservedPos(ushort pos, ServerCommand cmd, int[] LegacyParamArray)
	{
	}

	public void Put_ToReservedPos_Msg(ushort pos, ServerCommand cmd, int[] inArgs)
	{
	}

	private void put_reserved_pos_core(ushort pos, ServerCommand cmd, int[] args, uint argsNum)
	{
	}

	public uint PushReadState()
	{
		return default(uint);
	}

	public void PopReadState(uint state)
	{
	}

	public void ReplaceWithSkipCmd(uint pos)
	{
	}

	public void Put_ExArgStart(byte argsNum)
	{
	}

	public void Put_ExArgOnly(byte arg)
	{
	}

	public byte Read_ExArgOnly()
	{
		return default(byte);
	}

	public void Put_ExAssignClient_Start(BTL_CLIENT_ID clientID)
	{
	}

	public void Put_ExAssignClient_End()
	{
	}

	private void put_core(ServerCommand cmd, ServerCommandArgsFormat format, int[] args)
	{
	}

	private void read_core(ServerCommandArgsFormat format, int[] args)
	{
	}

	private void scque_put1byte(byte data)
	{
	}

	private void scque_put2byte(ushort data)
	{
	}

	private void scque_put3byte(uint data)
	{
	}

	private void scque_put4byte(uint data)
	{
	}

	private byte scque_read1byte()
	{
		return default(byte);
	}

	private ushort scque_read2byte()
	{
		return default(ushort);
	}

	private uint scque_read3byte()
	{
		return default(uint);
	}

	private uint scque_read4byte()
	{
		return default(uint);
	}

	private byte pack1_2args(int arg1, int arg2, int bits1, int bits2)
	{
		return default(byte);
	}

	private uint pack_3args(int bytes, int arg1, int arg2, int arg3, int bits1, int bits2, int bits3)
	{
		return default(uint);
	}

	private uint pack_4args(int bytes, int arg1, int arg2, int arg3, int arg4, int bits1, int bits2, int bits3, int bits4)
	{
		return default(uint);
	}

	private uint pack_5args(int bytes, int arg1, int arg2, int arg3, int arg4, int arg5, int bits1, int bits2, int bits3, int bits4, int bits5)
	{
		return default(uint);
	}

	private void unpack1_2args(byte pack, int bits1, int bits2, int[] args, int idx_start)
	{
	}

	private void unpack_3args(int bytes, uint pack, int bits1, int bits2, int bits3, int[] args, int idx_start)
	{
	}

	private void unpack_4args(int bytes, uint pack, int bits1, int bits2, int bits3, int bits4, int[] args, int idx_start)
	{
	}

	private void unpack_5args(int bytes, uint pack, int bits1, int bits2, int bits3, int bits4, int bits5, int[] args, int idx_start)
	{
	}

	private ushort _que_replace_ex_cmd(ServerCommand reserveCmd, ServerCommand replaceCmd, byte exVarCount)
	{
		return default(ushort);
	}

	public ServerCommand scque_readcmd_support_skip(ref uint cmdReadState)
	{
		return default(ServerCommand);
	}
}
