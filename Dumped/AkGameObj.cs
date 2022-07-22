using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[DefaultExecutionOrder(0)]
public class AkGameObj : MonoBehaviour
{
	[SerializeField]
	private AkGameObjListenerList m_listeners;

	public bool isEnvironmentAware;

	[SerializeField]
	private bool isStaticObject;

	private Collider m_Collider;

	private AkGameObjEnvironmentData m_envData;

	private AkGameObjPositionData m_posData;

	public AkGameObjPositionOffsetData m_positionOffsetData;

	private bool isRegistered;

	[HideInInspector]
	[SerializeField]
	private AkGameObjPosOffsetData m_posOffsetData;

	private const int AK_NUM_LISTENERS = 8;

	[HideInInspector]
	[SerializeField]
	private int listenerMask;

	public bool IsUsingDefaultListeners => default(bool);

	public List<AkAudioListener> ListenerList => null;

	internal void AddListener(AkAudioListener listener)
	{
	}

	internal void RemoveListener(AkAudioListener listener)
	{
	}

	public AKRESULT Register()
	{
		return default(AKRESULT);
	}

	private void SetPosition()
	{
	}

	private void Awake()
	{
	}

	private void CheckStaticStatus()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public virtual Vector3 GetPosition()
	{
		return default(Vector3);
	}

	public virtual Vector3 GetForward()
	{
		return default(Vector3);
	}

	public virtual Vector3 GetUpward()
	{
		return default(Vector3);
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
