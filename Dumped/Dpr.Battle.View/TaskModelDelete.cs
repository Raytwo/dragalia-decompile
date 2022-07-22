using System;
using UnityEngine;

namespace Dpr.Battle.View;

public sealed class TaskModelDelete : Task
{
	private GameObject m_oHdlModel;

	private Action _onFinishAction;

	protected override bool IsFinishCondition => default(bool);

	public TaskModelDelete(GameObject go, Action finishAction, int lifeTime)
	{
	}

	protected override void OnDispose()
	{
	}

	protected override void OnFinishTask()
	{
	}
}
