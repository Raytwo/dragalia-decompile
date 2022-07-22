using System;
using System.Collections.Generic;

namespace Dpr.Contest;

public class DanceUser : ADancePlayer
{
	private ContestInput input;

	private DanceTapData tapData;

	private ContestUserData contestUserData;

	private double prevElapsedTime;

	private bool canInput;

	private bool bAutoMode;

	private bool isOn;

	public DanceTapData TapData => null;

	public DanceUser(ContestPlayerEntity entity, List<NotesDataModel> notesDataList, Action<ADancePlayer> onLockSkill)
	{
	}

	public override void Activate()
	{
	}

	public override void DeActivate()
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

	protected override void UpdateAction()
	{
	}

	protected override void UpdateSkill()
	{
	}

	private void UserInput()
	{
	}

	protected override void OnForceLaunchSkill()
	{
	}

	public override void NoticeLaunchSkill(ADancePlayer player)
	{
	}

	public override void LaunchSkill()
	{
	}

	private void AutoSuccessMode()
	{
	}

	private void UpdateSkillEffect()
	{
	}

	public override void ActivateSkillEffect(double elapsedTime, Action onFinishSkillEffect)
	{
	}

	protected override void OnChangeMultiMode(bool isHost)
	{
	}
}
