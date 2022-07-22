using DG.Tweening;
using Dpr.SubContents;
using UnityEngine;
using UnityEngine.UI;
using XLSXContent;

namespace Dpr.Contest;

public class UIContestSkillInfo : MonoBehaviour
{
	[SerializeField]
	private GameObject template;

	private UILaunchSkillLog[] skillLogArray;

	private Sprite[] chainCountSprArray;

	private RectTransform commandIconTransform;

	private RectTransform chainCountContentRect;

	private GameObject acceptChainGaugeObj;

	private Image acceptChainGaugeImage;

	private DOTweenAnimation[] chainCountTweenArray;

	private DOTweenAnimation[] commandAppealTween;

	private EffectEmitter fxEmitter;

	private GameObject chainCountObj;

	private Image chainCountImage;

	private CanvasGroup appealCanvasGroup;

	private float showSkillLogDuration;

	private float showChainCountDuration;

	private float showChainCountTimer;

	private int showLogCount;

	private bool bIsShowCommand;

	private bool bIsShowChainCount;

	private bool bPlayingCommandAppealTween;

	public bool IsShowLog => default(bool);

	private bool IsUpdateChainGauge => default(bool);

	public void Initialize()
	{
	}

	private void InitChainCount()
	{
	}

	private void SetChainCountSprArray()
	{
	}

	public bool IsReady()
	{
		return default(bool);
	}

	public void OnFinalize()
	{
	}

	public void ResetParam()
	{
	}

	public void Setup(ContestConfigDatas configDatas, ContestPlayerEntity[] entities, bool isTutorial)
	{
	}

	private void SetSkillUser(int logIndex, ContestPlayerEntity entity, Transform parent)
	{
	}

	public void UseContestSkill(int playerIndex, int chainCount, bool isShowChainCount, bool canChain, bool isShowChainCountFx, bool isSameUserWazaType)
	{
	}

	private void ShowChainCount(int chainCount, bool isShowFx)
	{
	}

	private void PlayChainCountFx()
	{
	}

	private void StopChainCountFx()
	{
	}

	public void HideUserContestSkill()
	{
	}

	public void PlayCommandAppealTween()
	{
	}

	private void StopCommandAppealTween()
	{
	}

	private void SetCommandActive(bool active)
	{
	}

	private void ShowAcceptChainGauge()
	{
	}

	private void ShowLaunchSkillLog(int playerIndex, bool isSameUserWazaType)
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	private void UpdateUIChainCount(float deltaTime)
	{
	}

	public void OnCompleteBackWards()
	{
	}

	public void UpdateChainGauge(float gaugeRatio)
	{
	}

	public void UpdateChainGaugeHideTime(float deltaTime)
	{
	}

	public void HideChainGauge()
	{
	}

	private void SetAcceptChainGaugeActive(bool active)
	{
	}
}
