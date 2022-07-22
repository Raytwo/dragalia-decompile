using System;
using System.Runtime.InteropServices;
using Dpr.Battle.Logic;
using Effect;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PokemonPartyItem : MonoBehaviour
{
	[Serializable]
	private class Contest
	{
		public RectTransform root;

		public Image bg;

		public UIText text;

		public string[] messageIds;

		public Sprite[] spriteBgs;

		public Color[] colors;
	}

	[Serializable]
	private class RotomSelect
	{
		public RectTransform root;

		public Image bg;

		public UIText text;

		public string messageFile;

		public string[] messageIds;

		public Sprite[] spriteBgs;

		public Color[] colors;
	}

	[Flags]
	public enum StateBits
	{
		Select = 1,
		ItemSwap = 2
	}

	public class Param
	{
		public class Contest
		{
			public bool isEntry;
		}

		public class Battle
		{
			public BTL_POKEPARAM battlePokemonParam;

			public int plateType;
		}

		public class RotomSelect
		{
			public bool isEntry;
		}

		public PokemonParam pokemonParam;

		public bool showItemName;

		public Contest contest;

		public Battle battle;

		public RotomSelect rotomSelect;
	}

	[SerializeField]
	private RectTransform _root;

	[SerializeField]
	private RectTransform _infoRoot;

	[SerializeField]
	private RectTransform _statusRoot;

	[SerializeField]
	private UIText _name;

	[SerializeField]
	private UIText _hp;

	[SerializeField]
	private UIText _maxHp;

	[SerializeField]
	private HpBar _hpBar;

	[SerializeField]
	private Image _hpBG;

	[SerializeField]
	private UIText _level;

	[SerializeField]
	private Image _sex;

	[SerializeField]
	private RectTransform _itemRoot;

	[SerializeField]
	private PokemonIcon _pokemonIcon;

	[SerializeField]
	private PokemonSick _sick;

	[SerializeField]
	private RectTransform _pair;

	[SerializeField]
	private Contest _contest;

	[SerializeField]
	private RotomSelect _rotomSelect;

	[SerializeField]
	private RectTransform _usableItemRoot;

	[SerializeField]
	private float _formChangeLoadIconTiming;

	private int _stateBits;

	private Param _param;

	private bool isShowUsableItem;

	private Vector3 _offsetIconPos;

	private Vector3 _initIconPos;

	private Animator _animator;

	public static readonly int animState0Normal;

	public static readonly int animState0Select;

	public static readonly int animState0DecideContext;

	public static readonly int animState0Decide;

	public static readonly int animState0Disable;

	public static readonly int animState1Stop;

	public static readonly int animState1Sick;

	public static readonly int animState1SelectState0;

	public static readonly int animState1State0;

	public static readonly int animState1SelectState1;

	public static readonly int animState1State1;

	public static readonly int animState1SelectState2;

	public static readonly int animState1State2;

	public static readonly int animState1SelectState3;

	public static readonly int animState1State3;

	public static readonly int animState2Normal0;

	public static readonly int animState2Normal1;

	public static readonly int animState2Exchange0;

	public static readonly int animState2Exchange1;

	public static readonly int animState2Friend0;

	public static readonly int animState2Friend1;

	private Coroutine _coroutine;

	private EffectInstance _effectInstance;

	private bool _isDestroy;

	public Param param => null;

	public PokemonIcon pokemonIcon => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Setup(Param param)
	{
	}

	public void SetEnable(bool enabled)
	{
	}

	public void EnablePairIcon(bool enabled)
	{
	}

	public void SetupItem()
	{
	}

	public void ShowItemName(bool enabled)
	{
	}

	public void ShowUsableItemText(string labelName)
	{
	}

	public void HideUsableItemText()
	{
	}

	public void Select(int stateBits)
	{
	}

	public void Decide(bool isOpenContextMenu)
	{
	}

	private void SetState()
	{
	}

	private void SetIconState(bool isSelect)
	{
	}

	public void ReturnItemInBag()
	{
	}

	public void EnableSwapMode(bool enabled)
	{
	}

	public Vector3 GetSwapPosition()
	{
		return default(Vector3);
	}

	public void SetSwapPosition()
	{
	}

	public void SetSwapPosition(Vector3 pos)
	{
	}

	public void UpdateHp([Optional] Action onComplete)
	{
	}

	public bool FormChange(ushort formNo, [Optional] RectTransform effectRoot, [Optional] Action<PokemonParam> onChangeIcon, [Optional] Action<PokemonParam> onComplete)
	{
		return default(bool);
	}

	private void PlayVoice(PokemonParam pokemonParam, [Optional] Action onComplete)
	{
	}
}
