using System.Collections;
using System.Collections.Generic;
using Dpr.Demo;
using Dpr.MsgWindow;
using Pml;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class PokemonStatusWindow : UIWindow
{
	private enum PanelType
	{
		BasicInfo,
		TrainerMemo,
		Ability,
		Waza,
		Condition,
		ContestWaza,
		Ribbon
	}

	public class Param
	{
		public class TrainingParam
		{
			public ItemNo itemNo;

			public UnityAction onTraining;
		}

		public enum LimitType
		{
			None,
			Battle,
			BoxOtherStatus,
			BoxSelect,
			ZukanRegister
		}

		public class BoxParam
		{
			public int tray;

			public int pos;

			public bool isPrevExchangePartner;
		}

		public List<PokemonParam> pokemonParams;

		public int selectIndex;

		public int selectTabIndex;

		public TrainingParam training;

		public LimitType limitType;

		public List<BoxParam> boxParams;
	}

	[SerializeField]
	private RectTransform _messageWindowRoot;

	[SerializeField]
	private UIText _panelTitle;

	[SerializeField]
	private PokemonStatusTab[] _tabs;

	[SerializeField]
	private Image[] _imageTabCorners;

	[SerializeField]
	private UIPokeStatusSelectPanel _uiPokeStatus;

	[SerializeField]
	private GameObject _aButton;

	[SerializeField]
	private PokemonModelView _modelView;

	[SerializeField]
	private Image[] _arrows;

	private List<PokemonStatusTab> _activeTabs;

	private List<PokemonStatusTab> _enableTabs;

	private List<int> BattlePanelList;

	private int _selectIndex;

	private int _selectTabIndex;

	private Param _param;

	private static ConditionParam _conditionParam;

	private static bool _isClosedPofinEating;

	public int selectIndex => default(int);

	private void Awake()
	{
	}

	public override void OnCreate()
	{
	}

	public void OpenForBattle(Param param, UIWindowID prevWindowId)
	{
	}

	public void Open(Param param, UIWindowID prevWindowId)
	{
	}

	public IEnumerator OpOpen(Param param, UIWindowID prevWindowId)
	{
		return null;
	}

	public void Close(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
	}

	public IEnumerator OpClose(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
		return null;
	}

	private void UpdateBoxPokemonParams()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private bool UpdateSelect(float deltaTime)
	{
		return default(bool);
	}

	private bool SetSelectIndex(int selectIndex, int move, bool isInitialized = false)
	{
		return default(bool);
	}

	private void SetupTabs()
	{
	}

	private void SetupPanel()
	{
	}

	private void onChangeMemberSelectArrow(bool isShow)
	{
	}

	private void OnChangeAbuttonGuide(bool isShow, string messageFile, string messageLabel)
	{
	}

	private void OnOpenBag()
	{
	}

	private void OnOpenBagOfWazaMachine(bool isContest)
	{
	}

	private void OnOpenPofinCase()
	{
	}

	private void OnOpenMessageWindow(MsgWindowParam messageParam)
	{
	}

	private void OnForceClosed()
	{
	}

	protected override void OpenMessageWindow(MsgWindowParam messageParam)
	{
	}

	private bool UpdateSelectTab(float deltaTime)
	{
		return default(bool);
	}

	private bool SetSelectTabIndex(int selectTabIndex, int move, bool isForce = false)
	{
		return default(bool);
	}

	private void PlayAnimTabArrow(int move)
	{
	}

	public static void SetPofinEatParam(ConditionParam conditionParam, bool isClosed = true)
	{
	}

	public static ConditionParam GetConditionParam()
	{
		return null;
	}

	public static bool IsPofinEatingMode()
	{
		return default(bool);
	}

	public static bool IsClosedPofinEating()
	{
		return default(bool);
	}
}
