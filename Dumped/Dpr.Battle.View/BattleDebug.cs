using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Dpr.Battle.View;

public static class BattleDebug
{
	private const string CONDITION = "DMY";

	private const string BATTLE_PRODUCT_NAME = "Battle";

	private const string MONITOR_LABEL_CMD = "Cmd";

	private const string MONITOR_LABEL_CMD_WAIT = "CmdWait";

	private const string MONITOR_LABEL_SUSPEND = "Suspend";

	private static Dictionary<string, Stopwatch> _stopwatches;

	private static Stopwatch _stopwatch;

	public static bool isDisableLog;

	public static void Log(object msg)
	{
	}

	public static void NormalLog(object msg)
	{
	}

	public static void LogWarning(object msg)
	{
	}

	public static void LogSeq(object msg)
	{
	}

	public static void LogError(object msg)
	{
	}

	public static void LogErrorSeq(object msg)
	{
	}

	public static void LogErrorSeqOldMacro(object oldEffect, object newEffect)
	{
	}

	public static void Assert(bool condition)
	{
	}

	public static void Assert(bool condition, object msg, bool isEditorPause = false)
	{
	}

	public static void OutputMonitor(string label, object value, float life = 10f)
	{
	}

	public static void OutputMonitorCmd(object value, float life = 10f)
	{
	}

	public static void OutputMonitorCmdWait(object value, float life = 10f)
	{
	}

	public static void OutputSuspend(object value, float life = 1f)
	{
	}

	public static void FrameLog([Optional] object value)
	{
	}

	public static void StartStopwatch(string key)
	{
	}

	public static void LapStopwatch(string key, string label = "")
	{
	}

	public static void StopStopwatch(string key, string label)
	{
	}
}
