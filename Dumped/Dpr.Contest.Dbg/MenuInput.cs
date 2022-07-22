namespace Dpr.Contest.Dbg;

public class MenuInput
{
	private enum KeyAssignId
	{
		GoNextScene,
		OpenMenu
	}

	private class KeyAssignValue
	{
		public const int GoNextScene = 1;

		public const int OpenMenu = 2;
	}

	private GameController.LogicalInput localInput;

	public void Initialize()
	{
	}

	public void OnFinalize()
	{
	}

	private void AssignInputGoNextScene()
	{
	}

	private void AssignInputOpenMenu()
	{
	}

	public bool IsInputGoNextScene()
	{
		return default(bool);
	}

	public bool IsInputOpenMenu()
	{
		return default(bool);
	}

	private bool IsButtonPush(int assignValue)
	{
		return default(bool);
	}
}
