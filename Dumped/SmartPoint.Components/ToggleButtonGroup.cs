using System;
using UnityEngine;
using UnityEngine.Events;

namespace SmartPoint.Components;

public class ToggleButtonGroup : MonoBehaviour
{
	[Serializable]
	public class SelectEvent : UnityEvent<ToggleButton>
	{
	}

	[SerializeField]
	private ToggleButton[] _toggles;

	[SerializeField]
	private SelectEvent _onSelected;

	private ToggleButton _activeToggle;

	public ToggleButton activeToggle => null;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnClick()
	{
	}
}
