using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class ContextMenuWindow : UIWindow
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

		public uint seDecide;

		public uint seCancel;
	}

	[SerializeField]
	private RectTransform _windowRoot;

	[SerializeField]
	private RectTransform _contentRoot;

	[SerializeField]
	private ContextMenuItem _itemPrefab;

	[SerializeField]
	private Cursor _cursor;

	[SerializeField]
	private Image _imageBg;

	[SerializeField]
	private MenuWindowParam[] _windowParams;

	private readonly int _animStateIn;

	private readonly int _animStateOut;

	private List<ContextMenuItem> _items;

	private int _selectIndex;

	private VerticalLayoutGroup _verticalLayoutGroup;

	public Func<ContextMenuItem, bool> onClicked;

	public UnityAction<ContextMenuItem> onSelectChanged;

	private Param _param;

	private Vector3 _position;

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

	public void SetPosition(Vector2 position)
	{
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

	private bool UpdateSelect(float deltaTime)
	{
		return default(bool);
	}

	private void MoveIndex(int move, bool isLoop)
	{
	}

	private bool SetSelectIndex(int selectIndex, bool isInitialize = false)
	{
		return default(bool);
	}
}
