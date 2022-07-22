using System;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;

namespace Dpr.GMS;

public class GMSCamera : MonoBehaviour
{
	[SerializeField]
	private Camera mainCamera;

	private Action onStopMove;

	private GMSCameraConfig cameraConfig;

	private Tween distanceTween;

	private Tween rotTween;

	private Transform cameraTransform;

	private Quaternion cameraRot;

	private Quaternion nextCameraRot;

	private Quaternion currentCameraRot;

	private Vector3 cameraPosNormal;

	private Vector3 goalPointNormal;

	private Vector3 addAngleAxis;

	private CameraMode currentMode;

	private float nowDistance;

	private float distanceRange;

	private float rotTweenRatio;

	private float addAngle;

	private int distanceLevel;

	private bool bIsMovePosition;

	private bool bLockOperation;

	private bool isRunningDistanceTween;

	private bool isRunningRotTween;

	[SerializeField]
	private float rotSpeed;

	private readonly Vector3 LOOK_AT_UP;

	public bool IsMoving => default(bool);

	public bool RunningDistanceTween => default(bool);

	public Vector3 CameraPosition => default(Vector3);

	public void Initialize(Action onStopMove)
	{
	}

	public void SetCameraConfig(GMSCameraConfig cameraConfig)
	{
	}

	public void Setup(RenderTexture renderTexture)
	{
	}

	public void OnFinalize()
	{
	}

	private void KillDistanceTween()
	{
	}

	private void KillRotTween()
	{
	}

	public void ChangeCameraMode(CameraMode mode)
	{
	}

	public void LockMove()
	{
	}

	public void UnlockMove()
	{
	}

	public void PerformNearDistance([Optional] Action onComplete)
	{
	}

	public void PerformFarDistance([Optional] Action onComplete)
	{
	}

	public void ResetDistance([Optional] Action onComplete)
	{
	}

	private float GetGoalDistanceValue()
	{
		return default(float);
	}

	private void DoDistanceTween(float goalValue, float duration, Ease easeType, float delay = 0f, [Optional] Action onCompleteTween)
	{
	}

	public void PerformRotate(Vector3 goalPoint, bool checkForcesRange, [Optional] Action onComplete)
	{
	}

	public void SnapPoint(Vector3 goalPoint)
	{
	}

	private float CalcRotateTweenDuration(Vector3 srcVec, Vector3 destPoint)
	{
		return default(float);
	}

	private void DoRotateTween(Vector3 cameraPosNormal, Vector3 goalPointNormal, float tweenDuration, Ease easeType, float delay = 0f, [Optional] Action onCompleteTween)
	{
	}

	private void SetNowCameraTransformParams()
	{
	}

	public void MoveCameraPosition(Vector3 moveVec, float deltaTime)
	{
	}

	public void StopMoveCameraPosition()
	{
	}

	public void StopImmediateMoveCameraPosition()
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	public void OnLateUpdate(float deltaTime)
	{
	}

	private void UpdateRot()
	{
	}

	private void UpdateMove(float deltaTime)
	{
	}

	private float CalcMoveSpeedDemical()
	{
		return default(float);
	}

	private float CalcDistanceRatio()
	{
		return default(float);
	}

	private void UpdatePosition()
	{
	}

	private Quaternion CalcCameraRot()
	{
		return default(Quaternion);
	}

	public void CheckTweenRunning()
	{
	}
}
