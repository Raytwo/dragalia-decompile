using System;
using System.Collections;
using System.Runtime.InteropServices;
using INL1;
using UnityEngine;

namespace Dpr.NetworkUtils;

public class SessionConnector
{
	private readonly uint[] DEFAULT_ATTRIBUTE_VALUE;

	private Action<StartSessionResult> onCompleteStartSession;

	private Action<SessionEventData> onSessionEvent;

	private Action<SessionErrorType> onSessionError;

	private Action onFinishSession;

	private StartSessionResult sessionResult;

	private SessionEventData sessionEventData;

	private IlcaNetSessionSetting sessionSetting;

	private IlcaNetSessionState nowSessionState;

	private MonoBehaviour callObjPtr;

	private bool bRunningSession;

	private bool canCallOnFinishedSession;

	public bool IsConnect => default(bool);

	public bool IsDisconnect => default(bool);

	public bool IsRunning => default(bool);

	public IlcaNetSessionState SessionState => default(IlcaNetSessionState);

	public bool IsSessionWait => default(bool);

	public IlcaNetSessionNetworkType NetworkType => default(IlcaNetSessionNetworkType);

	public void Initialize(MonoBehaviour callObj, Action<SessionEventData> onSessionEvent, Action<SessionErrorType> onSessionError, Action onFinishedSession)
	{
	}

	public void OnDestroy()
	{
	}

	public void ClearNetSetting()
	{
	}

	private void ResetParam()
	{
	}

	public void SetCallOnFinishedSessionFlag(bool flag)
	{
	}

	public void StartSession(NetworkParam networkParam, [Optional] Action<StartSessionResult> onCompleteStartSession)
	{
	}

	private bool CanPerformStartSession()
	{
		return default(bool);
	}

	public void JoinRandomSession([Optional] Action<StartSessionResult> onSessionEventCallback)
	{
	}

	private bool CheckJoinSession()
	{
		return default(bool);
	}

	public void SessionRestartRequestAsync([Optional] uint[] attributeValueArray, [Optional] uint[] attributeMinValueArray, [Optional] uint[] attributeMaxValueArray)
	{
	}

	private void SetSessionAttribute(uint[] attributeValueArray, uint[] attributeMinValueArray, uint[] attributeMaxValueArray)
	{
	}

	private bool CheckValidAttributeArray(uint[] value)
	{
		return default(bool);
	}

	public bool LeaveSession()
	{
		return default(bool);
	}

	public bool FinishSession()
	{
		return default(bool);
	}

	public uint GetSessionListSize()
	{
		return default(uint);
	}

	public void RefreshSessionList(Action<bool> onCompleteSearch)
	{
	}

	private IEnumerator IE_SearchSessionList(Action<bool> onCompleteSearch)
	{
		return null;
	}

	public IlcaNetSessionProperty GetSessionProperty(uint index)
	{
		return null;
	}

	public IlcaNetSessionProperty[] GetAllSessionProperty()
	{
		return null;
	}

	private bool CheckSessionStateWait()
	{
		return default(bool);
	}

	private bool CheckProcessing()
	{
		return default(bool);
	}

	public int SendTo(PacketWriter pw, IlcaNetPacketType sendType, int sendStationIndex, TransportType transportType = TransportType.Station)
	{
		return default(int);
	}

	public int SendAll(PacketWriter pw, IlcaNetPacketType sendType, TransportType transportType = TransportType.Station)
	{
		return default(int);
	}

	public void OnUpdate()
	{
	}

	private void OnChangeSessionState()
	{
	}

	private void OnChangeState_SS_MatchingWait()
	{
	}

	private void OnChangeState_SS_GamingFront()
	{
	}

	private void OnChangeState_SS_Gaming()
	{
	}

	private void OnChangeState_SS_GamingLeave()
	{
	}

	private void OnChangeState_SS_GamingError()
	{
	}

	private void OnChangeState_SS_Crash()
	{
	}

	private void OnChangeState_SS_Final()
	{
	}

	public void OnLateUpdate()
	{
	}

	private void CallCompleteStartSession(bool isSuccess, SessionErrorType errorType)
	{
	}

	private void OnSessionEventCallback(IlcaNetSessionEventCallbackType callbackType, int stationIndex)
	{
	}

	private bool CheckMySessionEvent(int statinIndex)
	{
		return default(bool);
	}

	protected virtual void OnSessionFinalCallback()
	{
	}

	public IlcaNetTransport GetTransport(TransportType transportType, int _stationIndex = -1)
	{
		return null;
	}
}
