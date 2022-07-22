using DG.Tweening;
using Dpr.SequenceEditor;
using UnityEngine;

namespace Dpr.Battle.View;

public sealed class TaskCameraMoveBezier : Task
{
	private SequenceCameraObject _camera;

	private bool _isReletive;

	private Vector3[] _points;

	private bool[] _vectorElems;

	private Vector3 _originPos;

	protected override bool IsFinishCondition => default(bool);

	public TaskCameraMoveBezier(SequenceCameraObject pBtlvCameraSystem, bool isRelative, Vector3[] points, bool[] vectorElems, int lifeTime, Ease easingType)
	{
	}

	protected override void OnDispose()
	{
	}

	protected override void OnUpdate(int frame, float raito)
	{
	}
}
