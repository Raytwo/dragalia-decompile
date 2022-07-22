using System.Collections;
using UnityEngine;

namespace Dpr.Contest;

public class ResultSection : MonoBehaviour
{
	private enum ResultState
	{
		WaitStart,
		Announcement,
		TotalScores,
		PersonalPerformance,
		Tutorial,
		Finish
	}

	private ResultSettings resultSettings;

	private ResultAnnouncement resultAnnounce;

	private ResultTotalScores totalScores;

	private ResultPersonalPerformance personalPerformance;

	private ResultTutorialMode tutorialMode;

	private ResultDataModel resultDataModel;

	private ResultState currentState;

	private bool bRunning;

	private bool restartContest;

	private bool isTutorial;

	private WaitForSeconds waitStartResult;

	public bool IsRestart => default(bool);

	public bool IsReady => default(bool);

	public void SetScriptableObject(ResultSettings resultSettings)
	{
	}

	public void Initialize()
	{
	}

	public void ResetParam()
	{
	}

	public void OnFinalize()
	{
	}

	public void Setup(bool isTutorial)
	{
	}

	public void LoadResource(ResultID resultID)
	{
	}

	public void StartSection(ResultDataModel resultDataModel)
	{
	}

	private IEnumerator IE_StartSection(ResultState firstState)
	{
		return null;
	}

	public bool UpdateSection(float deltaTime)
	{
		return default(bool);
	}

	private void UpdateAnnouncement(float deltaTime)
	{
	}

	private void UpdateTotalScores(float deltaTime)
	{
	}

	private void UpdatePersonalPerformance()
	{
	}

	private void UpdateTutorialMode(float deltaTime)
	{
	}

	private void ChangeState(ResultState stateID)
	{
	}

	private RankGaugeData CreateRankGaugeData()
	{
		return null;
	}
}
