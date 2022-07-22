using DG.Tweening;
using Dpr.SequenceEditor;
using UnityEngine;

namespace Dpr.Battle.View;

public sealed class TaskCameraRotateTrg : Task
{
	private SequenceCameraObject _iPtrBtlvCameraSystem;

	private Vector3 _trg;

	private float _posY;

	private float _len;

	private float _startRot;

	private float _endRot;

	protected override bool IsFinishCondition => default(bool);

	public TaskCameraRotateTrg(SequenceCameraObject pBtlvCameraSystem, Vector3 pos, Vector3 trg, float rotRad, int lifeTime, Ease easingType)
	{
	}

	protected override void OnDispose()
	{
	}

	protected override void OnUpdate(int frame, float raito)
	{
	}
}
