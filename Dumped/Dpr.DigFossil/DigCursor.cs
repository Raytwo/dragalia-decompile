using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.DigFossil;

public class DigCursor : MonoBehaviour, IDigCursor
{
	public delegate void OnClicked([In] ref Vector2 inPos);

	private enum SpriteIndex
	{
		Hummer,
		Pickaxe
	}

	[SerializeField]
	private float speed;

	[SerializeField]
	private List<Sprite> toolSprites;

	[SerializeField]
	private Image tool;

	[SerializeField]
	private Image cursor;

	[SerializeField]
	private GameObject root;

	[SerializeField]
	private DigBoard board;

	[SerializeField]
	private Transform debugCursor;

	[SerializeField]
	private Text debugText;

	private Coroutine animationWaitCoroutine;

	private TweenerCore<Quaternion, Quaternion, NoOptions> tweenHandler;

	private Vector2 cursorPos;

	private Vector2 fieldSize;

	private Quaternion toolDefaultRotation;

	private bool bIsTouchMode;

	public OnClicked onClicked
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool IsOnTouchModeChanged
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

	public bool IsUse
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Transform effectRoot => null;

	public void OnUpdate()
	{
	}

	public void SetTool(bool bIsPickaxe)
	{
	}

	public void SetDisplay(bool bIsDisplay)
	{
	}

	public void Initialize()
	{
	}

	public void DigPosition(Vector2 posiiton, bool bIsPickaxe)
	{
	}

	private void ClampAndUpdateCursorPos()
	{
	}

	private void OnClickToolAnimation()
	{
	}

	private IEnumerator AnimationWait(float time)
	{
		return null;
	}

	private Vector2 ScreenPosToBoardPos(Vector2 screenPos)
	{
		return default(Vector2);
	}

	private bool CheckInsideBoradArea(Vector2 touchPos)
	{
		return default(bool);
	}

	public void SetTouchMode(bool bIsTouchMode)
	{
	}
}
