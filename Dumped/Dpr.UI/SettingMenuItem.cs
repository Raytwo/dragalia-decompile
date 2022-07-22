using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class SettingMenuItem : MonoBehaviour
{
	public enum ItemType
	{
		Selector,
		Gauge,
		WindowSelector
	}

	[Serializable]
	private class SelectorParam
	{
		public Color[] textColors;
	}

	[Serializable]
	private class WindowSelectorParam
	{
		public Image[] arrows;

		public Color[] textColors;

		public Color[] arrowColors;
	}

	[Serializable]
	private class GaugeSelectorParam
	{
		public Image gaugeBg;

		public Image gauge;

		public Image handle;

		public Color[] gaugeBgColors;

		public Color[] gaugeColors;

		public Sprite[] spriteHandles;

		public Color[] textColors;
	}

	[SerializeField]
	private ItemType _itemType;

	[SerializeField]
	private RectTransform _contentRoot;

	[SerializeField]
	private Image _selectBg;

	[SerializeField]
	private SelectorParam _selectorParam;

	[SerializeField]
	private WindowSelectorParam _windowSelectorParam;

	[SerializeField]
	private GaugeSelectorParam _gaugeSelectorParam;

	private UnityAction<SettingMenuItem> _onValueChanged;

	private ConfigID _configId;

	private string _descMessageLabel;

	private RectTransform _content;

	private int _selectIndex;

	private List<UIText> _texts;

	private Slider _slider;

	private UIText _sliderText;

	public ConfigID configId => default(ConfigID);

	public string descMessageLabel => null;

	public int selectIndex => default(int);

	public int valueCount => default(int);

	public bool isSelect => default(bool);

	public ItemType itemType => default(ItemType);

	public void Setup(ConfigID configId, int selectIndex, string descMessageLabel, UnityAction<SettingMenuItem> onValueChanged)
	{
	}

	private void SetupContent()
	{
	}

	public bool SetSelectIndex(int selectIndex, bool isEqualChecked = true, bool isCallbacked = true)
	{
		return default(bool);
	}

	public void Select(bool enabled)
	{
	}
}
