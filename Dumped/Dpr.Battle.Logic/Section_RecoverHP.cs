using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_RecoverHP : Section
{
	public class Description
	{
		public byte userPokeID;

		public byte targetPokeID;

		public ushort recoverHP;

		public ushort itemID;

		public bool isDisplayTokuseiWindow;

		public bool isDisplayFailMessage_HPFull;

		public bool isDisplayFailMessage_SP;

		public bool isDisplayRecoverEffect;

		public bool isSkipFailCheckSP;

		public StrParam successMessage;
	}

	public class Result
	{
		public bool isRecovered;
	}

	public Section_RecoverHP([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private bool checkFailBase(BTL_POKEPARAM poke)
	{
		return default(bool);
	}

	private bool checkFailSP(BTL_POKEPARAM poke, bool isFailMessageDisplay)
	{
		return default(bool);
	}

	private void recover(BTL_POKEPARAM poke, ushort recoverHP, bool isEffectEnable)
	{
	}
}
