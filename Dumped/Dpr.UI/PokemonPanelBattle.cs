using System;
using System.Collections.Generic;
using Dpr.Battle.Logic;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PokemonPanelBattle : MonoBehaviour
{
	[Serializable]
	private class DetailParam
	{
		public RectTransform root;

		public Image category;

		public UIText power;

		public UIText hitRate;

		public UIText description;
	}

	[Serializable]
	private class TokuseiDetailParam
	{
		public RectTransform root;

		public UIText tokuseiName;

		public UIText tokuseiDescription;
	}

	[Serializable]
	private class MultiTrainerParam
	{
		public RectTransform root;

		public UIText trainerName;

		public Image bg;

		public Sprite[] sprites;
	}

	[SerializeField]
	private UIText _state;

	[SerializeField]
	private RectTransform _infoRoot;

	[SerializeField]
	private TypePanel[] _types;

	[SerializeField]
	private RectTransform _contents;

	[SerializeField]
	private PokemonBattleWazaItem _itemPrefab;

	[SerializeField]
	private Cursor _cursor;

	[SerializeField]
	private DetailParam _detail;

	[SerializeField]
	private TokuseiDetailParam _tokuseiDetail;

	[SerializeField]
	private MultiTrainerParam _multiTrainer;

	private List<PokemonBattleWazaItem> _items;

	private int _selectIndex;

	private bool _showDetail;

	private VerticalLayoutGroup _verticalLayoutGroup;

	private BTL_POKEPARAM _battlePokemonParam;

	private bool _isActived;

	public BTL_POKEPARAM CurrentBTLParam => null;

	private void Awake()
	{
	}

	public void Setup(BTL_POKEPARAM battlePokemonParam, bool isWait, bool isMultiPlayer)
	{
	}

	public void UpdateState(BTL_POKEPARAM bpp, bool isWait)
	{
	}

	private string GetSelectStateLabel(BTL_POKEPARAM bpp, bool isWait)
	{
		return null;
	}

	private void SetupItems()
	{
	}

	private void ShowWazaDetail(bool enabled)
	{
	}

	private void SetupDetail()
	{
	}

	public void SetActive(bool enabled)
	{
	}

	public bool OnUpdate(float deltaTime)
	{
		return default(bool);
	}

	private bool UpdateSelect(float deltaTime)
	{
		return default(bool);
	}

	private bool SetSelectIndex(int selectIndex, bool isInitialize = false)
	{
		return default(bool);
	}
}
