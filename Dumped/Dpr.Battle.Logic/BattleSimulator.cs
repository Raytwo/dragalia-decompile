using System.Runtime.InteropServices;
using Pml;
using Pml.Battle;

namespace Dpr.Battle.Logic;

public sealed class BattleSimulator
{
	public class SetupParam
	{
		public MainModule pMainModule;

		public BattleEnv pSrcEnv;
	}

	private readonly BattleEnv m_pSrcBattleEnv;

	private BattleEnv m_battleEnv;

	private BattleDriver m_battleDriver;

	public BattleSimulator([In] ref SetupParam param)
	{
	}

	public void createBattleEnv(MainModule pMainModule)
	{
	}

	public void createBattleDriver(MainModule pMainModule)
	{
	}

	public BtlWeather GetWeather()
	{
		return default(BtlWeather);
	}

	public ushort CalcAgility(BTL_POKEPARAM poke, bool isTrickRoomApply)
	{
		return default(ushort);
	}

	public ushort CalcAgilityOrder(BTL_POKEPARAM poke, bool isTrickRoomApply)
	{
		return default(ushort);
	}

	public bool IsPosEffectExist(BtlPokePos pos, BtlPosEffect effect)
	{
		return default(bool);
	}

	public ushort CalcDamage(byte atkPokeID, byte defPokeID, WazaNo waza, bool isAffinityEnable, bool isRandomEnable)
	{
		return default(ushort);
	}

	public TypeAffinity.AffinityID CalcTypeAffinity(byte atkPokeID, byte defPokeID, WazaNo waza, bool onlyAttacker)
	{
		return default(TypeAffinity.AffinityID);
	}

	private void copyBattleEnv()
	{
	}

	private void clearServerCommandQueue()
	{
	}
}
