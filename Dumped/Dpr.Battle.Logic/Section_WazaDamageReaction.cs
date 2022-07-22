using System.Runtime.InteropServices;
using Pml.Battle;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaDamageReaction : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public BTL_POKEPARAM defender;

		public WazaParam wazaParam;

		public TypeAffinity.AffinityID affinity;

		public uint damage;

		public bool critical_flag;

		public bool fMigawari;
	}

	public class Result
	{
	}

	public Section_WazaDamageReaction([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description desc)
	{
	}
}
