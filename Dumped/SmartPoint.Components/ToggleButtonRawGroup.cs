using System;
using UnityEngine;
using UnityEngine.Events;

namespace SmartPoint.Components;

public class ToggleButtonRawGroup : MonoBehaviour
{
	[Serializable]
	public class SelectEvent : UnityEvent<ToggleButtonRaw>
	{
	}

	[SerializeField]
	private ToggleButtonRaw[] _toggles;

	[SerializeField]
	private SelectEvent _onSelected;

	private int _activeIndex;

	public ToggleButtonRaw.SubmitEvent onSubmit;

	public int activeIndex
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public ToggleButtonRaw activeToggle => null;

	private void OnEnable()
	{
	}

	public void Previous()
	{
	}

	public void Next()
	{
	}

	private void OnDisable()
	{
	}

	private void OnClick()
	{
	}

	public void OnSubmit(int value)
	{
	}
}
