using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dpr.Battle.View.Objects;

public abstract class BattleObject : BtlvBehaviour, ITranslationObject
{
	public enum ModelType
	{
		None,
		Trainer,
		Pokemon
	}

	protected Vector3 m_translation;

	protected Vector3 m_translationOffset;

	protected Vector3 m_translationGOffset;

	protected Vector3 m_scale;

	protected Vector3 m_scaleOffset;

	protected Vector3 m_beforeTranslation;

	protected Vector3 m_nodeScaleTranslation;

	protected Vector3 m_nodeRotateTranslation;

	protected Vector3 m_rotVec;

	protected Vector3 m_rotVecOffset;

	protected bool m_isVisible;

	protected bool m_isSubVisible;

	protected bool m_suspendUpdate;

	protected bool m_autoRotate;

	protected bool m_isVisibleCameraHit;

	protected bool m_isSubVisibleCameraHit;

	protected float _animSpeed;

	public int Index
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

	public bool IsEnable
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int Priority
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

	public Vector3 NodeScaleTranslation
	{
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Vector3 NodeRotateTranslation
	{
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	protected void Awake()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected void Initialize()
	{
	}

	protected virtual void InitializeMember()
	{
	}

	public void SetTranslationVec(Vector3 translation)
	{
	}

	public Vector3 GetTranslationVec()
	{
		return default(Vector3);
	}

	public void SetTranslationOffset(Vector3 translation)
	{
	}

	public Vector3 GetTranslationOffset()
	{
		return default(Vector3);
	}

	public void SetScaleVec(Vector3 scale)
	{
	}

	public Vector3 GetScaleVec()
	{
		return default(Vector3);
	}

	public void SetScaleOffset(Vector3 scale)
	{
	}

	public Vector3 GetScaleOffset()
	{
		return default(Vector3);
	}

	public void SetNodeScaleTranslation(Vector3 translation)
	{
	}

	public Vector3 GetNodeScaleTranslation()
	{
		return default(Vector3);
	}

	public void SetNodeRotateTranslation(Vector3 translation)
	{
	}

	public Vector3 GetNodeRotateTranslation()
	{
		return default(Vector3);
	}

	public void SetRotationVec(Vector3 rot)
	{
	}

	public Vector3 GetRotationVec()
	{
		return default(Vector3);
	}

	public void SetRotationVecOffset(Vector3 rot)
	{
	}

	public Vector3 GetRotationVecOffset()
	{
		return default(Vector3);
	}

	public bool IsActive()
	{
		return default(bool);
	}

	public virtual void OnUpdatePreJob(float deltaTime)
	{
	}

	public virtual void OnUpdatePostJob(float deltaTime)
	{
	}

	protected void UpdateSTR()
	{
	}

	public Vector3 GetCalcTranslation()
	{
		return default(Vector3);
	}

	public Vector3 GetCalcScale()
	{
		return default(Vector3);
	}

	public Vector3 GetCalcRot()
	{
		return default(Vector3);
	}
}
