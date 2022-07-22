using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[DefaultExecutionOrder(0)]
public class AkAudioListener : MonoBehaviour
{
	public class BaseListenerList
	{
		private readonly List<ulong> listenerIdList;

		private readonly List<AkAudioListener> listenerList;

		public List<AkAudioListener> ListenerList => null;

		public virtual bool Add(AkAudioListener listener)
		{
			return default(bool);
		}

		public virtual bool Remove(AkAudioListener listener)
		{
			return default(bool);
		}

		public ulong[] GetListenerIds()
		{
			return null;
		}
	}

	public class DefaultListenerList : BaseListenerList
	{
		public override bool Add(AkAudioListener listener)
		{
			return default(bool);
		}

		public override bool Remove(AkAudioListener listener)
		{
			return default(bool);
		}
	}

	private static readonly DefaultListenerList defaultListeners;

	private ulong akGameObjectID;

	private List<AkGameObj> EmittersToStartListeningTo;

	private List<AkGameObj> EmittersToStopListeningTo;

	public bool isDefaultListener;

	[SerializeField]
	public int listenerId;

	public static DefaultListenerList DefaultListeners => null;

	public void StartListeningToEmitter(AkGameObj emitter)
	{
	}

	public void StopListeningToEmitter(AkGameObj emitter)
	{
	}

	public void SetIsDefaultListener(bool isDefault)
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public ulong GetAkGameObjectID()
	{
		return default(ulong);
	}

	public void Migrate14()
	{
	}
}
