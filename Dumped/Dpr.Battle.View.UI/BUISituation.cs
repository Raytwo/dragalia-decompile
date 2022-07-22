using System.Collections.Generic;
using Dpr.Battle.Logic;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Battle.View.UI;

public class BUISituation : BattleViewUICanvasBase
{
	[SerializeField]
	private BUISituationButton[] _situationButtons;

	private Dictionary<int, BTL_POKEPARAM> _monsParams;

	private Dictionary<int, string> _trainerNames;

	private Dictionary<int, Image> _icons;

	public void Initialize()
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

	private void PreparaNextH(bool isForward)
	{
	}

	private void PreparaNextV(bool isForward)
	{
	}

	private void OnSubmit()
	{
	}

	private void OnCancel()
	{
	}
}
