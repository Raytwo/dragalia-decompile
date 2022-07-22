using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UnderGround;

public class UgEmoticonSet : MonoBehaviour
{
	[SerializeField]
	private RectTransform cursorFrame;

	[SerializeField]
	private Image[] Icons;

	[SerializeField]
	private CanvasGroup group;

	public Action<int> OnDeside;

	public int nowIndex
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private void Awake()
	{
	}

	private void MyUpdate(float deltaTime)
	{
	}

	public void Open()
	{
	}

	public void Close(bool useInputActive = true)
	{
	}

	private void Next()
	{
	}

	private void Prev()
	{
	}

	private void UpdateCursor()
	{
	}

	private void OnDestroy()
	{
	}
}
