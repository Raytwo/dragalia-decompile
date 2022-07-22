using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

namespace Audio;

public class AudioInstance : IObjectPoolInstance
{
	[Flags]
	private enum StateBits
	{
		None = 0,
		Created = 1,
		Played = 2,
		Stopped = 4,
		PlayEnded = 8,
		Cleanup = 0x10,
		Cleanedup = 0x20
	}

	private AkGameObj _akGameObj;

	private AudioManager.ListenerType _listenerType;

	private uint _playEventId;

	private uint _stopEventId;

	private Transform _attachedTransform;

	private Vector3 _localPosition;

	private Quaternion _localRotation;

	private UnityAction<AudioInstance> _onFinished;

	private float _volume;

	private uint _playId;

	private float _duration;

	private bool _isDurtyRtpc;

	private bool _isManualRemoved;

	private StateBits _stateBits;

	public AkGameObj akGameObj => null;

	public AudioManager.ListenerType listenerType => default(AudioManager.ListenerType);

	public uint playEventId => default(uint);

	public uint stopEventId => default(uint);

	public uint postEventNumber => default(uint);

	public float duration => default(float);

	internal bool _isCleanup => default(bool);

	void IObjectPoolInstance.SetGameObject(GameObject obj)
	{
	}

	GameObject IObjectPoolInstance.GetGameObject()
	{
		return null;
	}

	void IObjectPoolInstance.OnCreate()
	{
	}

	void IObjectPoolInstance.OnRelease()
	{
	}

	internal void _Setup(AudioManager.ListenerType listenerType, uint playEventId, uint stopEventId, Vector3 position, Quaternion rotation, [Optional] Transform attachedTransform)
	{
	}

	public AudioInstance Play([Optional] UnityAction<AudioInstance> onFinished, bool isManualRemoved = false)
	{
		return null;
	}

	private IEnumerator OpDelayPlayComplete()
	{
		return null;
	}

	private static void OnPostEvent(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info)
	{
	}

	public void PostCleanupEvent(bool isForce = false)
	{
	}

	private void Cleanup()
	{
	}

	public void Stop()
	{
	}

	private static void OnStopComplete(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info)
	{
	}

	public void SetLocalPosition(Vector3 localPos)
	{
	}

	internal void _Update()
	{
	}

	private void UpdateTransform()
	{
	}

	public float GetPlayPosition(bool isExtrapolate = true)
	{
		return default(float);
	}

	public float GetVolume()
	{
		return default(float);
	}

	public void SetVolume(float volume)
	{
	}

	public float GetRTPCValue(uint gameParamId)
	{
		return default(float);
	}

	public void SetRTPCValue(uint gameParamId, float value)
	{
	}

	public uint GetSwitch(uint groupId)
	{
		return default(uint);
	}

	public void SetSwitch(uint groupId, uint state)
	{
	}
}
