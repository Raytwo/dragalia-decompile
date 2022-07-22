using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dpr.Battle.Logic;
using Dpr.UI;
using Pml.WazaData;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Battle.View.UI;

public class BUITargetSelect : BattleViewUICanvasBase
{
	private enum BoardIndex
	{
		Up,
		Down,
		Left,
		Right
	}

	private static BtlvPos[] _searchOrder;

	[SerializeField]
	private BUITargetButton[] _targetButtons;

	[SerializeField]
	private TargetSelectCursor _targetCursor;

	[SerializeField]
	private Image[] _boardImage;

	private BTL_ACTION_PARAM_OBJ _destActionParam;

	private BtlvPos _actionVPos;

	private WazaTarget _targetType;

	[SerializeField]
	private WazaTarget _overrideTargetType;

	private Dictionary<int, BtlvPos> _prevTargetPos;

	private int _pokeIndex;

	private bool _isSingleTarget;

	private Dictionary<BtlvPos, BTL_POKEPARAM> currentFieldPokeParams;

	public BtlPokePos Result
	{
		[CompilerGenerated]
		get
		{
			return default(BtlPokePos);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public override void Startup()
	{
	}

	public void Initialize(byte pokeIndex, BTL_POKEPARAM bpp, BTL_ACTION_PARAM_OBJ dest)
	{
	}

	public override void OnUpdate(float deltaTime)
	{
	}

	protected override void OnShow()
	{
	}

	public void SetFocus(int index)
	{
	}

	private int GetTargetIndex()
	{
		return default(int);
	}

	private void SetBoardImageState(bool isEnable, int altIndex = -1)
	{
	}

	private void PreparaNextH(bool isForward)
	{
	}

	private void PreparaNextV(bool isForward)
	{
	}

	private void SetTargetButton(WazaTarget tagetType, BtlvPos actionVPos, BUITargetButton button, BtlvPos buttonVPos, [Optional] BTL_POKEPARAM btlParam, [Optional] Sprite effectiveSprite, string effectiveStr = "")
	{
	}

	private void OnSubmit()
	{
	}

	private void OnCancel()
	{
	}
}
