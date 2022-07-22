namespace Dpr.MsgWindow;

public class MsgWindowInput
{
	private enum KeyAssignId
	{
		Decide
	}

	private class KeyAssignValue
	{
		public const int InputDecide = 1;
	}

	private GameController.LogicalInput localInput;

	private void AssignInputDecide()
	{
	}

	public void SubscribeToGameController()
	{
	}

	public void RemoveFromGameController()
	{
	}

	public bool IsInputDecideButtonPush()
	{
		return default(bool);
	}

	public bool IsInputDecideButtonRelease()
	{
		return default(bool);
	}

	private bool IsButtonPush(int assignValue)
	{
		return default(bool);
	}

	private bool IsButtonRelease(int assignValue)
	{
		return default(bool);
	}
}
