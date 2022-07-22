using System.ComponentModel;

namespace INL1;

public class IlcaNetPacket
{
	public const uint SystemHeaderMax = 0u;

	public const uint PayloadMax = 1024u;

	public const uint PayloadMaxUn = 340u;

	public const uint UserDataMax = 1024u;

	public const uint UserDataMaxUn = 340u;

	private uint counte;

	protected uint MyUserDataMax;

	private byte[] systemHeader;

	private byte[] userData;

	private byte[] payload;

	private IlcaNetPacketType packetType;

	~IlcaNetPacket()
	{
	}

	protected virtual void WriteBufferFast(byte a)
	{
	}

	protected virtual int WriteRemaining()
	{
		return default(int);
	}

	protected virtual void ReadBufferFast(ref byte a)
	{
	}

	protected virtual int ReadRemaining(ulong recvSize)
	{
		return default(int);
	}

	public virtual void Reset()
	{
	}

	public virtual uint UserDataSizeNow()
	{
		return default(uint);
	}

	public virtual uint UserDataSizeMax()
	{
		return default(uint);
	}

	protected virtual void PayloadSerialize()
	{
	}

	protected virtual void PayloadDeSerialize(ulong recvByte)
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual byte[] UserDataBuffRef()
	{
		return null;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual byte[] PayloadBuffRef()
	{
		return null;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual uint PayloadBuffSizeNow()
	{
		return default(uint);
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void PacketTypeSet(IlcaNetPacketType type)
	{
	}

	public virtual IlcaNetPacketType PacketTypeGet()
	{
		return default(IlcaNetPacketType);
	}
}
