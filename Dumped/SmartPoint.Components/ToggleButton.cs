using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SmartPoint.Components;

public class ToggleButton : Button
{
	[SerializeField]
	private Sprite _targetSprite;

	[SerializeField]
	private Color _targetColor;

	[SerializeField]
	private bool _isTarget;

	[SerializeField]
	private GameObject _targetObject;

	[SerializeField]
	private int _value;

	private Image _image;

	private Sprite _sourceSprite;

	private Color _sourceColor;

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

	private void UpdateImage()
	{
	}
}
