using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[DisallowMultipleComponent]
public class BaseEntity : MonoBehaviour
{
	public class SequenceID
	{
		public const int Initialize = 0;

		protected const int User = 4096;
	}

	[SerializeField]
	private string _enityName;

	private bool _alreadyRegistered;

	[NonSerialized]
	public float yawAngle;

	[NonSerialized]
	public Vector3 worldPosition;

	private float savedYawAngle;

	private Vector3 savedPosition;

	private Transform _cacheTransform;

	public virtual string entityType => null;

	public Vector3 beforePosition
	{
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int currentSequence
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int nextSequence
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float sequenceTime
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string entityEname
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BaseEntity target
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public new Transform transform => null;

	public virtual AnimationPlayer GetAnimationPlayer()
	{
		return null;
	}

	public void Register()
	{
	}

	public void Unregister()
	{
	}

	protected virtual void Awake()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	private void OnEarlyUpdate(float deltaTime)
	{
	}

	protected virtual void OnUpdate(float deltaTime)
	{
	}

	protected virtual void OnLateUpdate(float deltaTime)
	{
	}

	private void OnPostLateUpdate(float deltaTime)
	{
	}

	protected virtual bool SwitchToNext()
	{
		return default(bool);
	}

	protected virtual void ProcessSequence(float deltaTime)
	{
	}

	public void SetPositionDirect(Vector3 pos)
	{
	}

	public void SetYawAngleDirect(float angle)
	{
	}
}
