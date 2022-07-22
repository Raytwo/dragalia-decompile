using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class ContextMenuScrolledWindow : UIWindow
{
	[Serializable]
	private class MenuWindowParam
	{
		public Sprite _bgSprite;

		public Color[] _fontColors;
	}

	public enum CursorType
	{
		Frame,
		Arrow
	}

	public class Param
	{
		public enum MenuWindowType
		{
			Default,
			Network
		}

		public MenuWindowType windowType;

		public ContextMenuItem.Param[] itemParams;

		public Vector2 pivot;

		public Vector3 position;

		public int selectIndex;

		public float minItemWidth;

		public int cancelIndex;

		public bool useCancel;

		public bool useLoopAndRepeat;

		public bool isInputEnable;

		public UnityAction<int, ContextMenuItem.Param> onSetupMessageArgs;
	}

	[SerializeField]
	private RectTransform _windowRoot;

	[SerializeField]
	private RectTransform _contentRoot;

	[SerializeField]
	private Cursor _cursor;

	[SerializeField]
	private Image _imageBg;

	[SerializeField]
	private MenuWindowParam[] _windowParams;

	[SerializeField]
	protected UIScrollView _itemListScrollView;

	private readonly int _animStateIn;

	private readonly int _animStateOut;

	private VerticalLayoutGroup _verticalLayoutGroup;

	private ContextMenuItem _selectItem;

	public Func<ContextMenuItem, bool> onClicked;

	public UnityAction<ContextMenuItem> onSelectChanged;

	private Param _param;

	public ContextMenuItem selectItem => null;

	public void Awake()
	{
	}

	public void Open(Param param)
	{
	}

	public IEnumerator OpOpen(Param param)
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

	private void OnRequiredItemData(IUIButton button)
	{
	}

	private void OnSelectItemScrollViewItem(IUIButton button)
	{
	}

	private void OnUnSelectItemScrollViewItem(IUIButton button)
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private bool UpdateSelect(float deltaTime)
	{
		return default(bool);
	}
}
