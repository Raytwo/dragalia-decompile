using System.Runtime.InteropServices;
using XLSXContent;

namespace Dpr.Battle.Logic;

public sealed class BattleEffectComponentData
{
	private string overwrappedBattleBGM;

	private string overwrappedWinBGM;

	private BattleDataTable.SheetBattleSetupEffectData data;

	private EffectBattleID _effectBattleID;

	private string _soundEventName;

	public string cmdSeqName;

	public EffectBattleID effectBattleID
	{
		get
		{
			return default(EffectBattleID);
		}
		set
		{
		}
	}

	public string soundEventName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string battleBgm
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string winBgm
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int fadeType => default(int);

	private string ChooseCmdSeq(int index)
	{
		return null;
	}

	public void SetUpBattleEffectComponentData(BattleSetupEffectId setupEffectId, EffectBattleID effectBattleId = EffectBattleID.NONE, int cmdSeqIndex = 0, [Optional] string soundEventName)
	{
	}

	public void SetUpBattleEffectComponentData_Tutorial()
	{
	}
}
