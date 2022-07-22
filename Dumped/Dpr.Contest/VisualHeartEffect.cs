using Effect;
using UnityEngine;

namespace Dpr.Contest;

public class VisualHeartEffect : MonoBehaviour
{
	private static readonly Vector3 INIT_POS;

	private EffectManager fxManagerPtr;

	private EffectData heartFxData;

	private EffectInstance fxInst;

	private Transform effectTransform;

	private Transform fxInstTransform;

	private Transform fxManagerTransform;

	private Vector2 moveSpeed;

	private Vector2 addSpeed;

	private float limitPosY;

	private bool active;

	public bool IsActive => default(bool);

	public void Initialize()
	{
	}

	public void ResetParam()
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

	private void Create()
	{
	}

	public void PerformVisualHeart(Vector2 emitPos, Vector2 speedXRange, Vector2 speedYRange)
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	public void Stop()
	{
	}

	private void SetGoActive(bool active)
	{
	}
}
