namespace Dpr.Battle.Logic;

public class RaidBattleParam
{
	public byte bossGrade;

	public bool isBossRare;

	public RaidRewardItemData[] rewards;

	public RaidBossDesc bossDesc;

	public RaidBossCaptureDifficulty bossCaptureDifficulty;

	public bool needApplyCaptureCoefForSpGDuplication;

	public void CopyFrom(RaidBattleParam src)
	{
	}
}
