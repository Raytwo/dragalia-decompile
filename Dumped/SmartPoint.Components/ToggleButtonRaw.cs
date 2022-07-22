using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace SmartPoint.Components;

public class ToggleButtonRaw : Button
{
	[Serializable]
	public class SubmitEvent : UnityEvent<int>
	{
	}

	[SerializeField]
	private Color _targetColor;

	[SerializeField]
	private bool _isTarget;

	[SerializeField]
	private GameObject _targetObject;

	[SerializeField]
	private int _value;

	private RawImage _image;

	private Color _sourceColor;

	public SubmitEvent onSubmit;

	public int value => default(int);

	public bool isTarget
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public override void OnPointerClick(PointerEventData eventData)
	{
	}

	protected override void Awake()
	{
	}

	protected override void Start()
	{
	}

	public override void OnSubmit(BaseEventData eventData)
	{
	}

	private void UpdateImage()
	{
	}
}
