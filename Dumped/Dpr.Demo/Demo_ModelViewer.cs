using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Dpr.Demo;

public class Demo_ModelViewer : DemoBase
{
	private string assetPath;

	public bool isEnd;

	private GameObject Model;

	private UnityEngine.Object Asset;

	public Vector3 ModelPosition;

	public Vector3 ModelEulerAngles;

	public Vector3 ModelScale;

	public Vector3 ImageOffset;

	public Action<GameObject> OnCreateModel;

	private Dictionary<string, UnityEngine.Object> CacheObjects;

	private Coroutine cor;

	public Demo_ModelViewer(string AssetBundlePath, bool isDisableEndLight = true)
	{
	}

	public override void Destroy()
	{
	}

	public override IEnumerator Enter()
	{
		return null;
	}

	public IEnumerator LoadAsset()
	{
		return null;
	}

	private IEnumerator CreateModel([Optional] Action OnCreate)
	{
		return null;
	}

	public void ChangeModel(string AssetBundlePath)
	{
	}

	public override IEnumerator Main()
	{
		return null;
	}
}
