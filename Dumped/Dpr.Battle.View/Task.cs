using System;
using System.Runtime.CompilerServices;
using DG.Tweening;

namespace Dpr.Battle.View;

public class Task : IDisposable
{
	public enum AdvanceMode
	{
		Step,
		Time
	}

	public int _priority;

	public Task _iPtrPrev;

	public Task _iPtrNext;

	public bool _isSelfDelete;

	protected float _raito;

	protected int _frame;

	protected int _lifeTime;

	protected Ease _easingType;

	protected bool _isStart;

	protected Action _onStart;

	protected Action _onFinished;

	protected AdvanceMode _advanceMode;

	protected float _startTime;

	protected float _endTime;

	protected float _duration;

	protected float _elapsedTime;

	protected virtual bool IsFinishCondition
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	public bool IsEffectEnable
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public TaskManager Parent
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool IsFinished => default(bool);

	public float Duration => default(float);

	public void Dispose()
	{
	}

	protected virtual void OnDispose()
	{
	}

	public void Clear(Task iPtrDummyTask)
	{
	}

	public void Delete()
	{
	}

	protected virtual void Clear()
	{
	}

	public virtual void Update(float deltaTime, float currentSequenceTime, int step)
	{
	}

	protected virtual void FinishTask()
	{
	}

	public Task SetOnStart(Action onStart)
	{
		return null;
	}

	public Task SetOnFinished(Action onFinished)
	{
		return null;
	}

	public Task SetStartTime(float startTime)
	{
		return null;
	}

	public Task SetEndTime(float endTime)
	{
		return null;
	}

	public Task SetDuration(float duration)
	{
		return null;
	}

	public Task SetAdvanceMode(AdvanceMode mode)
	{
		return null;
	}

	protected virtual void OnUpdate(int frame, float raito)
	{
	}

	protected virtual void OnFinishTask()
	{
	}
}
