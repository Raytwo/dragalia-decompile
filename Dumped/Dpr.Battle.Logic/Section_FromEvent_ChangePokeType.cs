using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_ChangePokeType : Section
{
	public class Description
	{
		public byte pokeID;

		public PokeTypePair nextType;

		public BTL_POKEPARAM.ExTypeCause exTypeCause;

		public bool isStandardMessageDisable;

		public bool isFailMessageEnable;

		public bool isDisplayTokuseiWindow;

		public StrParam changedMessage;
	}

	public class Result
	{
		public bool isSuccessed;
	}

	public Section_FromEvent_ChangePokeType([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
