using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_Koraeru : Section
{
	public class Description
	{
		public BTL_POKEPARAM poke;

		public KoraeruCause cause;
	}

	public class Result
	{
	}

	public Section_Koraeru([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private void onKoraeru_ByDefender(BTL_POKEPARAM poke)
	{
	}

	private void onKoraeru_ByFriendship(BTL_POKEPARAM poke)
	{
	}

	private void onKoraeru_ByOthers(BTL_POKEPARAM poke, KoraeruCause cause)
	{
	}
}
