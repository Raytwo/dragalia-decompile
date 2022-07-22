namespace Dpr.NetworkUtils;

public class NetTradePokeData : ANetData<TradePokeData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
