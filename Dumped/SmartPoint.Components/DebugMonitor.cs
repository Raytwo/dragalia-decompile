using System;
using System.Collections.Generic;
using SmartPoint.AssetAssistant;
using UnityEngine;

namespace SmartPoint.Components;

[DisallowMultipleComponent]
public class DebugMonitor : SingletonMonoBehaviour<DebugMonitor>
{
	[Serializable]
	public class LogElement
	{
		public string condition;

		public string stackTrace;

		public bool expand;

		public LogType type;

		public int lineCount;

		public bool autoErase;

		public float life;

		public WeakReference reference;
	}

	[SerializeField]
	private GameObject _menu;

	[SerializeField]
	private LayoutScrollView _mainMonitor;

	[SerializeField]
	private LayoutScrollView _subMonitor;

	[SerializeField]
	private ToggleButton _toggleButton;

	[SerializeField]
	private bool _expandLog;

	[SerializeField]
	private bool _displayOnStart;

	[SerializeField]
	private bool _displayOnError;

	[SerializeField]
	private bool _displayWatch;

	[SerializeField]
	private bool _isVisible;

	public const int MaxLogCount = 256;

	private string _lastCondition;

	private bool _forceDisplay;

	private bool _press;

	private float _remainTime;

	private static List<LogElement> _watchList;

	private static Dictionary<string, LogElement> _watches;

	private int _nextLogID;

	public static string logPath => null;

	public static bool isVisible
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static bool displayWatch
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	protected override bool Awake()
	{
		return default(bool);
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnFliterValueChanged(string value)
	{
	}

	public void ToggleSubMonitor()
	{
	}

	private void UpdateSubMonitor()
	{
	}

	public void Close()
	{
	}

	public void ClearLog()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	public static void Show()
	{
	}

	public static void ShowToggle()
	{
	}

	public static void Output(string label, object value, float life = 10f)
	{
	}

	public static void Subscribe(string label, Func<object> getter, float life = -1f)
	{
	}

	public static void Subscribe(string label, object value, float life = -1f)
	{
	}

	public static void Unsubscribe(string label)
	{
	}

	private void LogCallback(string condition, string stackTrace, LogType type)
	{
	}

	private static string OmittedStackTrace(string stackTrace)
	{
		return null;
	}
}
