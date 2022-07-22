using DG.Tweening;
using Dpr.SubContents;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Contest;

public class ResultAnnouncement : MonoBehaviour
{
	private enum AnimStateID
	{
		TweenAnim,
		GaugeAnim,
		RankupAnim,
		Wait,
		End
	}

	[SerializeField]
	private Sprite[] rankNumSprArray;

	private DOTweenAnimation titleFadeTween;

	private Image resultTitleImage;

	private DOTweenAnimation rankGaugeFadeTween;

	private Image rankGaugeImage;

	private Image rankNumImage;

	private EffectEmitter fxEmitter;

	private RankGaugeData gaugeData;

	private ShowMessageWindow resultMsg;

	private ResultSettings settingsData;

	private Sprite rankLogoSpr;

	private AnimStateID currentState;

	private ResultID resultId;

	private float waitTimer;

	private float gaugeTimer;

	private int nextRankPoint;

	private int addValue;

	private bool bRunning;

	private bool isRankup;

	private bool isMultiMode;

	public bool IsReady => default(bool);

	public void Initialize(ResultSettings setting)
	{
	}

	private void InitResultTitle()
	{
	}

	private void InitRankGauge()
	{
	}

	public void OnFinalize()
	{
	}

	public void LoadResultFx(ResultID resultID)
	{
	}

	public void Setup(RankGaugeData gaugeData, Sprite spr, bool isMultiMode, ResultID resultId)
	{
	}

	public void StartAnimation()
	{
	}

	public bool OnUpdate(float deltaTime)
	{
		return default(bool);
	}

	private void UpdateGauge(float deltaTime)
	{
	}

	private bool CheckRankUp()
	{
		return default(bool);
	}

	private void SetGaugeRatio(float gaugeRatio)
	{
	}

	private void SetGaugeAnimParam()
	{
	}

	private int GetNextRankPoint()
	{
		return default(int);
	}

	private bool IsMaxRank()
	{
		return default(bool);
	}

	private void StopGaugeSE()
	{
	}

	private void UpdateRankupAnim()
	{
	}

	private void ChangeUserRank()
	{
	}

	private void UpdateWait(float deltaTime)
	{
	}

	private void StartFadeout()
	{
	}

	public void OnCompleteTitleFade()
	{
	}

	private float CalcInitGaugeRatio()
	{
		return default(float);
	}

	public void OnCompleteTitleFadeBackWards()
	{
	}

	public void OnCompleteRankInfoFade()
	{
	}
}
