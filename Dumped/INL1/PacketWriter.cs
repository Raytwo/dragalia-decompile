using System.ComponentModel;

namespace INL1;

public class PacketWriter : IlcaNetPacket
{
	~PacketWriter()
	{
	}

	public virtual int RemainBytes()
	{
		return default(int);
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void SendDataMake()
	{
	}

	public virtual int WriteByte(byte a)
	{
		return default(int);
	}

	public virtual int WriteU16(ushort a)
	{
		return default(int);
	}

	public virtual int WriteS16(short a)
	{
		return default(int);
	}

	public virtual int WriteU24(uint a)
	{
		return default(int);
	}

	public virtual int WriteS24(int a)
	{
		return default(int);
	}

	public virtual int WriteU32(uint a)
	{
		return default(int);
	}

	public virtual int WriteS32(int a)
	{
		return default(int);
	}

	public virtual int WriteU64(ulong a)
	{
		return default(int);
	}

	public virtual int WriteS64(long a)
	{
		return default(int);
	}

	public virtual int WriteFP16(float a)
	{
		return default(int);
	}

	public virtual int WriteFP24(float a)
	{
		return default(int);
	}

	public virtual int WriteFP32(float a)
	{
		return default(int);
	}

	public virtual int WriteFP64(double a)
	{
		return default(int);
	}

	public virtual int WriteObject(object a)
	{
		return default(int);
	}

	public virtual int WriteBytes(byte[] a)
	{
		return default(int);
	}

	public virtual int WriteBytes(byte[] a, ushort index, ushort size)
	{
		return default(int);
	}

	public unsafe virtual int WriteBytes(byte* a, ushort index, ushort size)
	{
		return default(int);
	}
}
