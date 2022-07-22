using System;
using System.Collections.Generic;
using UnityEngine;

namespace Dpr.UI;

[Serializable]
public class UIButtonSelector
{
	[SerializeField]
	private Transform buttonsParentTransform;

	[SerializeField]
	private IndexSelector indexSelector;

	private List<IUIButton> buttons;

	private Action<IUIButton> onSelectButton;

	private Action<IUIButton> onUnSelectButton;

	private List<IUIButton> activeButtons;

	public void Initialize(Action<IUIButton> onSelectButton, Action<IUIButton> onUnSelectButton)
	{
	}

	public void SetActive(bool isActive)
	{
	}

	public int GetActiveButtonIndex(int index)
	{
		return default(int);
	}

	public void Setup(int selectIndex = -1)
	{
	}

	public IUIButton GetButton(int index)
	{
		return null;
	}

	public int GetButtonCount()
	{
		return default(int);
	}

	public int GetActiveButtonCount()
	{
		return default(int);
	}

	public bool MoveSelect(int value)
	{
		return default(bool);
	}

	public void ResumeMoveSelect()
	{
	}

	private void SetSelectIndex(int index)
	{
	}
}
