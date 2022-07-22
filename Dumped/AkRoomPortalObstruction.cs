using System.Collections.Generic;

public class AkRoomPortalObstruction : AkObstructionOcclusion
{
	private AkRoomPortal m_portal;

	private void Awake()
	{
	}

	protected override void UpdateCurrentListenerList()
	{
	}

	protected override void SetObstructionOcclusion(KeyValuePair<AkAudioListener, ObstructionOcclusionValue> ObsOccPair)
	{
	}
}
