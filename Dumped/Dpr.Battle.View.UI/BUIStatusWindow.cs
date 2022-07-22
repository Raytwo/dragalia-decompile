using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dpr.Battle.Logic;
using Dpr.Battle.View.Systems;
using Dpr.UI;
using Pml;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Battle.View.UI;

public class BUIStatusWindow : BattleViewUICanvasBase
{
	[SerializeField]
	private GameObject _pokemonPlate;

	[SerializeField]
	private Image _windowImage;

	[SerializeField]
	private UIText _nameText;

	[SerializeField]
	private Image _sexImage;

	[SerializeField]
	private UIText _lvText;

	[SerializeField]
	private UIText _lvValueText;

	[SerializeField]
	private Image _hpBG;

	[SerializeField]
	private HpBar _hpBar;

	[SerializeField]
	private Slider _expSlider;

	[SerializeField]
	private UIText _hpText;

	[SerializeField]
	private PokemonSick _condPanel;

	[SerializeField]
	private Image _captureImage;

	[SerializeField]
	private GameObject _ballBar;

	[SerializeField]
	private Image[] _pokeBallList;

	private uint _currentHP;

	private uint _maxHP;

	private byte _currentLevel;

	private byte _pokeID;

	private bool _isPlayer;

	private bool _needHpApply;

	private bool _enableBallBar;

	private bool _isTag;

	private float _pokePlateYpos;

	private Vector2 _originalSize;

	private BattleViewSystem.BattleViewSide _side;

	private Sprite[] _ballStateSprites;

	private bool _isInitialized;

	private bool _isCurrentUp;

	private const float _singleOffsetX = 30f;

	private const float _actOffsetY = 10f;

	private const float _ballBarBaseWidth = 168f;

	private const float _ballBarHalfWidth = 114f;

	private const float _hpDuration = 0.7f;

	public bool DoDisplay
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsHpBarPlaying => default(bool);

	public GameObject BallBarObject => null;

	public bool isInitialized => default(bool);

	public bool isReservationClose
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool isReservationOpen
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public override void OnUpdate(float deltaTime)
	{
	}

	protected override void OnShow()
	{
	}

	public HpStatus CurrentHpStatus()
	{
		return default(HpStatus);
	}

	public override void Startup()
	{
	}

	public override void Reset()
	{
	}

	public void Initialize(BtlvPos pos, BTL_POKEPARAM btlParam, byte clientID, [Optional] BTL_PARTY party, [Optional] Sprite[] ballSprites, bool isTrainerBattle = true)
	{
	}

	public override void UnInitialize()
	{
	}

	private void InitBallBar(bool isShowBallBar)
	{
	}

	public void ShowBallBar(bool forceHide)
	{
	}

	public void SetBallBar(BTL_PARTY party)
	{
	}

	private bool IsEnableBallBar(BtlvPos pos, bool isTrainerBattle)
	{
		return default(bool);
	}

	public void Apply(BTL_PARTY party, BTL_POKEPARAM param, bool isImmediate = false, bool isUpPosition = false)
	{
	}

	public void SetCurrentPokemonStatus(bool isUpPosition = false)
	{
	}

	public void SetHPDuration(float duration)
	{
	}

	private void UpdateHPText(int value)
	{
	}

	private void SetName(uint pokeID)
	{
	}

	private void SetSexIcon(Sex sex)
	{
	}

	private void SetPrams(BTL_POKEPARAM btlParam, bool isForced = false)
	{
	}
}
