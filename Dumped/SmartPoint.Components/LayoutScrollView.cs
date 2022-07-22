using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SmartPoint.Components;

public class LayoutScrollView : MonoBehaviour
{
	public enum StartCorner
	{
		UpperLeft,
		UpperRight,
		LowerLeft,
		LowerRight
	}

	public enum StartAxis
	{
		Horizontal,
		Vertical
	}

	public enum WrapType
	{
		ViewportRect,
		FixedCount
	}

	[Serializable]
	public struct Margin
	{
		public float left;

		public float bottom;

		public float top;

		public float right;
	}

	public struct GameObjectHolder
	{
		public bool enabled;

		public GameObject gameObject;
	}

	public class Cell
	{
		public bool rebuild;

		public bool calculate;

		public Vector2 size;

		public Vector2 localScale;

		public Vector2 localPosition;

		public bool hide;

		public int clippingX;

		public int clippingY;

		public bool visibility;

		public bool erase;

		public bool dirty;

		public object value;

		public LayoutCellObserver observer;

		public void Close()
		{
		}
	}

	[SerializeField]
	private Margin _margin;

	[SerializeField]
	private RectTransform _contentTemplate;

	[SerializeField]
	private Vector2 _cellSpacing;

	[SerializeField]
	private StartAxis _startAxis;

	[SerializeField]
	private WrapType _wrapType;

	[SerializeField]
	private int _maxColumnCount;

	[SerializeField]
	private Vector2 _minCellSize;

	[SerializeField]
	private LayoutCellItem _presetDatas;

	private Canvas _canvas;

	private ScrollRect _scrollRect;

	private RectTransform _viewRectTransform;

	private RectTransform _contentRectTransform;

	private List<LayoutCellObserver> _cellVisibilityPool;

	private List<Cell> _cells;

	private bool skipFirstCall;

	public Margin margin => default(Margin);

	public Rect clientRect => default(Rect);

	public StartAxis startAxis => default(StartAxis);

	public WrapType wrapType => default(WrapType);

	public float wrapPoint => default(float);

	public int cellCount => default(int);

	public List<Cell> cells => null;

	public ScrollRect scrollRect => null;

	public RectTransform contentRectTransform => null;

	public RectTransform templateRectTransform => null;

	private void Awake()
	{
	}

	public List<Cell> SwapBuffer(List<Cell> targetCells)
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	public void ForceUpdate(float deltaTime)
	{
	}

	public void AutoScroll(Cell cell)
	{
	}

	public void UpdateContent()
	{
	}

	public void OnValueChanged(Vector2 scrollPosition)
	{
	}

	private void UpdateCells(Rect clipRect)
	{
	}

	private LayoutCellObserver GetCellObserver()
	{
		return null;
	}

	public void Clear(bool cellClear = true)
	{
	}

	public Cell AddCell(object value)
	{
		return null;
	}

	public Cell InsertCell(object value)
	{
		return null;
	}

	public void Remove(Cell cell)
	{
	}

	public Cell GetCellByValue(object value)
	{
		return null;
	}

	public void RemoveByValue(object value)
	{
	}

	public void RemoveFirstCell()
	{
	}
}
