using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_UpdateWaza : Section
{
	public class Description
	{
		public byte pokeID;

		public byte wazaIdx;

		public WazaNo waza;

		public byte ppMax;

		public bool isPermanent;
	}

	public class Result
	{
	}

	public Section_FromEvent_UpdateWaza([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
