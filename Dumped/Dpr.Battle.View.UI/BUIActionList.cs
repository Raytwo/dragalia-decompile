using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dpr.Battle.Logic;
using Dpr.Item;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Battle.View.UI;

public sealed class BUIActionList : BattleViewUICanvasBase, IResultable<BtlAction>
{
	public enum ActionButtonType
	{
		Fight,
		Pokemon,
		Bag,
		Escape,
		Return,
		SafariBall,
		SafariFood,
		SafariMud,
		SafariEscape
	}

	[SerializeField]
	private GameObject _xyButtonFrame;

	[SerializeField]
	private GameObject _yButtonFrame;

	[SerializeField]
	private BUIButton _pokeBallButton;

	[SerializeField]
	private BUIButton _situationButton;

	[SerializeField]
	private VerticalLayoutGroup _buttonLayout;

	[SerializeField]
	private List<BUIActionSelectButton> _actionButtons;

	[SerializeField]
	private Image _xyMenuBallIcon;

	private bool _isBallEnable;

	private bool _needOpenBallWindow;

	private bool _isSafari;

	private bool isButtonAction;

	private int _minIndex;

	private int _maxIndex;

	public bool IsReturnable
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

	public BtlAction Result
	{
		[CompilerGenerated]
		get
		{
			return default(BtlAction);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public override void Startup()
	{
	}

	public void Initialize([In] ref BattleViewBase.SelectActionParam param)
	{
	}

	private List<ItemInfo> GetExistBalls()
	{
		return null;
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

	public void ResetSelect()
	{
	}

	public void UpdateActionButton(bool isPlaySe = true)
	{
	}

	private void OnSubmitPokeBall()
	{
	}

	private void OnSubmitActionButton(BUIActionSelectButton button)
	{
	}

	private void OnSubmit()
	{
	}

	private void OnCancel()
	{
	}

	public void SetCursor(ActionButtonType target)
	{
	}

	public void ExecuteCurrentButton()
	{
	}
}
