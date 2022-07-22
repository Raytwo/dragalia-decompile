using System;
using Dpr.SequenceEditor;
using UnityEngine;

namespace Dpr.Battle.View;

public sealed class TaskObjectCameraAutoRotate : Task
{
	private SequenceCameraObject _iPtrBtlvCamraSystem;

	private float _len;

	private Vector3 _ofs;

	private Action<Vector3> _onPosUpdate;

	private Action<Vector3> _onRotUpdate;

	protected override bool IsFinishCondition => default(bool);

	public TaskObjectCameraAutoRotate(SequenceCameraObject pBtlvCameraSystem, float len, Vector3 ofs, int lifeTime, Action<Vector3> onPosUpdate, Action<Vector3> onRotUpdate)
	{
	}

	protected override void OnDispose()
	{
	}

	protected override void OnUpdate(int frame, float raito)
	{
	}
}
