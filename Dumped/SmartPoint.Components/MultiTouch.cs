using UnityEngine;

namespace SmartPoint.Components;

public class MultiTouch
{
	public enum LogicalTapType
	{
		Z,
		MouseLeft,
		MouseMiddle,
		Max
	}

	public class Status
	{
		public class Touch
		{
			public Phase phase;

			public Vector2 delta;

			public Vector2 position;
		}

		public int count;

		public Touch[] touches;

		public float distance;

		public float deltaDistance;

		public Touch lastTouch;
	}

	public enum Phase
	{
		Began = 0,
		Moved = 1,
		Ended = 3,
		Canceld = 4,
		Empty = -1
	}

	public static Status status;

	private static Phase GetLogicalButton(LogicalTapType type)
	{
		return default(Phase);
	}

	public static Status GetTouchStatus()
	{
		return null;
	}
}
