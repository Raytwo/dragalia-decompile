using System;

namespace Dpr.Battle.View;

public class TaskValueControl<TValue> : Task where TValue : struct
{
	protected TValue _from;

	protected TValue _to;

	protected Action<TValue> _onUpdate;

	public TaskValueControl(TValue from, TValue to, Action<TValue> onUpdate)
	{
	}

	protected override void OnDispose()
	{
	}
}
