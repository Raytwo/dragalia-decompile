using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Field.Walking;

public class CorSystemContainer : ICorSystem
{
	public delegate IEnumerator corDelegate(CorSystem corSystem);

	private CorSystem corSys;

	private CorSystem TimeCorSys;

	private List<CorSystem> SubList;

	public int nowSubNo;

	public float duration;

	public float elapsedTime;

	private Text text;

	private int count;

	public bool isFinished => default(bool);

	public bool isPlaying => default(bool);

	public float Rate => default(float);

	public CorSystemContainer(string name = "")
	{
	}

	public void Cancel()
	{
	}

	public void SubCancel(string s)
	{
	}

	public void SubCancel(CorSystem corSys)
	{
	}

	public void SubCancel(int no)
	{
	}

	public void Pause()
	{
	}

	public Coroutine Restart()
	{
		return null;
	}

	public CorSystem AddSub(float duration, corDelegate ienum, string name = "")
	{
		return null;
	}

	public CorSystem AddSub(float duration, IEnumerator ienum, string name = "")
	{
		return null;
	}

	private void AddSubList(CorSystem sub, IEnumerator ienum)
	{
	}

	public CorSystem AddWait(float duration, Action<CorSystem> OnUpdate, string Name)
	{
		return null;
	}

	public void Play()
	{
	}

	private IEnumerator TimeCount()
	{
		return null;
	}

	private IEnumerator Main()
	{
		return null;
	}
}
