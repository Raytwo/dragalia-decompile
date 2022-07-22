using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_G_Start : Section
{
	public class Description
	{
		public byte pokeID;
	}

	public class Result
	{
	}

	private struct resetFormTableElem
	{
		public MonsNo monsno;

		public ushort formno_before;

		public ushort formno_after;

		public resetFormTableElem(MonsNo monsno, ushort formno_before, ushort formno_after)
		{
		}
	}

	private static readonly resetFormTableElem[] resetFormTable;

	public Section_G_Start([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResulkt, [In] ref Description description)
	{
	}

	private void deleteMigawari(BTL_POKEPARAM poke)
	{
	}

	private void breakIllusion(byte pokeID)
	{
	}

	private void resetForm(BTL_POKEPARAM poke)
	{
	}

	private void checkBattleTalk(byte pokeID)
	{
	}

	private void registerZukanFlag(BTL_POKEPARAM poke)
	{
	}

	private void setPokeMemories(BTL_POKEPARAM pGPoke)
	{
	}

	private void setPokeMemoriesOnPlayersStartG(BTL_POKEPARAM pGPoke)
	{
	}

	private void setPokeMemoriesOnFaceToG(BTL_POKEPARAM pGPoke)
	{
	}
}
