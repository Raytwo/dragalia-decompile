using System;
using Pml;
using XLSXContent;

namespace Dpr.Contest;

public abstract class AContestSkillBase
{
	protected ContestWazaInfo.SheetContestWazaData skillData;

	protected PlayerDanceDataModel targetData;

	protected PokeType wazaType;

	protected double launchElapsedTime;

	protected double lifeTime;

	protected bool active;

	private Action onFinished;

	public bool IsActive => default(bool);

	public SkillTypeID SkillType => default(SkillTypeID);

	public PokeType WazaType => default(PokeType);

	public void Reset()
	{
	}

	public void CreateSkill(ContestWazaInfo.SheetContestWazaData skillData, PokeType wazaType, PlayerDanceDataModel target)
	{
	}

	public abstract int CalcAppealPoint();

	public void ActivateSkillEffect(SkillBonusParam bonusParam, double elapsedTime, Action onFinished)
	{
	}

	protected abstract void OnLaunchSkillEffect(SkillBonusParam bonusParam);

	public void UpdateSkill(double elapsedTime)
	{
	}

	private void FinishSkill()
	{
	}
}
