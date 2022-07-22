using System;

namespace Dpr.Contest;

public class PlayerDanceDataModel : PlayerDanceData
{
	public int StackLiveScore => default(int);

	public bool IsAlreadyUseSkill => default(bool);

	public bool IsActiveSkill => default(bool);

	public bool IsForceSuccess => default(bool);

	public bool CanEmitHeart => default(bool);

	public void SetPlayerData(PlayerDanceData data)
	{
	}

	public void ResetParam()
	{
	}

	public void AddLiveScore(int addScore)
	{
	}

	public void DecLiveScore(int decScore)
	{
	}

	public void AddTapTimingCount(NoteTapTimingID timingID)
	{
	}

	public int GetTapTimingCount(NoteTapTimingID timingID)
	{
		return default(int);
	}

	public void ForceSetTension(int tension)
	{
	}

	public void SetUpdownCount(TensionData tensionData)
	{
	}

	public bool AddSuccessCount()
	{
		return default(bool);
	}

	private void UpTension()
	{
	}

	public bool AddFailedCount()
	{
		return default(bool);
	}

	private void DownTension()
	{
	}

	private void ResetTensionCount()
	{
	}

	public bool AddHeartGauge(int addValue)
	{
		return default(bool);
	}

	public void UseSkill()
	{
	}

	public void LockSkill()
	{
	}

	public void LaunchSkill()
	{
	}

	public void FinishedSkillAnim()
	{
	}

	public void ActivateSkillEffect(double elapsedTime, Action onFinishSkillEffect)
	{
	}

	public void UpdateSkillEffect(double elapsedTime)
	{
	}

	public void AddWazaScore(int score)
	{
	}
}
