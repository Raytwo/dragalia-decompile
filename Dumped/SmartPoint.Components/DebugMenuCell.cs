using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SmartPoint.Components;

public class DebugMenuCell : LayoutCellObserver, IMoveHandler, IEventSystemHandler, IScrollHandler
{
	public enum Controller
	{
		Text,
		SubMenu,
		Slider,
		Selector,
		List,
		Checkbox
	}

	public delegate int InputIntegerDelegate();

	public delegate float InputFloatDelegate();

	public delegate void OutputIntegerDelegate(int value);

	public delegate void OutputFloatDelegate(float value);

	public delegate string[] InputStringArrayDelegate();

	public delegate string UpdateTextDelegate(int value);

	public delegate string UpdateInformationDelegate(int value = 0);

	public delegate void Click([Optional] object reference);

	public delegate void SelectedIndexChanged(int selected);

	public class Item
	{
		public Controller controllerType;

		public string text;

		public string[] values;

		public int selected;

		public InputFloatDelegate inputFloatValue;

		public InputIntegerDelegate inputIntegerValue;

		public OutputFloatDelegate outputFloatValue;

		public OutputIntegerDelegate outputIntegerValue;

		public InputStringArrayDelegate inputStringArrayValue;

		public float minValue;

		public float maxValue;

		public int low;

		public int high;

		public int decimals;

		public Click onClick;

		public SelectedIndexChanged onSelectedIndexChanged;

		public object reference;

		public UpdateTextDelegate updateText;

		public UpdateInformationDelegate updateInformation;

		public Item(string text, Click onClick, object reference, UpdateInformationDelegate updateInformation, bool isChild = false)
		{
		}

		public Item(string text, InputFloatDelegate input, OutputFloatDelegate output, float minValue, float maxValue, int decimals)
		{
		}

		public Item(string text, SelectedIndexChanged onSelect, InputIntegerDelegate selected, string[] values, Click onClick, UpdateInformationDelegate updateInformation)
		{
		}

		public Item(string text, SelectedIndexChanged onSelect, InputIntegerDelegate selected, InputStringArrayDelegate inputList, Click onClick, UpdateInformationDelegate updateInformation)
		{
		}

		public Item(string text, InputIntegerDelegate input, OutputIntegerDelegate output, int low, int high, Click onClick, UpdateTextDelegate updateText, UpdateInformationDelegate updateInformation)
		{
		}

		public bool SetListElements(string[] newValues)
		{
			return default(bool);
		}

		public void SetClickDelegate(Click newOnClick)
		{
		}
	}

	private static DebugMenuCell _currentSelected;

	private static DebugMenuCell _previousSelected;

	private static int _lastDPadH;

	private static int _lastDPadV;

	public LayoutScrollView.Cell _cell;

	public TextMeshProUGUI _contentText;

	public Button _button;

	public Slider _slider;

	public TextMeshProUGUI _valueText;

	public override Vector2 sizeDelta => default(Vector2);

	public void OnScroll(PointerEventData eventData)
	{
	}

	public override void OnSelect(BaseEventData eventData)
	{
	}

	public override void OnUpdate(float deltaTime)
	{
	}

	public void UpdateInformation()
	{
	}

	public void OnMove(AxisEventData axisEventData)
	{
	}

	private static void ChangedControllerParameter(DebugMenuCell observer, Vector2 moveVector, int scale)
	{
	}

	public override bool OnRebuildLayout()
	{
		return default(bool);
	}

	public void OnClick()
	{
	}

	public void OnSliderValueChanged(float value)
	{
	}

	public override bool IsReady()
	{
		return default(bool);
	}

	public override void OnClose()
	{
	}
}
