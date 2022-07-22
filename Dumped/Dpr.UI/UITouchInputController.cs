using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dpr.UI;

public class UITouchInputController
{
	public class TouchInfo
	{
		public enum TouchState
		{
			Began,
			Stationary,
			Moved,
			Touched,
			LongTouched,
			End
		}

		public float TouchTime;

		public Vector2 StartPoint;

		public Vector2 Point;

		public TouchState State;
	}

	private const int MaxTouchCount = 10;

	private float longTouchTime;

	public TouchInfo[] Touches
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

	public int TouchCount
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

	public UITouchInputController(float longTouchTime = 1f)
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	public TouchInfo GetNearestOriginPointTouch()
	{
		return null;
	}

	private void SetBeganTouch(int index, Vector2 pos, float deltaTime)
	{
	}

	private void SetStationaryTouch(int index, Vector2 pos, float deltaTime)
	{
	}

	private void SetMovedTouch(int index, Vector2 pos, float deltaTime)
	{
	}

	private void SetEndTouch(int index, Vector2 pos, float deltaTime)
	{
	}
}
