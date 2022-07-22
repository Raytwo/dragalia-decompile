using System.Collections;
using System.Runtime.CompilerServices;
using Dpr.Battle.Logic;
using Pml;
using TMPro;
using UnityEngine;

namespace Dpr.Battle.View.UI;

public class BUITokuseiPlate : BattleViewUICanvasBase
{
	private const string TokuseiNameMessageLabel = "msg_ui_btl_wazainfo_tokuseiname";

	private const float TOKUSEI_PLATE_WAIT = 0.1f;

	[SerializeField]
	private TextMeshProUGUI _tokuseiText;

	[SerializeField]
	private TextMeshProUGUI _nameText;

	private TokuseiNo _changeNo;

	public bool isSkillSwapOpenAnimation;

	public TokuseiNo _currentNo
	{
		[CompilerGenerated]
		get
		{
			return default(TokuseiNo);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsDisplay
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

	public bool IsStable => default(bool);

	public void Initialize(BTL_POKEPARAM btlParam, bool isEnablePokeName = true)
	{
	}

	public override void OnUpdate(float deltaTime)
	{
	}

	protected override void OnShow()
	{
	}

	protected override void OnHide()
	{
	}

	public void PlayShow()
	{
	}

	public void PlayHide()
	{
	}

	protected override void OnPlayAnimation()
	{
	}

	public void SetChange(TokuseiNo no)
	{
	}

	public void SetTokuseiName(TokuseiNo no)
	{
	}

	public void SetName(uint pokeID)
	{
	}

	private IEnumerator OutCoroutine()
	{
		return null;
	}
}
