using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dpr.MsgWindow;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class UIWindow : MonoBehaviour
{
	public const UIWindowID WINDOWID_FIELD = (UIWindowID)(-2);

	public const int MoveLeftButton = 69632;

	public const int MoveRightButton = 278528;

	public const int MoveUpButton = 139264;

	public const int MoveDownButton = 557056;

	public const float TransitionFadeDuration = 0.1f;

	public static readonly Color TransitionFadeFillColor;

	protected UIInputController _input;

	protected Canvas _canvas;

	protected Animator _animator;

	protected UIAnimationEvent _animEvent;

	protected UITransition.FadeType _transitionFadeType;

	protected UIWindowID _prevWindowId;

	protected Dpr.MsgWindow.MsgWindow _messageWindow;

	public UIManager.UIInstance instance;

	public UnityAction<UIWindow> onClosed;

	public UnityAction<UIWindow> onPreClose;

	private readonly int _animStateIn;

	private readonly int _animStateOut;

	protected bool isCompleteTransition => default(bool);

	public Canvas canvas => null;

	public UIInputController InputController => null;

	public bool IsClosing
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

	public virtual void OnCreate()
	{
	}

	public void RegisterCloseOnOpenWindow<T>(Color color, float duration, UnityAction<UIWindow> onClosedAction) where T : UIWindow
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected virtual void OnTransition(TransitionID transitionId, UITransition.FadeType fadeType)
	{
	}

	protected virtual void OnTransitionComplete(UITransition.FadeType fadeType)
	{
	}

	protected virtual void OnOpen(UIWindowID prevWindowId)
	{
	}

	protected bool IsPushButton(int button, bool isForce = false)
	{
		return default(bool);
	}

	protected bool IsReleaseButton(int button, bool isForce = false)
	{
		return default(bool);
	}

	protected bool IsRepeatButton(int button, bool isForce = false)
	{
		return default(bool);
	}

	protected bool IsOnButton(int button, bool isForce = false)
	{
		return default(bool);
	}

	protected bool IsAccelButton(int button, bool isForce = false)
	{
		return default(bool);
	}

	protected virtual void PlayOpenWindowAnimation(UIWindowID prevWindowId, [Optional] UnityAction onOpend)
	{
	}

	protected virtual IEnumerator OpPlayOpenWindowAnimation(UIWindowID prevWindowId, [Optional] UnityAction onOpend)
	{
		return null;
	}

	protected virtual int GetWindowAnimationConnectId(bool isOpen, UIWindowID windowId)
	{
		return default(int);
	}

	protected virtual IEnumerator OpPlayCloseWindowAnimationAndWaiting(UIWindowID nextWindowId)
	{
		return null;
	}

	protected virtual bool EnableMainCameraByUiMode(bool enabled)
	{
		return default(bool);
	}

	protected virtual void OnCloseKeyguide()
	{
	}

	protected virtual void OpenMessageWindow(MsgWindowParam messageParam)
	{
	}

	protected virtual void CloseMessageWindow()
	{
	}

	protected virtual bool IsActiveMessageWindow()
	{
		return default(bool);
	}

	protected ContextMenuWindow.Param CreateContextMenuYesNoParam()
	{
		return null;
	}

	protected virtual ContextMenuWindow CreateContextMenuYesNo(Func<ContextMenuItem, bool> onClicked, uint SeDecide)
	{
		return null;
	}

	protected virtual ContextMenuWindow CreateContextMenuYesNo(Func<ContextMenuItem, bool> onClicked, [Optional] ContextMenuWindow.Param contextMenuParam)
	{
		return null;
	}

	protected virtual void OnAddContextMenuYesNoItemParams(List<ContextMenuItem.Param> contextMenuItemParams)
	{
	}

	protected IEnumerator FadeTransition<T>(Color color, float duration, Action action) where T : UIWindow
	{
		return null;
	}
}
