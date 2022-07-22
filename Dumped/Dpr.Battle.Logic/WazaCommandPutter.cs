using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class WazaCommandPutter
{
	public class SetupParam
	{
		public ServerCommandQueue pCommandQueue;

		public ServerCommandPutter pCommandPutter;
	}

	private ServerCommandQueue m_pCommandQueue;

	private ServerCommandPutter m_pCommandPutter;

	public WazaCommandPutter([In] ref SetupParam param)
	{
	}

	public void ReserveMessage(WazaMessageParam pMsgParam)
	{
	}

	public void PutMessageToReservedPos(WazaMessageParam pMsgParam, WazaEffectParams pEffectParam)
	{
	}

	public void PutMessage(WazaMessageParam pMsgParam, WazaEffectParams pEffectParam)
	{
	}

	private void putMessage(WazaMessageParam pMsgParam, WazaEffectParams pEffectParam)
	{
	}

	public void PutWazaEffect([In] ref WazaParam wazaParam, WazaEffectParams wazaEffect, [In] ref WazaEffectReservedPos reservedQueuePos)
	{
	}
}
