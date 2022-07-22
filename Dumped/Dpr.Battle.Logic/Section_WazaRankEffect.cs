using System.Runtime.InteropServices;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaRankEffect : Section
{
	public class Description
	{
		public WazaParam pWazaParam;

		public BTL_POKEPARAM pAttacker;

		public BTL_POKEPARAM pTarget;

		public uint actionSerialNo;

		public bool fAlmost;
	}

	public class Result
	{
		public bool isEffective;
	}

	public Section_WazaRankEffect([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool rankEffect(byte attackerID, WazaRankEffect effect, int volume, bool isMigawariThrew, bool fAlmost, uint actionSerialNo, BTL_POKEPARAM target, SimpleEffectFailManager pFailManager)
	{
		return default(bool);
	}

	private bool rankEffectCore(byte attackerID, WazaRankEffect effect, int volume, bool isMigawariThrew, bool fAlmost, uint actionSerialNo, BTL_POKEPARAM target, SimpleEffectFailManager pFailManager)
	{
		return default(bool);
	}
}
