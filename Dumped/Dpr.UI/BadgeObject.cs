using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DPData;
using Effect;
using UnityEngine;

namespace Dpr.UI;

public class BadgeObject
{
	private int id;

	private GameObject gameObject;

	private Transform nodeTransform;

	private BadgeCondition currentBadgeCondition;

	private EffectInstance conditionEffect;

	private int polishedCount;

	private int needCleanupCount;

	private byte cleanupValue;

	public bool IsVisible
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

	public bool IsAutoRotate
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

	public BadgeObject(int id, GameObject gameObject, Transform transform)
	{
	}

	public void Dispose()
	{
	}

	public Transform GetTransform()
	{
		return null;
	}

	public void SetActive(bool isActive)
	{
	}

	public void Polish()
	{
	}

	public void Hit()
	{
	}

	public Vector3 GetPosition()
	{
		return default(Vector3);
	}

	public void SetPosition(Vector3 pos)
	{
	}

	public Quaternion GetRotation()
	{
		return default(Quaternion);
	}

	public void SetRotation(Quaternion quaternion)
	{
	}

	public void RotateY(float value)
	{
	}

	public void StartAutoRotate(float duration)
	{
	}

	public void StopAutoRotate()
	{
	}

	public void PlayConditionEffect()
	{
	}

	public void StopConditionEffect()
	{
	}

	private void UpdateCondition(bool isForce = false)
	{
	}

	private void PlayEffect(int effectID, Transform parent, [Optional] Action<EffectInstance> onLoaded)
	{
	}
}
