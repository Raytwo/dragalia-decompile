using System;
using UnityEngine;

public class FieldWazaCutInCapture : MonoBehaviour
{
	public bool isCapture;

	public RenderTexture RenderTexture;

	private Action<bool> ResultFunc;

	private void Awake()
	{
	}

	public void Capture(Action<bool> result)
	{
	}

	public void Release()
	{
	}

	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}
}
