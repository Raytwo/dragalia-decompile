using System;
using System.Runtime.InteropServices;
using Dpr.Battle.Logic;
using Dpr.Battle.View.Systems;
using Dpr.SequenceEditor;
using UnityEngine;
using XLSXContent;

namespace Dpr.Battle.View.Playables;

public class CameraFilePlayable : BattleViewPlayable<CameraFilePlayable>
{
	public enum PlayMode
	{
		WaitCamera,
		SequenceEditor
	}

	[SerializeField]
	private CameraData _cameraData;

	[SerializeField]
	private Animation _animation;

	[SerializeField]
	private AnimationClip _animationClip;

	[SerializeField]
	private Transform _shakeNode;

	[SerializeField]
	private ShakeParam _shakeParam;

	[SerializeField]
	private CameraCommander _waitCameraCommander;

	[SerializeField]
	private Transform _aimTarget;

	private float _speed;

	private PlayMode _mode;

	private Vector3 _initialScale;

	private Vector3 _offset;

	private bool _isFlip;

	private ISequenceViewSystem _viewSystem;

	private BattleWaitCameraData.SheetWaitCameraData _waitCameraData;

	public override bool IsPlaying => default(bool);

	public Animation Animation => null;

	public CameraCommander Commander => null;

	private void OnDestroy()
	{
	}

	public void Initialize(ISequenceViewSystem viewSystem)
	{
	}

	public void Initialize(BattleViewSystem viewSystem, BattleWaitCameraData.SheetWaitCameraData data)
	{
	}

	public void UnInitialize()
	{
	}

	protected override void OnLateUpdate(float deltaTime)
	{
	}

	private void OnLateUpdateSequenceEditor(float deltaTime)
	{
	}

	private void OnLateUpdateWaitCamera(float deltaTime)
	{
	}

	public override void Play([Optional] Action onComplete)
	{
	}

	private void OnStart()
	{
	}

	private void OnStartWaitCamera()
	{
	}

	private void OnComplete()
	{
	}

	public override void Stop()
	{
	}

	public void SetSpeed(float speed)
	{
	}

	public void SetCameraAnimationFlip(bool isFlip)
	{
	}

	public void SetCameraAnimationRotateYDeg(float rot)
	{
	}

	public void SetReserveFollowTrainer(BtlvPos vPos, Joint pJoint, Vector3 posOfs, bool isLoseCam)
	{
	}

	public void SetCameraAnimationOffset(Vector3 offset)
	{
	}

	public void SetCameraAnimationScale(Vector3 scale)
	{
	}
}
