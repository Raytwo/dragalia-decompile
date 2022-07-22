using System;

namespace Dpr.Battle.View;

public sealed class TaskFinishFuncCall : Task
{
	private Action _onFinishFunc;

	protected override bool IsFinishCondition => default(bool);

	public TaskFinishFuncCall(int lifeTime, Action onFinish)
	{
	}

	protected override void OnDispose()
	{
	}

	protected override void OnFinishTask()
	{
	}
}
