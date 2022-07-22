using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Dpr.Battle.Logic;
using Pml;
using TMPro;
using UnityEngine;

namespace Dpr.Battle.View.UI;

public sealed class BUIWazaList : BattleViewUICanvasBase, IResultable<int>
{
	public enum ColorForPP
	{
		Normal,
		Warning,
		Danger,
		Empty
	}

	private class PrevWazaData
	{
		public WazaNo wazaNo;

		public int id;

		public PrevWazaData(WazaNo wazaNo, int id)
		{
		}
	}

	private const string WazaNameMessageLabel = "msg_ui_btl_pokewaza";

	private const string WazaDescriptionOpenMessageLabel = "msg_ui_btl_06";

	private const string WazaDescriptionCloseMessageLabel = "msg_ui_btl_07";

	[SerializeField]
	private BUIButton _wazaDescriptionButton;

	[SerializeField]
	private BUIWazaButton[] _wazaButtons;

	[SerializeField]
	private Sprite[] _wazaTypeSprites;

	[SerializeField]
	private Sprite[] _effectBgSprites;

	[SerializeField]
	private TextMeshProUGUI _yButtonText;

	[SerializeField]
	private Color _ppColorNormal;

	[SerializeField]
	private Color _ppColorWarning;

	[SerializeField]
	private Color _ppColorDanger;

	[SerializeField]
	private Color _ppColorEmpty;

	private BTL_ACTION_PARAM_OBJ _destActionParam;

	private List<BTLV_WAZA_INFO?> _btlvWazaInfos;

	private BTL_POKEPARAM _btlPokeParam;

	private int _wazaCount;

	private Dictionary<int, PrevWazaData> _prevUseWazas;

	private int _pokeIndex;

	public int Result
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public override void Startup()
	{
	}

	public void Initialize(BTL_POKEPARAM bpp, byte pokeIndex, BTL_ACTION_PARAM_OBJ dest)
	{
	}

	public void Remove()
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

	public void SetSelect(int num)
	{
	}

	public void ResetSelect()
	{
	}

	private void OnSubmitWazaDescription()
	{
	}

	private void OnSelectedWazaButton(BUIWazaButton button)
	{
	}

	private void OnSubmitWazaButton(BUIWazaButton button)
	{
	}

	private void OnSubmit()
	{
	}

	private void OnCancel()
	{
	}

	private void SetYbuttonText(bool isDescriptionShow)
	{
	}

	public void SetInvalid()
	{
	}

	public void ExecuteCurrentButton()
	{
	}

	private WazaNo GetSelectedWazaNo(int pokemonIndex, int id)
	{
		return default(WazaNo);
	}

	private void UpdateSelectedWazaNo(int pokemonIndex, int id, WazaNo selectdWazaNo)
	{
	}
}
