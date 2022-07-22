using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dpr.UI;

public class BoxWallPaperSelector : MonoBehaviour
{
	[SerializeField]
	private UIScrollView _wallPaperScroller;

	private float _openPosX;

	private float _closePosX;

	private Action _onCancel;

	private Action _onChange;

	private Action _onDecide;

	private int _maxCount;

	public int CurrentIndex
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

	public void Initialize(Action onCancel, Action onDecide, Action onChange)
	{
	}

	private void OnRequiredItemData(IUIButton button)
	{
	}

	private void OnSelectItemScrollViewItem(IUIButton button)
	{
	}

	private void OnUnSelectItemScrollViewItem(IUIButton button)
	{
	}

	public void Open(int index)
	{
	}

	public void Close()
	{
	}

	public void OnUpdate()
	{
	}

	private void ChangeWallPaper(int value)
	{
	}
}
