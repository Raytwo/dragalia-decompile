using System.Collections;
using System.Runtime.CompilerServices;
using Dpr.UI;

namespace Dpr.Battle.View.Systems;

public class BUIAutoPilot
{
	public enum AutoPilotMode
	{
		None,
		Capture
	}

	public enum AutoPilotState
	{
		None,
		Running,
		Done
	}

	public enum AutoPilotCommand
	{
		None,
		WaitForStandbyAction,
		WaitForStandbyWaza,
		ExecuteActionButton,
		ExecuteWazaButton,
		SelectActionBag,
		WaitForOpenBag,
		WaitForCloseBag,
		SelectBagBallTab,
		ExecuteBagSelectItem,
		WaitForOpenContextMenu,
		ExecuteContextMenuDecision,
		SetDumyBag,
		ResetDumyBag
	}

	private float _cursorWait;

	private float _executeWait;

	private AutoPilotCommand[] _autoPilotData;

	private static AutoPilotMode _mode;

	private BattleViewUISystem _uiSystem;

	public AutoPilotState State
	{
		[CompilerGenerated]
		get
		{
			return default(AutoPilotState);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsRunning => default(bool);

	public void BeginAutoPilot(AutoPilotMode mode, float cursorWait, float executeWait)
	{
	}

	public IEnumerator ExecuteAutoPilot()
	{
		return null;
	}

	private IEnumerator WaitForOpenUIWindow<T>(float wait = 0f) where T : UIWindow
	{
		return null;
	}

	private IEnumerator WaitForCloseUIWindow<T>(float wait = 0f) where T : UIWindow
	{
		return null;
	}

	private IEnumerator PushUIWindowButton(UIWindow uiWindow, int button, float wait)
	{
		return null;
	}
}
