using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Dpr.MsgWindow;
using UnityEngine;

namespace Dpr.Contest;

public class DanceSection : MonoBehaviour
{
	private DanceSettings danceSettingData;

	private UIPlayerStatus uiPlayerStatus;

	private UIContestSkillInfo uiSkillInfo;

	private NotesLane notesLane;

	private ScoreGauge scoreGauge;

	private UIMusicProgressBar uiMusicProgress;

	private ContestMatchingNetwork network;

	private ADancePlayer[] dancePlayerArray;

	private DOTweenAnimation uiDanceFadeTween;

	private WaitForSeconds waitUIFadeTween;

	private WaitForSeconds waitIconJumpTween;

	private WaitForSeconds waitUserWazaAfter;

	private DanceSectionDataModel dataModel;

	private WazaSequencePlayer wazaSeqPlayer;

	private Queue<EmitHeartData> emitHeartDataQueue;

	private List<DanceHeartEffect> activeDanceHeartList;

	private List<Coroutine> runningCoroutineList;

	private SceneObjectManager manager;

	private WaitTimer waitEmitHeartTimer;

	private float elapsedTime;

	private float deltaTime;

	private float userSkillDuration;

	private bool isTutorial;

	private bool active;

	private bool lockEmitHeartFlag;

	private bool isBlockLockSkill;

	private bool isFinishDance;

	public bool IsActive => default(bool);

	public void SetScriptableObject(DanceSettings danceSettingData)
	{
	}

	public void Initialize()
	{
	}

	public void OnFinalize()
	{
	}

	public void ResetParam(DanceSectionData danceSectionData)
	{
	}

	public void Setup(ContestDataModel contestDataModel, bool isTutorial)
	{
	}

	private void CreatePlayerData(ContestPlayerEntity[] entities, DanceSectionData danceSectionData)
	{
	}

	private float CalcSkillAnimDuration(float skillAnimDuration, int restNoteNum)
	{
		return default(float);
	}

	public void SetProgressIconSpr(Sprite iconSpr)
	{
	}

	public void SetupNetwork(ContestMatchingNetwork network, float syncScoreSpan)
	{
	}

	public bool IsReady()
	{
		return default(bool);
	}

	public void StartSection()
	{
	}

	private IEnumerator IE_StartSection(Action onComplete)
	{
		return null;
	}

	public void Stop()
	{
	}

	public void HideDanceUI()
	{
	}

	public void FinishSection()
	{
	}

	private IEnumerator IE_WaitFinish(Action onComplete)
	{
		return null;
	}

	public ResultID CheckDanceScoreResult()
	{
		return default(ResultID);
	}

	public bool UpdateSection(float deltaTime, float elapsedTime)
	{
		return default(bool);
	}

	private void CheckCreateNote()
	{
	}

	private void CreateNotesBg(NotesDataModel noteDataModel)
	{
	}

	private void OnDeactiveNote(NoteIcon targetIcon)
	{
	}

	private void OnArrivedNote(NoteTypeID noteType)
	{
	}

	private void OnThrowLongEndNote()
	{
	}

	private void UpdatePlayer(float elapsedTime)
	{
	}

	private void UserAction(DanceUser player)
	{
	}

	private void NPCAction(DanceNPC npc)
	{
	}

	private void OtherPlayerAction(DanceOtherUser player)
	{
	}

	private void UserTap(int userIndex, DanceTapData tapData)
	{
	}

	private void UserReleaseHold(int userIndex, DanceTapData tapData)
	{
	}

	private void NPCTap(int playerIndex, DanceTapData tapData)
	{
	}

	private void NPCReleaseHold(int playerIndex, DanceTapData tapData)
	{
	}

	private void PlayerTapActionResult(int playerIndex, PlayerType playerType, NoteTapTimingID timingID)
	{
	}

	private void ShowUITimingGrade(NoteTapTimingID timingID)
	{
	}

	private void UpdateContestWaza()
	{
	}

	public void ForceLaunchContestWazaFromSeq()
	{
	}

	private void OnLockContestSkill(ADancePlayer player)
	{
	}

	private void LaunchContestSkill(ADancePlayer player)
	{
	}

	private void ShowSkillUI(ADancePlayer player, bool isPrevSameWazaType, bool isSameUserWazaType)
	{
	}

	private IEnumerator IE_DoActivePlayerSkillAnimation(ADancePlayer player, Action onFinishAnim, Action onComplete)
	{
		return null;
	}

	private IEnumerator IE_DoNonActivePlayerSkillAnimation(float duration, Action onComplete)
	{
		return null;
	}

	private PlayerDanceDataModel CalcScoreAfterContestWaza(ADancePlayer player, float checkElapsedTime)
	{
		return null;
	}

	private void CheckSkillComboBonus(int playerIndex)
	{
	}

	private void UpdateUI()
	{
	}

	private void UpdateProgressGauge()
	{
	}

	private void EmitHeart(int playerIndex, PlayerType playerType)
	{
	}

	private void UpdateEmitHeart(float deltaTime)
	{
	}

	private void UpdateChainGauge()
	{
	}

	private void UpdateHeartEffect()
	{
	}

	public void OnLateUpdate()
	{
	}

	private void DoPlayAllTween(bool forward)
	{
	}

	private void DoPlayUIDanceTween(bool forward)
	{
	}

	public void OnLeaveOtherPlayer(int index)
	{
	}

	public void OnChangeHostMine()
	{
	}

	private void SendScoreData(ADancePlayer player)
	{
	}

	private void SendLaunchSkillData(ADancePlayer player)
	{
	}

	private bool CheckCanSendPacket(ADancePlayer player)
	{
		return default(bool);
	}

	public void ReceiveScore(ScoreNetData scoreData)
	{
	}

	public void ReceiveLaunchSkill(LaunchSkillNetData launchSkillData)
	{
	}
}
