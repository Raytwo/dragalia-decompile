using System;
using System.Collections.Generic;
using XLSXContent;

namespace Dpr.Contest;

public class DanceNPC : ADancePlayer
{
	private const float LAUNCH_SKILL_TIME_OFFSET = 0.1f;

	private DanceTapData tapData;

	private NotesDataModel nextNote;

	private ContestMasterDatas.SheetNPCLevelData npcLevelData;

	private double prevElapsedTime;

	private float reserveLaunchSkillTime;

	private float startNoteArriveSec;

	private float limitWaitComboTime;

	private float nextNoteArriveTime;

	private float waitTimer;

	private bool bIsStandbySkill;

	private bool bIsHold;

	private bool bTapActionEnable;

	private bool bIsTutorial;

	public DanceTapData TapData => null;

	public DanceNPC(ContestPlayerEntity entity, CollectNotesDataModel collectNotesData, List<NotesDataModel> notesDataList, Action<ADancePlayer> onLockSkill)
	{
	}

	protected override void Dispose()
	{
	}

	public override void Reset()
	{
	}

	public void ChangeTutorialSetting(bool flag)
	{
	}

	public override void Activate()
	{
	}

	private void SetNextNoteDataPtr()
	{
	}

	public override void DeActivate()
	{
	}

	public void SkipCurrentNotesIndexByTime(float elapsedTime)
	{
	}

	protected override void UpdateAction()
	{
	}

	protected override void UpdateSkill()
	{
	}

	private void UpdateNPCAction()
	{
	}

	private void UpdateNPCTapAction()
	{
	}

	private void StartHold()
	{
	}

	private void FinishHold()
	{
	}

	public void FailedTap()
	{
	}

	private bool CheckUseSkill()
	{
		return default(bool);
	}

	private bool CheckLaunchSkill()
	{
		return default(bool);
	}

	public override void NoticeLaunchSkill(ADancePlayer player)
	{
	}

	private void SetSkillComboTiming()
	{
	}

	private bool CheckLaunchSkillToOtherCombo()
	{
		return default(bool);
	}

	protected override void OnForceLaunchSkill()
	{
	}

	public override void LaunchSkill()
	{
	}

	public override void ActivateSkillEffect(double elapsedTime, Action onFinishSkillEffect)
	{
	}

	private void UpdateSkillEffect()
	{
	}

	protected override void OnChangeMultiMode(bool isHost)
	{
	}
}
