using System;
using System.Collections.Generic;
using AK.Wwise;
using UnityEngine;

public class AkEvent : AkDragDropTriggerHandler
{
	[Serializable]
	public class CallbackData
	{
		public CallbackFlags Flags;

		public string FunctionName;

		public GameObject GameObject;

		public void CallFunction(AkEventCallbackMsg eventCallbackMsg)
		{
		}
	}

	public AkActionOnEventType actionOnEventType;

	public AkCurveInterpolation curveInterpolation;

	public bool enableActionOnEvent;

	public AK.Wwise.Event data;

	public bool useCallbacks;

	public List<CallbackData> Callbacks;

	public uint playingId;

	public GameObject soundEmitterObject;

	public float transitionDuration;

	private AkEventCallbackMsg EventCallbackMsg;

	[HideInInspector]
	[SerializeField]
	private int eventIdInternal;

	[HideInInspector]
	[SerializeField]
	private byte[] valueGuidInternal;

	[HideInInspector]
	[SerializeField]
	private AkEventCallbackData m_callbackDataInternal;

	protected override BaseType WwiseType => null;

	[Obsolete]
	public int eventID => default(int);

	[Obsolete]
	public byte[] valueGuid => null;

	[Obsolete]
	public AkEventCallbackData m_callbackData => null;

	protected override void Start()
	{
	}

	private void Callback(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info)
	{
	}

	public override void HandleEvent(GameObject in_gameObject)
	{
	}

	public void Stop(int _transitionDuration)
	{
	}

	public void Stop(int _transitionDuration, AkCurveInterpolation _curveInterpolation)
	{
	}
}
