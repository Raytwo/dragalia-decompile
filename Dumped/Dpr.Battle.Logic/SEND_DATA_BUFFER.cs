using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public struct SEND_DATA_BUFFER
{
	public struct Header
	{
		public ushort serialNumber;

		public ushort serverReq;

		public ushort size;

		public ushort serverSeq;
	}

	public const int SEND_BUFFER_SIZE = 10004;

	internal const ushort SEND_DATA_SERIAL_NUMBER_NULL = 0;

	internal const ushort SEND_DATA_SERIAL_NUMBER_MIN = 1;

	public Header header;

	public _003Cdata_003Ee__FixedBuffer data;

	public unsafe static void Clear(SEND_DATA_BUFFER* buf)
	{
	}

	public unsafe static void Copy(SEND_DATA_BUFFER* dest, [In] ref SEND_DATA_BUFFER* src)
	{
	}

	public unsafe static void Store(SEND_DATA_BUFFER* buf, ushort serialNumber, ServerSequence serverSeq, ServerRequest serverReq, void* data, uint dataSize)
	{
	}

	public unsafe static ushort GetSerialNumber([In] ref SEND_DATA_BUFFER* buf)
	{
		return default(ushort);
	}

	public unsafe static ServerSequence GetServerSequence([In] ref SEND_DATA_BUFFER* buf)
	{
		return default(ServerSequence);
	}

	public unsafe static ServerRequest GetServerRequest([In] ref SEND_DATA_BUFFER* buf)
	{
		return default(ServerRequest);
	}

	public unsafe static void* GetData(SEND_DATA_BUFFER* buf)
	{
		//IL_0002: Expected I, but got O
		return (void*)unchecked((nint)null);
	}

	public unsafe static uint GetDataSize([In] ref SEND_DATA_BUFFER* buf)
	{
		return default(uint);
	}

	public unsafe static uint GetTotalSize([In] ref SEND_DATA_BUFFER* buf)
	{
		return default(uint);
	}

	public unsafe static string GetString([In] ref SEND_DATA_BUFFER* buf)
	{
		return null;
	}

	public unsafe static string GetString(void* inData, uint size)
	{
		return null;
	}
}
