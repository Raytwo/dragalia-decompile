using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_ChangeGround : Section
{
	public class Description
	{
		public byte pokeID;

		public BtlGround ground;

		public BTL_SICKCONT contParam;

		public ChangeGroundCause cause;
	}

	public class Result
	{
		public bool isChanged;
	}

	public Section_ChangeGround([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool needEffect(ChangeGroundCause cause)
	{
		return default(bool);
	}
}
