using System;
using System.Runtime.InteropServices;
using Unity.Collections;

namespace Dpr.Battle.Logic;

public sealed class SendData : IDisposable
{
	private unsafe SEND_DATA_BUFFER* m_buffer;

	public SendData(Allocator allocator = Allocator.Persistent)
	{
	}

	public void Dispose()
	{
	}

	public unsafe SEND_DATA_BUFFER* GetBuffer()
	{
		//IL_0002: Expected I, but got O
		return (SEND_DATA_BUFFER*)unchecked((nint)null);
	}

	public void Clear()
	{
	}

	public void CopyFrom([In] ref SendData src)
	{
	}

	public unsafe void Store(ushort serialNumber, ServerSequence serverSeq, ServerRequest serverReq, void* data, uint dataSize)
	{
	}

	public unsafe void Store([In] ref SEND_DATA_BUFFER* buffer)
	{
	}

	public ushort GetSerialNumber()
	{
		return default(ushort);
	}

	public ServerSequence GetServerSequence()
	{
		return default(ServerSequence);
	}

	public ServerRequest GetServerRequest()
	{
		return default(ServerRequest);
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

	public uint GetTotalSize()
	{
		return default(uint);
	}

	public string GetString()
	{
		return null;
	}
}
