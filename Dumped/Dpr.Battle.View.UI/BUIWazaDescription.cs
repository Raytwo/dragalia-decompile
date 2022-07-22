using Dpr.UI;
using Pml;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Battle.View.UI;

public class BUIWazaDescription : BattleViewUICanvasBase
{
	[SerializeField]
	private Image _bgImage;

	[SerializeField]
	private TypePanel _typePanel;

	[SerializeField]
	private TextMeshProUGUI _wazaNameText;

	[SerializeField]
	private TextMeshProUGUI _ppCountText;

	[SerializeField]
	private TextMeshProUGUI _ppMaxText;

	[SerializeField]
	private WazaCategoryPanel _wazaCategory;

	[SerializeField]
	private UIText _powerText;

	[SerializeField]
	private UIText _dexText;

	[SerializeField]
	private TextMeshProUGUI _descriptionText;

	[SerializeField]
	private RectTransform _connectorLeft;

	[SerializeField]
	private RectTransform _connectorVirtival;

	[SerializeField]
	private RectTransform _connectorRight;

	[SerializeField]
	private Image[] _connectorImages;

	public void Initialize(BTLV_WAZA_INFO info, float posY)
	{
	}

	public override void OnUpdate(float deltaTime)
	{
	}

	private void SetPokeType(PokeType type)
	{
	}

	private void SetWazaDamageType(WazaNo wazaNo)
	{
	}

	private void SetConnector(float posY)
	{
	}
}
