using DG.Tweening;
using Dpr.MsgWindow;
using Dpr.SubContents;
using UnityEngine;

namespace Dpr.Contest;

public class ResultTotalScores : MonoBehaviour
{
	private enum StateID
	{
		Admission,
		StartAnnounce,
		GaugeAnim,
		AnnounceWinner,
		Leave,
		Wait,
		End
	}

	private class EnvControllerAnimation
	{
		private const float LIGHT_TWEEN_DURATION = 0.3f;

		private EnvironmentController envController;

		private Color toColor;

		private Color defaultColor;

		public EnvControllerAnimation(EnvironmentController envController, Color toColor)
		{
		}

		public void DoForward()
		{
		}

		public void DoBackward()
		{
		}
	}

	private readonly int animHash;

	[SerializeField]
	private Color toEnvLightColor;

	[SerializeField]
	private ResultScoreGauge[] playerScoreGaugeArray;

	private ResultPlayerDataModel[] playerDataArray;

	private int[] playerScoreArray;

	private EnvControllerAnimation envAnimation;

	private ShowMessageWindow resultMsg;

	private WaitTimer waitTimer;

	private ResultSettings settingsData;

	private DOTweenAnimation fadeTween;

	private StateID currentState;

	private StateID nextStateID;

	private ResultID resultID;

	private Sprite medalSpr;

	private float waitDuration;

	private float timer;

	private int announcedPlayerIndex;

	private int maxTotalScore;

	private int bestPerformerNum;

	private bool bRunning;

	private bool bStopUpdate;

	private bool bIsUserBestPerformer;

	public void Initialize(ResultSettings setting)
	{
	}

	public void OnFinalize()
	{
	}

	public void Setup(ResultDataModel resultDataModel)
	{
	}

	public void StartAnimation()
	{
	}

	private void ChangeState(StateID nextStateID)
	{
	}

	private void ChangeStartAnnnounce()
	{
	}

	private void ChangeGaugeAnim()
	{
	}

	private void ChangeStateAnnounceWinner()
	{
	}

	private void ChangeStateLeave()
	{
	}

	private void ChangeStateEnd()
	{
	}

	private void TransitionWaitState(StateID nextStateID, float waitDuration)
	{
	}

	public bool OnUpdate(float deltaTime)
	{
		return default(bool);
	}

	private void UpdateGaugeAnim(float deltaTime)
	{
	}

	private void UpdateAnounceWinner(float deltaTime)
	{
	}

	private void UpdateWait(float deltaTime)
	{
	}
}
