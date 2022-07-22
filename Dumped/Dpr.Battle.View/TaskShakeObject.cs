using Dpr.SequenceEditor;
using UnityEngine;

namespace Dpr.Battle.View;

public sealed class TaskShakeObject : Task
{
	public delegate void VectorSetFunc(Vector3 value);

	public delegate Vector3 VectorGetFunc();

	public delegate Vector3 RotateGetFunc();

	private float _startRate;

	private float _endRate;

	private float _startDec;

	private float _endDec;

	private SEQ_DEF_AXIS _axis;

	private VectorSetFunc _setFunc;

	private VectorGetFunc _vectorGetFunc;

	private RotateGetFunc _rotateGetFunc;

	protected override bool IsFinishCondition => default(bool);

	public TaskShakeObject(VectorSetFunc setFunc, VectorGetFunc getFunc, RotateGetFunc rotGetFunc, float startRate, float endRate, float startDec, float endDec, int lifeTime, SEQ_DEF_AXIS axis)
	{
	}

	protected override void OnDispose()
	{
	}

	protected override void OnUpdate(int frame, float raito)
	{
	}
}
