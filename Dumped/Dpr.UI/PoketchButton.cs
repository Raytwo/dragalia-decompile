using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class PoketchButton : MonoBehaviour
{
	[SerializeField]
	private Image _image;

	[SerializeField]
	private Sprite _pressedSprite;

	[SerializeField]
	private Vector2 _pressedOffset;

	[SerializeField]
	private Vector2 _pressedTransform;

	[SerializeField]
	private float _pressedScale;

	[SerializeField]
	private bool _canDrag;

	[SerializeField]
	private bool _disablePressedOffset;

	[SerializeField]
	private bool _enableRepeat;

	[SerializeField]
	private float _firstRepeatTime;

	[SerializeField]
	private float _repeatTime;

	private Vector3 _basePosition;

	private Vector3 _pressedPosition;

	private Vector2 _baseDeltaSize;

	private Vector2 _pressedDeltaSize;

	private Vector2 _baseScaleVector;

	private Vector2 _pressedScaleVector;

	private bool _onRepeat;

	private float _repeatTimeCount;

	private int _repeatCount;

	private uint _seEventId;

	private UnityAction _onButtonAction;

	public bool IsInitialized
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool CanDrag => default(bool);

	public UnityAction OnTouchAction
	{
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public UnityAction OnReleaseAction
	{
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public void Initialize([Optional] UnityAction callback, uint seEventId = 235681195u)
	{
	}

	public void Uninitialize()
	{
	}

	private void OnUpdateRepeat(float deltaTime)
	{
	}

	public void SetSeEventId(uint seEventId = uint.MaxValue)
	{
	}

	public void OnPush()
	{
	}

	public void SetTouch()
	{
	}

	public void SetRelease()
	{
	}

	public void SetImage(bool isTouch = false)
	{
	}
}
