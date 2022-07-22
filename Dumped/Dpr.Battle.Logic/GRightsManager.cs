using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class GRightsManager
{
	private readonly MainModule m_pMainModule;

	private GRights[] m_gRights;

	public GRightsManager(MainModule pMainModule, BattleEnv pBattleEnv)
	{
	}

	private void createGRights(MainModule pMainModule, BattleEnv pBattleEnv)
	{
	}

	public void Initialize()
	{
	}

	public void CopyFrom([In] ref GRightsManager src)
	{
	}

	public void AddClient(BTL_CLIENT_ID clientID)
	{
	}

	public GRights GetGRights(BtlSide side)
	{
		return null;
	}
}
