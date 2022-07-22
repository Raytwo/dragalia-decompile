using System;
using Dpr.Battle.Logic;
using UnityEngine;

namespace Dpr.Battle.View.Objects;

public class BattleViewCharacter : BattleObject
{
	public enum HappyType
	{
		NONE,
		TYPE_A,
		TYPE_B
	}

	public enum ShaderType
	{
		Normal,
		GShader,
		Count
	}

	public enum FixParamType
	{
		TYPE_VECTOR,
		TYPE_FLOAT,
		TYPE_BOOL
	}

	protected const float DEFAULT_ADJUST_HEIGHT = 1f;

	protected BtlvPos m_vPos;

	protected ModelType m_type;

	protected bool _isSickSpeedSuspend;

	protected float m_adjustHeight;

	protected float m_cameraAdjustHeight;

	protected bool m_disableSleepEye;

	protected bool _isEnableWaitB;

	protected int _waitBCheckCnt;

	public bool IsGJoker => default(bool);

	public bool IsVisible
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool IsFinishDelete => default(bool);

	public virtual void Initialize(BtlvPos vPos)
	{
	}

	protected override void InitializeMember()
	{
	}

	public virtual void SetRenderActive(bool isActive)
	{
	}

	public void SetVisible(bool value)
	{
	}

	protected virtual void UpdateVisible()
	{
	}

	public virtual void SetVisibleShadow(bool value)
	{
	}

	public void ResetAnimState()
	{
	}

	public void SetEnableWaitB(bool value)
	{
	}

	private void UpdateWaitB()
	{
	}

	[Obsolete]
	public virtual void ChangeAnimState(string parameterName, bool isReset = false)
	{
	}

	public void ChangeAnimStateBool(string parameterName, bool value)
	{
	}

	public void ChangeAnimStateInt(string parameterName, int vlaue)
	{
	}

	public void SetAnimSpeed(float speed)
	{
	}

	public float GetAnimSpeed()
	{
		return default(float);
	}

	protected virtual void UpdateAnimSpeed()
	{
	}

	public void StartLookAt(Vector3 pos)
	{
	}

	public void EndLookAt()
	{
	}

	public virtual void StartDelete()
	{
	}

	public virtual void AttachObject(GameObject obj, string nodeName, bool isFollowPos, bool isFollowRot, bool isFollowScl, bool isFollowAnimScl, bool isFollowLocalScl)
	{
	}

	public void DetachObject(GameObject obj)
	{
	}

	public override void OnUpdatePreJob(float deltaTime)
	{
	}
}
