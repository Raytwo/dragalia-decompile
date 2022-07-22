using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Dpr.MsgWindow;
using SmartPoint.AssetAssistant;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class XMenuTop : UIWindow, IViewportChangeHandler, IEventSystemHandler
{
	public enum ItemType
	{
		None = -1,
		Zukan,
		Pokemon,
		Bag,
		Card,
		Map,
		Seal,
		Setting,
		Gift,
		Report
	}

	public class Param
	{
		[Flags]
		public enum MenuType
		{
			Normal = 0,
			Fureai = 1,
			SafariGame = 2,
			UnderGround = 3
		}

		public class Safari
		{
			public int ballNum;

			public UnityAction onRetire;
		}

		public MenuType menuType;

		public Safari safari;
	}

	[SerializeField]
	private RectTransform _itemRoot;

	[SerializeField]
	private RectTransform _reportWindow;

	[SerializeField]
	private RectTransform _safariRoot;

	[SerializeField]
	private UIText _safariBallNum;

	[SerializeField]
	private RectTransform _messageWindowRoot;

	[SerializeField]
	private RectTransform _gotoTownMapRoot;

	private bool _isActived;

	private GridLayoutGroup _gridLayoutGroup;

	private UnityAction<UIWindow> _saveOnClosed;

	private List<XMenuTopItem> _initItems;

	private List<XMenuTopItem> _activeItems;

	private int _selectIndex;

	private const int _upperColumnMax = 4;

	private XMenuTopItem _fromSwapItem;

	private Vector3 _fromSwapPisiton;

	private int _fromSwapSiblingIndex;

	private List<UIManager.DuplicateImageMaterialParam> _duplicate;

	private Coroutine _coroutineTownmapGuideMessage;

	private Param _param;

	private void Awake()
	{
	}

	public override void OnCreate()
	{
	}

	public void Open(Param param, UIWindowID prevWindowId = (UIWindowID)(-2))
	{
	}

	public IEnumerator OpOpen(Param param, UIWindowID prevWindowId)
	{
		return null;
	}

	private void SetupTownmapGuideMessageWindow()
	{
	}

	private IEnumerator OpUpdateTownmapGuideMessageWindow()
	{
		return null;
	}

	private void StopTownmapGuideMessageWindow()
	{
	}

	void IViewportChangeHandler.OnViewportChange(int screenWidth, int screenHeight)
	{
	}

	private void SetupItems()
	{
	}

	private bool IsActiveItem(ItemType type)
	{
		return default(bool);
	}

	private bool IsSwap()
	{
		return default(bool);
	}

	private void SetupActiveItems()
	{
	}

	public void Close(UnityAction<UIWindow> onClosed_, bool isRemoveKeyguide, UIWindowID nextWindowId)
	{
	}

	public IEnumerator OpClose(UnityAction<UIWindow> onClosed_, bool isRemoveKeyguide, UIWindowID nextWindowId)
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private bool IsLimitingItem(ItemType itemType)
	{
		return default(bool);
	}

	private void PlaySeDecide(ItemType itemType)
	{
	}

	private void OpenItem(ItemType itemType)
	{
	}

	private UIWindowID GetWindowId(ItemType itemType)
	{
		return default(UIWindowID);
	}

	private void OnItemClosed(UIWindow window)
	{
	}

	private void UpdateSwap(float deltaTime)
	{
	}

	private void UpdateSelectItem(float deltaTime)
	{
	}

	private bool SetSelectIndex(int selectIndex, bool isInitialize = false)
	{
		return default(bool);
	}

	protected override void OpenMessageWindow(MsgWindowParam messageParam)
	{
	}

	protected override ContextMenuWindow CreateContextMenuYesNo(Func<ContextMenuItem, bool> onClicked, [Optional] ContextMenuWindow.Param contextMenuParam)
	{
		return null;
	}

	protected override void OnAddContextMenuYesNoItemParams(List<ContextMenuItem.Param> contextMenuItemParams)
	{
	}
}
