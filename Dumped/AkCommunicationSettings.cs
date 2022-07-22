using System;

public class AkCommunicationSettings : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public AkThreadProperties commsThreadProperties
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public uint uPoolSize
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public ushort uDiscoveryBroadcastPort
	{
		get
		{
			return default(ushort);
		}
		set
		{
		}
	}

	public ushort uCommandPort
	{
		get
		{
			return default(ushort);
		}
		set
		{
		}
	}

	public ushort uNotificationPort
	{
		get
		{
			return default(ushort);
		}
		set
		{
		}
	}

	public bool bInitSystemLib
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public string szAppNetworkName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal AkCommunicationSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkCommunicationSettings obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkCommunicationSettings()
	{
	}

	public virtual void Dispose()
	{
	}

	public AkCommunicationSettings()
	{
	}
}
