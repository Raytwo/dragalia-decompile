using System;
using UnityEngine;

namespace Dpr.UI;

public abstract class AWindowItem : MonoBehaviour
{
	[SerializeField]
	private RectTransform cursorContent;

	[HideInInspector]
	public int index;

	[HideInInspector]
	public int selectIndex;

	[HideInInspector]
	public bool isShow;

	protected Action<AWindowItem> onItemEvent;

	public RectTransform CursorContent => null;

	public abstract ItemType ItemType { get; }

	public abstract bool IsShowArrowIcon { get; }

	public abstract bool OnUpdate(float deltaTime);

	public void Initialize(Action<AWindowItem> onItemEvent)
	{
	}

	protected virtual void OnInitialize()
	{
	}

	public void OnFinalize()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}
}
