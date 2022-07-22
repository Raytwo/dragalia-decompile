using Dpr.SubContents;

namespace Dpr.Contest;

public class ResultTutorialMode
{
	private enum State
	{
		None,
		WaitMsg,
		WaitContextMenu
	}

	private ShowMessageWindow resultMsg;

	private State currentState;

	private float waitMsgDuration;

	private float timer;

	private int playCount;

	private bool bRestart;

	private bool bRunning;

	public bool IsSelectRestart => default(bool);

	public void OnFinalize()
	{
	}

	public void Setup(ResultSettings setting)
	{
	}

	public void StartAnimation()
	{
	}

	private void FirstPlayAnimation()
	{
	}

	private void PlayAnimation()
	{
	}

	public bool OnUpdate(float deltaTime)
	{
		return default(bool);
	}

	private void UpdateWaitMsg(float deltaTime)
	{
	}

	private void ChangeState(State nextState)
	{
	}
}
