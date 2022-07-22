using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_UseItem : Section
{
	public class Description
	{
		public BTL_POKEPARAM poke;

		public ushort itemID;

		public byte actParam;

		public byte targetPokeID;
	}

	public class Result
	{
		public bool isExpGet;
	}

	public Section_UseItem([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void useItemCore(out TrainerItemResult pUseResult, out bool pIsConsumed, out bool pIsUsedBall, BTL_POKEPARAM poke, ushort itemID, byte actParam, byte targetPokeID, POKE_CAPTURED_CONTEXT capContext)
	{
	}

	private bool expGetByCaptured(byte userClientID, BtlPokePos capturedPos)
	{
		return default(bool);
	}

	private void putFurimukiCommand(byte playerClientID)
	{
	}

	private bool getExp(BTL_PARTY pParty, ExpCalculator.CalcExpContainer pExpContainer)
	{
		return default(bool);
	}

	private void putCapturedCommand([In] ref POKE_CAPTURED_CONTEXT context)
	{
	}

	private void updateZukanData([In] ref POKE_CAPTURED_CONTEXT context)
	{
	}

	private bool escape(BTL_POKEPARAM escapePoke)
	{
		return default(bool);
	}
}
