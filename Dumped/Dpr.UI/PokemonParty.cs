using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class PokemonParty : MonoBehaviour
{
	public class Param
	{
		public List<PokemonPartyItem.Param> itemParams;

		public int selectIndex;

		public bool isMultiBattle;
	}

	[SerializeField]
	private RectTransform _contentRoot;

	[SerializeField]
	private RectTransform _basePlateRoot;

	[SerializeField]
	private Sprite[] _spriteBasePlates;

	private List<PokemonPartyItem> _activeItems;

	private int _selectIndex;

	private VerticalLayoutGroup _verticalLayoutGroup;

	private PokemonPartyItem _fromSwapItem;

	private int _fromSwapSiblingIndex;

	private UnityAction<PokemonPartyItem, PokemonPartyItem> _onSwapChanged;

	private PokemonPartyItem _fromItemSwapItem;

	private UnityAction<PokemonPartyItem, PokemonPartyItem, bool, bool> _onItemSwapChanged;

	private bool _isActived;

	private UIInputController _input;

	public UnityAction<PokemonPartyItem, int> onClicked;

	public UnityAction<PokemonPartyItem, int> onSelectChanged;

	private Param _param;

	public Param param => null;

	public List<PokemonPartyItem> items => null;

	public int selectIndex => default(int);

	private void Awake()
	{
	}

	public void Setup(Param param)
	{
	}

	private void SetupActiveItems()
	{
	}

	public void SetActive(bool enabled, bool isSelectChanged = false)
	{
	}

	public bool OnUpdate(float deltaTime, UIInputController input)
	{
		return default(bool);
	}

	private void UpdateSelect(float deltaTime)
	{
	}

	private bool UpdateSwap(float deltaTime)
	{
		return default(bool);
	}

	private bool UpdateItemSwap(float deltaTime)
	{
		return default(bool);
	}

	public bool SetSelectIndex(int selectIndex, bool isInitialize = false)
	{
		return default(bool);
	}

	public void ResetSelectIndex()
	{
	}

	public PokemonPartyItem GetSelectedItem()
	{
		return null;
	}

	public void BeginSwap(UnityAction<PokemonPartyItem, PokemonPartyItem> onSwapChanged)
	{
	}

	public bool IsSwapMode()
	{
		return default(bool);
	}

	public void BeginItemSwap(UnityAction<PokemonPartyItem, PokemonPartyItem, bool, bool> onSwapChanged)
	{
	}

	public void SetBasePlateType(int index, int plateType)
	{
	}
}
