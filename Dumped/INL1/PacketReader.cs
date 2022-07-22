using System.ComponentModel;

namespace INL1;

public class PacketReader : IlcaNetPacket
{
	protected ulong recvByte;

	protected int fromStationIndex;

	~PacketReader()
	{
	}

	public virtual ulong RecvTotalBytes()
	{
		return default(ulong);
	}

	public virtual int FromStationIndex()
	{
		return default(int);
	}

	public virtual int RemainBytes()
	{
		return default(int);
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void RecvTotalBytesSet(uint num)
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void FromStationIndexSet(int stationIndex)
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void RecvDataMake(uint num)
	{
	}

	public virtual int ReadByteOut(out byte a)
	{
		return default(int);
	}

	public virtual int ReadByte(ref byte a)
	{
		return default(int);
	}

	public virtual int ReadU16Out(out ushort a)
	{
		return default(int);
	}

	public virtual int ReadU16(ref ushort a)
	{
		return default(int);
	}

	public virtual int ReadS16Out(out short a)
	{
		return default(int);
	}

	public virtual int ReadS16(ref short a)
	{
		return default(int);
	}

	public virtual int ReadU24Out(out uint a)
	{
		return default(int);
	}

	public virtual int ReadU24(ref uint a)
	{
		return default(int);
	}

	public virtual int ReadS24Out(out int a)
	{
		return default(int);
	}

	public virtual int ReadS24(ref int a)
	{
		return default(int);
	}

	public virtual int ReadU32Out(out uint a)
	{
		return default(int);
	}

	public virtual int ReadU32(ref uint a)
	{
		return default(int);
	}

	public virtual int ReadS32Out(out int a)
	{
		return default(int);
	}

	public virtual int ReadS32(ref int a)
	{
		return default(int);
	}

	public virtual int ReadU64Out(out ulong a)
	{
		return default(int);
	}

	public virtual int ReadU64(ref ulong a)
	{
		return default(int);
	}

	public virtual int ReadS64Out(out long a)
	{
		return default(int);
	}

	public virtual int ReadS64(ref long a)
	{
		return default(int);
	}

	public virtual int ReadFP16Out(out float a)
	{
		return default(int);
	}

	public virtual int ReadFP16(ref float a)
	{
		return default(int);
	}

	public virtual int ReadFP24Out(out float a)
	{
		return default(int);
	}

	public virtual int ReadFP24(ref float a)
	{
		return default(int);
	}

	public virtual int ReadFP32Out(out float a)
	{
		return default(int);
	}

	public virtual int ReadFP32(ref float a)
	{
		return default(int);
	}

	public virtual int ReadFP64Out(out double a)
	{
		return default(int);
	}

	public virtual int ReadFP64(ref double a)
	{
		return default(int);
	}

	public virtual int ReadObjectOut(out object a)
	{
		return default(int);
	}

	public virtual int ReadBytesOut(out byte[] a)
	{
		return default(int);
	}

	public virtual int ReadBytes(ref byte[] a)
	{
		return default(int);
	}

	public virtual int ReadBytes(ref byte[] a, uint index)
	{
		return default(int);
	}

	public unsafe virtual int ReadBytes(byte* a, int a_len, uint index)
	{
		return default(int);
	}
}
