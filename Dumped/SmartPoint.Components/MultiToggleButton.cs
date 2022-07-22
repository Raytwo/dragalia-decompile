using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SmartPoint.Components;

public class MultiToggleButton : Button
{
	[SerializeField]
	private Sprite[] _sprites;

	[SerializeField]
	private int _index;

	private Image _image;

	public int index => default(int);

	public override void OnPointerClick(PointerEventData eventData)
	{
	}

	protected override void Awake()
	{
	}

	protected override void Start()
	{
	}

	private void SetImage()
	{
	}
}
