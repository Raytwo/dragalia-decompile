using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_SideEffect_Add : Section
{
	public class Description
	{
		public byte pokeID;

		public BtlSideEffect effect;

		public BTL_SICKCONT cont;

		public BtlSide side;

		public ushort successEffectNo;

		public StrParam successMessage;

		public bool isReplaceSuccessMessageArgs0ByExpandSide;
	}

	public class Result
	{
		public bool isSuccessed;
	}

	public Section_SideEffect_Add([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description desc)
	{
	}

	private void onSuccess([In] ref Description desc, BtlSide targetSide)
	{
	}
}
