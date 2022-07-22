namespace Dpr.Contest;

public class ContestInput
{
	private enum KeyAssignId
	{
		Tap,
		Waza,
		Decide
	}

	private class KeyAssignIdValue
	{
		public const int Tap = 1;

		public const int Waza = 2;

		public const int Decide = 4;
	}

	private GameController.LogicalInput localInput;

	public void Subscribe()
	{
	}

	public void Remove()
	{
	}

	private void AssignTap()
	{
	}

	private void AssignWaza()
	{
	}

	private void AssignDecide()
	{
	}

	public bool IsPushPositiveButton()
	{
		return default(bool);
	}

	public bool IsOnPositiveButton()
	{
		return default(bool);
	}

	public bool IsPushWazaButton()
	{
		return default(bool);
	}

	public bool IsPushDecideButton()
	{
		return default(bool);
	}

	private bool IsButtonPush(int assignValue)
	{
		return default(bool);
	}

	private bool IsButtonOn(int assignValue)
	{
		return default(bool);
	}

	private bool IsButtonRelease(int assignValue)
	{
		return default(bool);
	}
}
