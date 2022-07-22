using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class EffectSummarizer
{
	private ServerCommandQueue m_pQueue;

	private ushort m_reservedPos_Effect;

	private ushort m_reservedPos_Message;

	public EffectSummarizer(ServerCommandQueue pQueue)
	{
	}

	public void Reserve()
	{
	}

	public void Put([In] ref GShockEffectParam param)
	{
	}

	private void put_Effect([In] ref GShockEffectParam param)
	{
	}

	private void put_Message([In] ref GShockEffectParam param)
	{
	}
}
