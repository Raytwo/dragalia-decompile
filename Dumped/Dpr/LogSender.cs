using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dpr;

public class LogSender
{
	public static bool IsBusy
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static void Start()
	{
	}

	public static void Stop()
	{
	}

	private static void SendToTargetManager(string condition, string stackTrace, LogType type)
	{
	}
}
