using System;
using System.Runtime.CompilerServices;

namespace Dpr.SecretBase;

public class StateBase<T, Owner> where T : Enum where Owner : class
{
	protected SecretBaseMasterDataManager masterData;

	public T Type
	{
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	public void Initialize(SecretBaseMasterDataManager masterData)
	{
	}

	public StateBase(T type)
	{
	}

	public virtual void Enter(Owner owner)
	{
	}

	public virtual void Execute(Owner owner)
	{
	}

	public virtual void Exit(Owner owner)
	{
	}
}
