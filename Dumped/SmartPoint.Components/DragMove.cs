using UnityEngine;
using UnityEngine.EventSystems;

namespace SmartPoint.Components;

public class DragMove : MonoBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler
{
	private Vector2 _dragPosition;

	private Vector2 _savedPosition;

	private float _savedHeight;

	private RectTransform _target;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	private void SetPosition(Vector2 position)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}
}
