using System;

namespace Dpr.Field.Walking;

public class StateChecker
{
	public delegate bool Condition(AIModel model);

	private Condition condition;

	private Type NextState;

	public StateChecker(Condition condition, Type type)
	{
	}

	public Type Check(AIModel model)
	{
		return null;
	}

	public void Destroy()
	{
	}
}
