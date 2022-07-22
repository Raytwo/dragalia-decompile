using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Dpr.Battle.Logic;
using Dpr.SequenceEditor;
using UnityEngine;
using XLSXContent;

namespace Dpr.Battle.View.Systems;

public sealed class BattleCameraSystem : SequenceCameraSystem
{
	private const int LOTTERY_MAX = 10;

	private const int PLAY_WAIT_CAMERA_DELAY_FRAME = 30;

	private int _lotteryCnt;

	private Coroutine _waitCameraLoadCoroutine;

	private bool _isSplitScreen;

	private bool _isSplitScreenDelResource;

	private bool _isEnableWaitamera;

	private bool _isFirstWaitCamera;

	private bool _isStatedWaitCamera;

	private int _waitCameraCnt;

	private int _playWaitCameraIndex;

	private BattleWaitCameraData.SheetWaitCameraData[] _useWaitCameraDatas;

	private HashSet<BattleWaitCameraData.SheetWaitCameraData> _lotteryPlayWaitCameraDatas;

	private Vector3 _position;

	private Vector3 _target;

	private Vector3 _animPosition;

	private Vector3 _animTarget;

	private float _animNear;

	private float _animFar;

	private float _animFov;

	private float _animTwist;

	private BtlvPos _waitCameraTargetPoke;

	private BtlvPos _waitCameraTargetTrainer;

	private Coroutine _waitCameraDispose;

	public WaitCameraStateType WaitCameraState
	{
		[CompilerGenerated]
		get
		{
			return default(WaitCameraStateType);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsPlayWaitCamera => default(bool);

	public bool IsPlayedWaitCameraOnce => default(bool);

	public BattleCameraSystem(BattleViewSystem pViewSystem, Camera camera)
	{
	}

	public override void OnLateUpdate(float deltaTime)
	{
	}

	private void InitializeWaitCamera()
	{
	}

	private void ClearWaitCameraWork()
	{
	}

	private void LateUpdateWaitCamera()
	{
	}

	public void StartWaitCamera()
	{
	}

	private void StartLoopWaitCamera()
	{
	}

	private IEnumerator RunWaitCameraForSequence(bool isLoop)
	{
		return null;
	}

	private BattleWaitCameraData.SheetWaitCameraData LotteryWaitCamera()
	{
		return null;
	}

	private bool CanPlayWaitCameraData(BattleWaitCameraData.SheetWaitCameraData data)
	{
		return default(bool);
	}

	private void StopCamera()
	{
	}

	public void EndWaitCamera()
	{
	}

	public void StopWaitCameraCoroutine()
	{
	}

	private void ResetWaitCameraParam()
	{
	}
}
