using System;

[Serializable]
public class AkCommonCommSettings
{
	public uint m_PoolSize;

	public static ushort DefaultDiscoveryBroadcastPort;

	public ushort m_DiscoveryBroadcastPort;

	public ushort m_CommandPort;

	public ushort m_NotificationPort;

	public bool m_InitializeSystemComms;

	public string m_NetworkName;

	public virtual void CopyTo(AkCommunicationSettings settings)
	{
	}

	public virtual void Validate()
	{
	}
}
