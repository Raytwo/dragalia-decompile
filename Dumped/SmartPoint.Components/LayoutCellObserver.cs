using UnityEngine;
using UnityEngine.EventSystems;

namespace SmartPoint.Components;

public class LayoutCellObserver : MonoBehaviour, ISelectHandler, IEventSystemHandler
{
	private LayoutScrollView.Cell _cell;

	private LayoutScrollView _scrollView;

	private bool _enabled;

	private GameObject _gameObject;

	public new bool enabled
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public LayoutScrollView scrollView
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public LayoutScrollView.Cell cell
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual Vector2 sizeDelta => default(Vector2);

	public virtual void OnSelect(BaseEventData eventData)
	{
	}

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public virtual void OnSetup()
	{
	}

	public virtual bool IsReady()
	{
		return default(bool);
	}

	public virtual bool OnRebuildLayout()
	{
		return default(bool);
	}

	public virtual void OnUpdate(float deltaTime)
	{
	}

	public virtual void OnOpen(Rect rect)
	{
	}

	public virtual void OnClose()
	{
	}
}
