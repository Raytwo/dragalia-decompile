using DG.Tweening;
using Dpr.SequenceEditor;
using UnityEngine;

namespace Dpr.Battle.View;

public sealed class TaskCameraRotatePos : Task
{
	private SequenceCameraObject _iPtrBtlvCameraSystem;

	private Vector3 _pos;

	private float _trgY;

	private float _len;

	private float _startRot;

	private float _endRot;

	protected override bool IsFinishCondition => default(bool);

	public TaskCameraRotatePos(SequenceCameraObject pBtlvCameraSystem, Vector3 pos, Vector3 trg, float rotRad, int lifeTime, Ease easingType)
	{
	}

	protected override void OnDispose()
	{
	}

	protected override void OnUpdate(int frame, float raito)
	{
	}
}
