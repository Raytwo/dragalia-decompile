using System.ComponentModel;

namespace INL1;

public class IlcaNetGamer : IlcaNetTransport
{
	private bool isActive;

	private int myGlobalIndex;

	private int myLocalIndex;

	private bool isHomeGamer;

	public string gamerName;

	public byte nameStringLanguage;

	public int TURNenable;

	~IlcaNetGamer()
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Init()
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Final()
	{
	}

	private void CleanUp()
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void CopyTo(ref IlcaNetGamer dst)
	{
	}

	public bool IsActive()
	{
		return default(bool);
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ActiveON()
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ActiveOFF()
	{
	}

	public bool IsHomeGamer()
	{
		return default(bool);
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void HomeGamerON()
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void HomeGamerOFF()
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void LocalIndexSet(int localindex, int portOffset = 0)
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void GlobalIndexSet(int globalindex)
	{
	}

	public override int Send(PacketWriter pw, IlcaNetPacketType type)
	{
		return default(int);
	}

	public override int SendTo(PacketWriter pw, IlcaNetPacketType type, int stationIndex)
	{
		return default(int);
	}

	public override int Recv(ref PacketReader pr)
	{
		return default(int);
	}
}
