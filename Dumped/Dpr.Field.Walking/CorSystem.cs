using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Field.Walking;

public class CorSystem : ICorSystem
{
	public string CorName;

	public float duration;

	public bool isFinished;

	public bool isPlaying;

	public bool isPause;

	private List<CorSystem> SubCoroutines;

	private IEnumerator MainIEnum;

	private IEnumerator IEnum;

	public event Action onStart
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action onFinished
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action onCancel
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action onPauseStart
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action onPauseEnd
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public CorSystem(string name = "")
	{
	}

	public void Destroy()
	{
	}

	public Coroutine Play(IEnumerator ienum)
	{
		return null;
	}

	public void PrePlayCancel()
	{
	}

	public Coroutine Play()
	{
		return null;
	}

	public void SetIEnum(IEnumerator ienum)
	{
	}

	public CorSystem OnStart(Action act)
	{
		return null;
	}

	public CorSystem OnFinished(Action act)
	{
		return null;
	}

	public CorSystem OnCancel(Action act)
	{
		return null;
	}

	public CorSystem OnPauseStart(Action act)
	{
		return null;
	}

	public CorSystem OnPauseEnd(Action act)
	{
		return null;
	}

	public CorSystem AddSub(string name = "")
	{
		return null;
	}

	public void Cancel()
	{
	}

	public void Pause()
	{
	}

	public Coroutine Restart()
	{
		return null;
	}

	private IEnumerator RestartCor()
	{
		return null;
	}

	public void ClearCallBacks()
	{
	}

	public void StateDebug([Optional] Text text)
	{
	}

	private IEnumerator Main(IEnumerator ienum)
	{
		return null;
	}

	private Coroutine StartCoroutine(IEnumerator ienum)
	{
		return null;
	}

	private void StopCoroutine(IEnumerator ienum)
	{
	}

	public Coroutine WaitForSeconds(float duration, [Optional] Action<CorSystem> OnUpdate)
	{
		return null;
	}

	public IEnumerator Wait(Action<CorSystem> OnUpdate)
	{
		return null;
	}
}
