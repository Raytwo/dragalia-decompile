using UnityEngine;

namespace Dpr.UI;

public class UINavigator : MonoBehaviour
{
	public enum NavigateType
	{
		None = -1,
		Left,
		Top,
		Right,
		Bottom
	}

	[SerializeField]
	protected UINavigator _left;

	[SerializeField]
	protected UINavigator _right;

	[SerializeField]
	protected UINavigator _top;

	[SerializeField]
	protected UINavigator _bottom;

	[SerializeField]
	protected bool _isStopLeft;

	[SerializeField]
	protected bool _isStopRight;

	[SerializeField]
	protected bool _isStopTop;

	[SerializeField]
	protected bool _isStopBottom;

	protected UINavigator[] _navigates;

	protected bool[] _isStops;

	public object userParam;

	private bool isInitialized;

	public UINavigator left
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UINavigator top
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UINavigator right
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UINavigator bottom
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UINavigator[] navigates
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected virtual void Awake()
	{
	}

	public virtual UINavigator GetNavigate(NavigateType type)
	{
		return null;
	}

	public virtual void SetNavigate(NavigateType type, UINavigator navigate)
	{
	}

	public virtual bool IsStop(NavigateType type)
	{
		return default(bool);
	}
}
