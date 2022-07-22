using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_UseItemEquip : Section
{
	public class Description
	{
		public byte userPokeID;

		public bool isSkipHPFull;

		public bool isUseDead;
	}

	public class Result
	{
		public bool isUsed;
	}

	public Section_UseItemEquip([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void section_ChangeItem(BTL_POKEPARAM pPoke)
	{
	}

	private void section_AfterItemEquip(BTL_POKEPARAM pPoke, ushort itemID)
	{
	}
}
