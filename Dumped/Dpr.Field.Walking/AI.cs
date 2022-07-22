using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Dpr.Field.Walking;

public class AI
{
	private List<AIStateBase> AIStates;

	private AIStateBase nowState;

	private List<StateChecker> stateCheckers;

	public int abs;

	public AIModel aiModel
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public AI(WalkingCharacterController controller)
	{
	}

	public AI()
	{
	}

	public void Update()
	{
	}

	public void Destroy()
	{
	}

	public T AddState<T>() where T : AIStateBase
	{
		return null;
	}

	public void AddStateChecker<T>(StateChecker.Condition Condition) where T : AIStateBase
	{
	}

	public AIStateBase ChangeState(Type type)
	{
		return null;
	}

	public Type GetNowStateType()
	{
		return null;
	}

	public AIStateBase GetNowState()
	{
		return null;
	}

	public AIStateBase GetState<T>() where T : AIStateBase
	{
		return null;
	}
}
