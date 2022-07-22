using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StabilizationScrollRect : ScrollRect, IPointerUpHandler, IEventSystemHandler
{
	private static List<RaycastResult> _raycastResults;

	private GameObject _lastPressedObject;

	private Vector2 _startingPoint;

	private Vector2 _offsetVector;

	[SerializeField]
	private float _horizontalThreshold;

	[SerializeField]
	private float _verticalThreshold;

	private bool _isMoving;

	private bool _isDragging;

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public override void OnInitializePotentialDrag(PointerEventData eventData)
	{
	}

	private bool DecideMoving(PointerEventData eventData)
	{
		return default(bool);
	}

	public override void OnBeginDrag(PointerEventData eventData)
	{
	}

	public override void OnDrag(PointerEventData eventData)
	{
	}

	public override void OnEndDrag(PointerEventData eventData)
	{
	}

	protected void DetachObject(PointerEventData eventData, bool click = false)
	{
	}

	protected void ExecutePointerUpEvent(RaycastResult result, PointerEventData eventData)
	{
	}

	protected void ExecuteClickEvent(RaycastResult result, PointerEventData eventData)
	{
	}

	protected bool IsLeftButtonPressEvent(PointerEventData eventData)
	{
		return default(bool);
	}

	protected PointerEventData Clone(PointerEventData e)
	{
		return null;
	}
}
