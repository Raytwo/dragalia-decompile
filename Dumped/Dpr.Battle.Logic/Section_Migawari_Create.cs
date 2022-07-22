using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_Migawari_Create : Section
{
	public class Description
	{
		public BTL_POKEPARAM poke;
	}

	public class Result
	{
		public bool isCreated;
	}

	public Section_Migawari_Create([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void putAlreadyExistMessage(BTL_POKEPARAM poke)
	{
	}

	private bool isHpEnough(BTL_POKEPARAM poke)
	{
		return default(bool);
	}

	private uint calcMigawariHP(BTL_POKEPARAM poke)
	{
		return default(uint);
	}

	private void putFailedMessage()
	{
	}

	private void checkItemReaction(BTL_POKEPARAM poke)
	{
	}
}
