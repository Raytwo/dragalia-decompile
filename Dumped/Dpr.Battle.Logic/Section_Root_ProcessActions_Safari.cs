using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_Root_ProcessActions_Safari : Section
{
	public class Description
	{
		public SVCL_ACTION pClientInstructions;
	}

	public class Result
	{
		public InterruptCode interrupt;
	}

	public Section_Root_ProcessActions_Safari([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void processPlayer(SVCL_ACTION clientInstructions)
	{
	}

	private void processEnemy(SVCL_ACTION clientInstructions)
	{
	}

	private void throwSafariBall(byte pokeID)
	{
	}

	private void throwEsa(byte pokeID)
	{
	}

	private void throwDoro(byte pokeID)
	{
	}

	private void yousumi(byte pokeID)
	{
	}

	private bool escape(byte pokeID)
	{
		return default(bool);
	}

	private void ballEmpty()
	{
	}
}
