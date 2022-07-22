using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dpr.UI;

[Serializable]
public class IndexSelector
{
	private enum MoveState
	{
		Neutral,
		Moving,
		Stop,
		Resume
	}

	[SerializeField]
	private bool IsStopInEnd;

	[SerializeField]
	private bool IsStopRepeatMovingWhenOutOfRanges;

	[SerializeField]
	private bool IsLoop;

	private MoveState moveState;

	public int CurrentIndex
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int MinCount
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int MaxCount
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsLooping
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public IndexSelector()
	{
	}

	public IndexSelector(bool isStopInEnd, bool isStopRepeatMovingWhenOutOfRange, bool isLoop)
	{
	}

	public void Setup(int minCount, int maxCount)
	{
	}

	public bool Move(int moveValue)
	{
		return default(bool);
	}

	public void ResumeMoveState()
	{
	}

	public void SetCurrentIndex(int index)
	{
	}
}
