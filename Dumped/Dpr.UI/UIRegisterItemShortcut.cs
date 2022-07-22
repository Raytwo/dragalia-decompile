using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class UIRegisterItemShortcut : UIWindow
{
	private enum BootType
	{
		Register,
		Use
	}

	private const string QuestionReisterItemMessageLabel = "SS_bag_347";

	private const string QuestionReisterItemOnAllItemRegisteredMessageLabel = "SS_bag_348";

	private const string QuestionSwapButtonItemMessageLabel = "SS_bag_349";

	private const string ResultRegisterItemMessageLabel = "SS_bag_350";

	private const string ResultSwapItemMessageLabel = "SS_bag_351";

	[SerializeField]
	private Image bgImage;

	[SerializeField]
	private RegisterItemButton[] registerItemButtons;

	[SerializeField]
	private Image[] arrowImages;

	[SerializeField]
	private Color unselectArrowColor;

	[SerializeField]
	private Color selectArrowColor;

	[SerializeField]
	private Sprite unselectButtonBaseSprite;

	[SerializeField]
	private Sprite selectButtonBaseSprite;

	[SerializeField]
	private Sprite disableButtonBaseSprite;

	private readonly int _animStateIn;

	private readonly int _animStateOut;

	private UIMsgWindowController msgWindowController;

	private UIInputController inputController;

	private BootType bootType;

	private ushort registerItemNo;

	private Action<ushort> onUseCallBack;

	private int selectIndex;

	private bool isAllRegistered;

	public static ushort GetHighPriorityShortcutItemNo()
	{
		return default(ushort);
	}

	public static int GetRegisteredShortcutItemCount()
	{
		return default(int);
	}

	public override void OnCreate()
	{
	}

	public void OpenRegister(ushort registerItemNo)
	{
	}

	public void OpenUse(Action<ushort> onUseCallBack)
	{
	}

	public IEnumerator OpOpen()
	{
		return null;
	}

	public void Close(UnityAction<UIWindow> onClosed_)
	{
	}

	public IEnumerator OpClose(UnityAction<UIWindow> onClosed_)
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void SetSelectIndex(int index)
	{
	}

	private void SetButtonBaseSprite(RegisterItemButton button, bool isSelected)
	{
	}

	private void ShowSelectButtonMessage()
	{
	}

	private void Register()
	{
	}
}
