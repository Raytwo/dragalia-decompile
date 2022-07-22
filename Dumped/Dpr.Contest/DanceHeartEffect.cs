using System;
using DG.Tweening;
using Effect;
using UnityEngine;

namespace Dpr.Contest;

public class DanceHeartEffect : MonoBehaviour
{
	private EffectManager fxManagerPtr;

	private EffectData heartFxData;

	private EffectInstance fxInst;

	private Ease easeTypeID;

	private Transform effectTransform;

	private Transform fxInstTransform;

	private Transform fxManagerTransform;

	private Vector3 startPoint;

	private Vector3 pointA;

	private Vector3 pointB;

	private Vector3 goalPoint;

	private float timer;

	private float duration;

	private Action onComplete;

	private bool active;

	private bool isPlayerHeart;

	public bool IsActive => default(bool);

	public void Initialize()
	{
	}

	public void SetNormalHeartFxData(EffectData fxData)
	{
	}

	public void SetLargeHeartFxData(EffectData fxData)
	{
	}

	public void OnFinalize()
	{
	}

	public void Create()
	{
	}

	private bool CheckHeartFxInst()
	{
		return default(bool);
	}

	public void OnUpdate(float deltaTime)
	{
	}

	public void PerformEmitPlayerHeart(float duration, Ease easeType, Action onComplete, Vector3[] points)
	{
	}

	private void OnPlayerHeartUpdate(float deltaTime)
	{
	}

	private void UpdatePosition()
	{
	}

	public void PerformEmitNPCHeart(float duration, Ease easeType, Action onComplete, Vector3 from, Vector3 to)
	{
	}

	private void OnNPCHeartUpdate(float deltaTime)
	{
	}

	private void FinishFx()
	{
	}

	public void Stop()
	{
	}

	private void SetGoActive(bool active)
	{
	}
}
