using System;
using System.Collections.Generic;

namespace Dpr.Contest;

public abstract class ADancePlayer
{
	public enum ActionID
	{
		None,
		Tap,
		StartHold,
		Release,
		LaunchSkill
	}

	protected List<NotesDataModel> notesDataList;

	protected PlayerDanceDataModel danceData;

	protected PlayerType playerType;

	protected Action<ADancePlayer> onLockSkill;

	protected ActionID currentActionID;

	protected double currentElapsedTime;

	protected double sendScoreDataSpan;

	protected double sendScoreDataTimer;

	protected float skillAnimDuration;

	protected float reservedLaunchElapsedTime;

	protected float lastNoteArriveTime;

	protected int playerIndex;

	protected bool bForceLaunchSkillFlag;

	protected bool bIsMultiMode;

	protected bool bIsActive;

	public float SkillAnimDuration => default(float);

	public bool IsActive => default(bool);

	public int PlayerIndex => default(int);

	public ActionID CurrentActionID => default(ActionID);

	public PlayerType PlayerType => default(PlayerType);

	public ADancePlayer(int playerIndex, List<NotesDataModel> notesDataList, Action<ADancePlayer> onLockSkill)
	{
	}

	private float CalcLastNoteArriveTime()
	{
		return default(float);
	}

	public void SetSkillAnimDuration(float skillAnimDuration)
	{
	}

	public virtual void Reset()
	{
	}

	public abstract void Activate();

	public abstract void DeActivate();

	public void OnFinalize()
	{
	}

	protected abstract void Dispose();

	public abstract void NoticeLaunchSkill(ADancePlayer player);

	public abstract void LaunchSkill();

	public abstract void ActivateSkillEffect(double elapsedTime, Action onFinishSkillEffect);

	protected abstract void OnChangeMultiMode(bool isHost);

	protected abstract void UpdateAction();

	protected abstract void UpdateSkill();

	protected abstract void OnForceLaunchSkill();

	public void OnUpdate(double elapsedTime)
	{
	}

	protected void CheckCanUseSkill()
	{
	}

	public void ForceLaunchSkill(float reservedLaunchElapsedTime)
	{
	}

	public bool CheckSendScore()
	{
		return default(bool);
	}

	public void ChangeMultiMode(bool isHost, float syncScoreSpan)
	{
	}
}
