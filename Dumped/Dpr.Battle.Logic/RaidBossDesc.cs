using System.Runtime.InteropServices;
using Pml;
using Pml.Personal;

namespace Dpr.Battle.Logic;

public class RaidBossDesc
{
	public float hpCoef;

	public byte gWazaFrequency;

	public byte actNum;

	public byte gWallGaugeMax;

	public byte gWallGaugeInit;

	public byte gWallRepairTurn;

	public byte[] angryHPThreshold;

	public WazaNo[] angryWazaNo;

	public RaidBossAngryWazaTiming[] angryWazaTimming;

	public void CopyFrom(RaidBossDesc src)
	{
	}

	public static void Copy(RaidBossDesc pDesc, [In] ref RaidBossDesc src)
	{
	}

	public static void SetDefault(RaidBossDesc pDesc, MonsNo monsno, ushort formno, byte grade)
	{
	}
}
