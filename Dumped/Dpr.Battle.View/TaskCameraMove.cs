using DG.Tweening;
using Dpr.SequenceEditor;
using UnityEngine;

namespace Dpr.Battle.View;

public sealed class TaskCameraMove : Task
{
	private enum UpdateMode
	{
		MoveOnly,
		All
	}

	private SequenceCameraObject _iPtrCamerasystem;

	private Vector3 _startPos;

	private Vector3 _endPos;

	private Vector3 _startTrg;

	private Vector3 _endTrg;

	private Vector3 _startPosOfs;

	private Vector3 _endPosOfs;

	private Vector3 _startTrgOfs;

	private Vector3 _endTrgOfs;

	private float _startFov;

	private float _endFov;

	private UpdateMode _mode;

	private Vector3 _pos;

	private Vector3 _trg;

	private Vector3 _posOfs;

	private Vector3 _trgOfs;

	protected override bool IsFinishCondition => default(bool);

	public TaskCameraMove(SequenceCameraObject pBtlvCameraSystem, Vector3 endPos, Ease easingType, int lifeTime)
	{
	}

	public TaskCameraMove(SequenceCameraObject pBtlvCameraSystem, Vector3 endPos, Vector3 endTrg, float endFov, Ease easingType, int frame)
	{
	}

	public TaskCameraMove(SequenceCameraObject pBtlvCameraSystem, Vector3 endPos, Vector3 endTrg, Vector3 endPosOfs, Vector3 endTrgOfs, float endFov, Ease easingType, int frame)
	{
	}

	protected override void OnDispose()
	{
	}

	protected override void OnUpdate(int frame, float raito)
	{
	}
}
