namespace Dpr.NetworkUtils;

public class NetDataBattleMatchingSelectPokemon : ANetData<BattleMatchingPokeData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
