using System;

namespace Dpr.Battle.View;

public sealed class TaskManager : IDisposable
{
	public const int DEFAULT_TASK_MAX_NUM = 24;

	public const int TASK_PRIORITY_DEFAULT = 64;

	public const int TASK_PRIORITY_LOW = 96;

	private bool _suicideFlag;

	private int _taskNum;

	private Task _iPtrTaskFirst;

	private Task _iPtrNowChain;

	public bool IsAllFinished => default(bool);

	public TaskManager(int taskCnt = 24)
	{
	}

	public void Dispose()
	{
	}

	public void RegisterTask(Task task, bool isForward = true)
	{
	}

	public void Delete(Task iPtrTask)
	{
	}

	public int GetTaskNum()
	{
		return default(int);
	}

	public void DeleteTaskFunc(Task iPtrTask)
	{
	}

	public void OnUpdate(float deltaTime, float currentSequenceTime, int step = 1)
	{
	}

	public void ForceAllFinished()
	{
	}
}
