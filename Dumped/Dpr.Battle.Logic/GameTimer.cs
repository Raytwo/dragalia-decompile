using System.Diagnostics;

namespace Dpr.Battle.Logic;

public sealed class GameTimer
{
	public enum TimerType
	{
		GAME,
		CLIENT,
		COMMAND,
		NUM
	}

	private Stopwatch[] m_timeCount;

	private ushort[] m_limitTime;

	private bool[][] m_isPause;

	public void Initialize()
	{
	}

	public uint GetTime(TimerType type)
	{
		return default(uint);
	}

	public void SetTime(TimerType type, uint time)
	{
	}

	public void StartCountDown(TimerType type, TimerControlLevel level)
	{
	}

	public void Pause(TimerType type, TimerControlLevel level)
	{
	}

	public bool IsFinish(TimerType type)
	{
		return default(bool);
	}

	private void setPauseFlag(TimerType type, TimerControlLevel level, bool flag)
	{
	}

	private bool isPause(TimerType type)
	{
		return default(bool);
	}

	private void clearPauseFlag(TimerType type)
	{
	}
}
