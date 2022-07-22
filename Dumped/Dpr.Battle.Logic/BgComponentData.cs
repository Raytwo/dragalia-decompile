using Dpr.Battle.View;
using Pml;
using XLSXContent;

namespace Dpr.Battle.Logic;

public class BgComponentData
{
	public int arenaIndex;

	public WazaNo sizennotikaraWazaNo;

	public bool enableDarkBall;

	public byte minomuttiFormNo;

	public EffectBattleID footEffectID;

	public JointName attachJoint;

	public bool isIndoor;

	public int reflectionResolution;

	public int shadowResolution;

	private BattleSetupEffectLots.SheetArenaEffTable arenaEffTable;

	public bool enableReflection => default(bool);

	public EffectBattleID[] effectBattleID => null;

	public void Clear()
	{
	}

	public void CopyFrom(BgComponentData src)
	{
	}

	public void SetUpBgComponentData(ArenaID id)
	{
	}

	private void SetParam(ArenaInfo.SheetArenaData field)
	{
	}
}
