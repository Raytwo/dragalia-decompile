using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Dpr.Battle.View;

public abstract class BattleViewPlayable<T> : BtlvEntityBehaviour where T : BattleViewPlayable<T>
{
	protected enum StateType
	{
		None,
		Play,
		Stop,
		Finish
	}

	protected StateType _stateType;

	protected Action _onComplete;

	public virtual bool IsPlaying
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	public abstract void Play([Optional] Action onComplete);

	public abstract void Stop();
}
