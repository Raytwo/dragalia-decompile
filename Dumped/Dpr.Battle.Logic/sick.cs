using System.Runtime.InteropServices;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public static class sick
{
	private class getCureStrIDTable_t
	{
		public WazaSick sick;

		public short strID_notItem;

		public short strID_useItem;

		public getCureStrIDTable_t(WazaSick sick, short strID_notItem, short strID_useItem)
		{
		}
	}

	private static readonly getCureStrIDTable_t[] getCureStrIDTable;

	public static int getCureStrID(WazaSick sick, bool fUseItem)
	{
		return default(int);
	}

	public static int getDefaultSickStrID(WazaSick sickID, [In] ref BTL_SICKCONT cont)
	{
		return default(int);
	}

	public static int getWazaSickDamageStrID(WazaSick sick)
	{
		return default(int);
	}
}
