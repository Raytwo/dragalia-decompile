using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SmartPoint.AssetAssistant;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SmartPoint.Components;

public class DebugMenu : SingletonMonoBehaviour<DebugMenu>
{
	public delegate void EventCallback(bool visibled);

	public delegate bool TryCallback();

	public class MenuInstance
	{
		private string _caption;

		private LayoutScrollView _scrollView;

		private GameObject _gameObject;

		private int _currentIndex;

		private MenuInstance _parent;

		private Canvas _canvas;

		private CanvasGroup _canvasGroup;

		private LayoutGroup _layoutGroup;

		private List<LayoutScrollView.Cell> _cells;

		public string caption
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LayoutScrollView scrollView => null;

		public List<LayoutScrollView.Cell> cells => null;

		public bool visible
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public LayoutScrollView.Cell ownerCell
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

		public MenuInstance(string caption, GameObject gameObject, LayoutScrollView scrollView)
		{
		}

		public LayoutScrollView.Cell AddMenu(MenuInstance subMenu)
		{
			return null;
		}

		public LayoutScrollView.Cell AddItem(string text, DebugMenuCell.Click callback, object reference, [Optional] DebugMenuCell.UpdateInformationDelegate updateInformation)
		{
			return null;
		}

		public LayoutScrollView.Cell AddSlider(string text, DebugMenuCell.InputFloatDelegate input, DebugMenuCell.OutputFloatDelegate output, float minValue, float maxValue)
		{
			return null;
		}

		public LayoutScrollView.Cell AddSpinner(string text, DebugMenuCell.InputIntegerDelegate input, DebugMenuCell.OutputIntegerDelegate output, int low, int high, [Optional] DebugMenuCell.Click onClick, [Optional] DebugMenuCell.UpdateTextDelegate updateText, [Optional] DebugMenuCell.UpdateInformationDelegate updateInformation)
		{
			return null;
		}

		public LayoutScrollView.Cell AddSelector(string text, DebugMenuCell.SelectedIndexChanged onSelect, DebugMenuCell.InputIntegerDelegate selected, string[] values, [Optional] DebugMenuCell.Click onClick, [Optional] DebugMenuCell.UpdateInformationDelegate updateInformation)
		{
			return null;
		}

		public LayoutScrollView.Cell AddSelector(string text, DebugMenuCell.SelectedIndexChanged onSelect, DebugMenuCell.InputIntegerDelegate selected, DebugMenuCell.InputStringArrayDelegate inputList, [Optional] DebugMenuCell.Click onClick, [Optional] DebugMenuCell.UpdateInformationDelegate updateInformation)
		{
			return null;
		}

		public LayoutScrollView.Cell AddItem(MenuInstance subMenu)
		{
			return null;
		}

		public LayoutScrollView.Cell AddItem(string text, DebugMenuCell.InputFloatDelegate input, DebugMenuCell.OutputFloatDelegate output, float minValue, float maxValue)
		{
			return null;
		}

		public LayoutScrollView.Cell AddItem(string text, DebugMenuCell.InputIntegerDelegate input, DebugMenuCell.OutputIntegerDelegate output, int low, int high, [Optional] DebugMenuCell.Click onClick, [Optional] DebugMenuCell.UpdateTextDelegate updateText, [Optional] DebugMenuCell.UpdateInformationDelegate updateInformation)
		{
			return null;
		}

		public void Remove(LayoutScrollView.Cell cell, bool remove = true)
		{
		}

		public void RemoveByReference(object reference)
		{
		}

		public void Previous()
		{
		}

		public void Next()
		{
		}

		public LayoutScrollView.Cell GetCurrentCell()
		{
			return null;
		}

		public void SetCurrentIndex(int index)
		{
		}

		public void SetCurrentCell(LayoutScrollView.Cell cell)
		{
		}

		public DebugMenuCell.Item GetCurrentItem()
		{
			return null;
		}

		public void Update(bool reselect = true)
		{
		}

		public void Reload()
		{
		}

		public MenuInstance GetParent()
		{
			return null;
		}

		private LayoutScrollView.Cell AddChild(DebugMenuCell.Item item)
		{
			return null;
		}
	}

	[SerializeField]
	private GameObject template;

	[SerializeField]
	private RectTransform informationWindow;

	[SerializeField]
	private Canvas topCanvas;

	[SerializeField]
	private CanvasGroup topCanvasGroup;

	[SerializeField]
	private TextMeshProUGUI informationText;

	[SerializeField]
	private TextMeshProUGUI _caption;

	public static EventCallback onVisibleChanged;

	public static EventCallback onActiveChange;

	public static TryCallback tryOpenDelegate;

	private Image _image;

	public bool _isOpaque;

	private static MenuInstance _globalMenu;

	private static MenuInstance _rootMenu;

	private static MenuInstance _currentMenu;

	private static MenuInstance _nextMenu;

	public bool IsOpaque
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static bool visible
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public bool GetActive()
	{
		return default(bool);
	}

	public void SetActive(bool value)
	{
	}

	public void SetVisibled(bool value)
	{
	}

	public static MenuInstance Create(string caption, [Optional] MenuInstance parent)
	{
		return null;
	}

	public static bool GetInformationWindowEnable()
	{
		return default(bool);
	}

	public static void ShowInformationWindow(bool show)
	{
	}

	public static void SetInformationText(string text)
	{
	}

	public static void SetRoot(MenuInstance menuInstance)
	{
	}

	public static MenuInstance GetRoot()
	{
		return null;
	}

	protected override bool Awake()
	{
		return default(bool);
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public static MenuInstance GetCurrentMenu()
	{
		return null;
	}

	public static void SetCurrentMenu(MenuInstance currentMenu)
	{
	}

	private static void OnUpdate(float deltaTime)
	{
	}

	public static void GoBack()
	{
	}
}
