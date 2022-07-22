using System;
using System.Collections.Generic;

namespace Dpr.SecretBase;

public class StateMachine<T, Owner> where T : Enum where Owner : class
{
	private Dictionary<T, StateBase<T, Owner>> states;

	private StateBase<T, Owner> current;

	private StateBase<T, Owner> prev;

	private Owner owner;

	public StateMachine(Owner owner)
	{
	}

	public void AddState(StateBase<T, Owner> state)
	{
	}

	public void ChangeState(T type)
	{
	}

	public void OverlapState(T type)
	{
	}

	public void ChangePrevState()
	{
	}

	public void Update()
	{
	}

	public T GetCurrentType()
	{
		return (T)null;
	}
}
