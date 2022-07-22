using System.Collections.Generic;
using Dpr.Battle.Logic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Battle.View.UI;

public class BUISituationDetail : BattleViewUICanvasBase
{
	private enum BattleEffectIndex
	{
		TOKUSEI,
		ITEM,
		STATUS_TOP
	}

	[SerializeField]
	private List<BUIButton> _lrButtons;

	[SerializeField]
	private RectTransform _cursorBase;

	[SerializeField]
	private Image _pokeImage;

	[SerializeField]
	private TextMeshProUGUI _lvText;

	[SerializeField]
	private TextMeshProUGUI _lvValue;

	[SerializeField]
	private Image _genderImage;

	[SerializeField]
	private TextMeshProUGUI _nameText;

	[SerializeField]
	private Slider _expSlider;

	[SerializeField]
	private TextMeshProUGUI _hpText;

	[SerializeField]
	private List<BUISituationDescriptionButton> _itemButtons;

	[SerializeField]
	private ScrollRect _scrollRect;

	[SerializeField]
	private BUISituationDescriptionButton _itemButtonPrefab;

	[SerializeField]
	private Image[] _blankItems;

	[SerializeField]
	private VerticalLayoutGroup _verticalLayout;

	[SerializeField]
	private GameObject _descriptionPanel;

	[SerializeField]
	private TextMeshProUGUI _descriptionText;

	[SerializeField]
	private BUISituationParam[] _params;

	[SerializeField]
	private GameObject _trainerPanel;

	[SerializeField]
	private TextMeshProUGUI _trainerName;

	private int _pokeIndex;

	private List<BTL_POKEPARAM> _pokeList;

	private List<string> _trainerNames;

	private List<Image> _icons;

	private readonly (string, BTL_POKEPARAM.ValueID)[] _paramIDs;

	private List<(string, string, string)> _statusTexts;

	private const string BTL_STATE_HEADER = "BTR_STATE_";

	private const string BTL_STATE_NAME_FOOTER = "_01";

	private const string BTL_STATE_DSCRIPTION_FOOTER = "_02";

	private readonly Dictionary<EffectType, string> _fieldIDs;

	private readonly Dictionary<BtlWeather, string> _weatherIDs;

	private readonly Dictionary<BtlGround, string> _groundIDs;

	private readonly Dictionary<BtlSideEffect, string> _sideIDs;

	public void Initialize(List<BTL_POKEPARAM> pokeList, List<string> trainerNames, List<Image> icons, int index)
	{
	}

	private void Initialize()
	{
	}

	public override void UnInitialize()
	{
	}

	public override void OnUpdate(float deltaTime)
	{
	}

	protected override void PreparaNext(bool isForward)
	{
	}

	protected override void OnShow()
	{
	}

	protected override void OnHide()
	{
	}

	private void SetPokeStatus(BTL_POKEPARAM btlParam, int index)
	{
	}

	private int SetFieldStatus()
	{
		return default(int);
	}

	private void SelectButton(bool isPlayse = true)
	{
	}

	private void OnChangePoke(bool isForward)
	{
	}

	private void ResetStatusButtons()
	{
	}

	private void OnCancel()
	{
	}
}
