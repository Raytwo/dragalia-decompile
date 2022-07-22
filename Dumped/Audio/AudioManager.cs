using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using SmartPoint.AssetAssistant;
using UnityEngine;
using UnityEngine.Events;

namespace Audio;

public class AudioManager : SingletonMonoBehaviour<AudioManager>
{
	public enum ListenerType
	{
		Bgm,
		Se,
		Voice
	}

	public enum VolumeType
	{
		Config,
		Normal
	}

	private class ListenerParam
	{
		public AkAudioListener _listener;

		public float[] _volumes;

		public bool _isMute;

		public uint _volumeParamId;

		public float GetVolume()
		{
			return default(float);
		}
	}

	private enum PoolType
	{
		Se = 1,
		Voice
	}

	public struct LoadParam
	{
		public string bankName;
	}

	[SerializeField]
	private GameObject _prefab;

	[SerializeField]
	private int[] _poolCounts;

	[SerializeField]
	private Transform _listenerRoot;

	[SerializeField]
	private string _commonBankName;

	[SerializeField]
	private VoiceRTPC _voiceRtpc;

	private List<ListenerParam> _listenerParams;

	private List<AudioInstance> _audioInstances;

	private ObjectPool<PoolType, AudioInstance> _objectPool;

	private HashSet<AudioData> _audioDatas;

	private uint _eventId;

	private uint _bgmPlayId;

	private bool _isUpdateListenerCamera;

	private float _duration;

	public UnityAction<uint> onFinishBgm;

	private int _configVoice;

	private const uint STOP_DEFAULT_SE = 0u;

	private const uint STOP_DEFAULT_VOICE = 0u;

	public float duration => default(float);

	private void OnDestroy()
	{
	}

	private IEnumerator Start()
	{
		return null;
	}

	private void OnSettingValueChanged(ConfigID configId, int value)
	{
	}

	public float GetVolume(ListenerType type, VolumeType volumeType = VolumeType.Normal)
	{
		return default(float);
	}

	public void SetVolume(ListenerType type, float volume, VolumeType volumeType = VolumeType.Normal)
	{
	}

	private void SetVolumeInternal(ListenerType type)
	{
	}

	internal void _SetInstanceVolume(AudioInstance instance)
	{
	}

	public bool IsMute(ListenerType type)
	{
		return default(bool);
	}

	public void EnableMute(ListenerType type, bool isMute)
	{
	}

	public void Load(LoadParam loadParam, UnityAction<AudioData> onLoaded)
	{
	}

	private IEnumerator OpWaitLoad(AudioData audioData, UnityAction<AudioData> onLoaded)
	{
		return null;
	}

	internal static void _Unload(AudioData audioData)
	{
	}

	public AudioData FindAudioData(string bankName)
	{
		return null;
	}

	public AudioData FindAudioData(uint bankId)
	{
		return null;
	}

	public void PlayBgm()
	{
	}

	public void StopBgm()
	{
	}

	public void SetBgmEvent(string eventName, bool isThroughSameEvent = false)
	{
	}

	public void SetBgmEvent(uint eventId, bool isThroughSameEvent = false)
	{
	}

	public void SetBgmState(string stateName)
	{
	}

	public uint GetIdByName(string name)
	{
		return default(uint);
	}

	public AudioInstance PlaySe(uint playEventId, [Optional] UnityAction<AudioInstance> onFinished)
	{
		return null;
	}

	public AudioInstance PlaySe(uint playEventId, uint stopEventId, [Optional] UnityAction<AudioInstance> onFinished)
	{
		return null;
	}

	public AudioInstance CreateSe(uint playEventId, uint stopEventId = 0u)
	{
		return null;
	}

	public AudioInstance CreateSe(uint playEventId, uint stopEventId, Vector3 position, Quaternion rotation, [Optional] Transform attachedTransform)
	{
		return null;
	}

	public AudioInstance PlayVoice(uint playEventId, [Optional] UnityAction<AudioInstance> onFinished)
	{
		return null;
	}

	public AudioInstance PlayVoice(uint playEventId, uint stopEventId, Transform t, [Optional] UnityAction<AudioInstance> onFinished)
	{
		return null;
	}

	public AudioInstance PlayVoice(uint playEventId, uint stopEventId, [Optional] UnityAction<AudioInstance> onFinished)
	{
		return null;
	}

	public AudioInstance CreateVoice(uint playEventId, uint stopEventId = 0u)
	{
		return null;
	}

	public AudioInstance CreateVoice(uint playEventId, uint stopEventId, Vector3 position, Quaternion rotation, [Optional] Transform attachedTransform)
	{
		return null;
	}

	private AudioInstance CreateInstance(ListenerType listenerType, uint playEventId, uint stopEventId, Vector3 position, Quaternion rotation, [Optional] Transform attachedTransform)
	{
		return null;
	}

	public uint GetCurrentStateId(uint groupId)
	{
		return default(uint);
	}

	public Vector3 GetListenerPosition()
	{
		return default(Vector3);
	}

	public void SetListenerPosition(Vector3 pos)
	{
	}

	public Quaternion GetListenerRotation()
	{
		return default(Quaternion);
	}

	public void SetListenerRotation(Quaternion rotation)
	{
	}

	public float GetBgmPlayPosition()
	{
		return default(float);
	}

	internal void _RemoveInstance(AudioInstance instance)
	{
	}

	public uint PostEvent(uint eventId, uint callbackFlags = 1048585u, bool isThroughSameEvent = false)
	{
		return default(uint);
	}

	private uint PostEventInternal(uint eventId, uint callbackFlags, bool isThroughSameEvent)
	{
		return default(uint);
	}

	private static void OnPostEvent(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info)
	{
	}

	public uint RePostEvent(uint eventId, uint callbackFlags = 1048585u)
	{
		return default(uint);
	}

	private uint RePostEventInternal(uint eventId, uint callbackFlags)
	{
		return default(uint);
	}

	private void LateUpdate()
	{
	}

	public void EnableUpdateListenerByMainCamera(bool enabled)
	{
	}

	public bool IsEnableUpdateListenerByMainCamera()
	{
		return default(bool);
	}

	private void UpdateListenerByMainCamera()
	{
	}

	public float GetRTPCValue(uint gameParamId)
	{
		return default(float);
	}

	public void SetRTPCValue(uint gameParamId, float value)
	{
	}

	public void CreateVoiceRTPCDatas()
	{
	}
}
