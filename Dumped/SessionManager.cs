using System;
using Dpr.NetworkUtils;
using Dpr.SubContents;
using INL1;

public class SessionManager
{
	private NetDataParser dataParser;

	public Action<INetData> OnReceiveData;

	public Action<SessionEventData> OnSessionEventCallback;

	public Action OnErrorSession;

	public void Init()
	{
	}

	public void Clear()
	{
	}

	public void SetCallBack()
	{
	}

	public void Destroy()
	{
	}

	public void StartSession(MatchingParam param)
	{
	}

	private void OnReceivePacket(PacketReader pr)
	{
	}

	private void OnSessionEvent(SessionEventData data)
	{
	}

	public void OnFinishedSession()
	{
	}
}
