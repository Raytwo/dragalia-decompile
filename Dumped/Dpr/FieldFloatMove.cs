using System;
using System.Runtime.CompilerServices;

namespace Dpr;

public class FieldFloatMove
{
	public Func<float, float> EaseFunc;

	private float BaseValue;

	public bool IsBusy => default(bool);

	public float CurrentValue
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float TargetValue
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float CurrentTime
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float TargetTime
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void SetValue(float value)
	{
	}

	public void Stop()
	{
	}

	public void Update(float deltaTime)
	{
	}

	public void MoveTime(float targetValue, float time)
	{
	}

	public static float EaseDefault(float inValue)
	{
		return default(float);
	}

	public static float EaseInOutSin(float inValue)
	{
		return default(float);
	}

	public static float EaseOutSin(float inValue)
	{
		return default(float);
	}
}
