using System.Runtime.InteropServices;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public static class BTL_SICK
{
	public static bool MakeDefaultCureMsg(WazaSick sickID, [In] ref BTL_SICKCONT oldCont, BTL_POKEPARAM bpp, ushort itemID, StrParam str)
	{
		return default(bool);
	}

	public static void MakeDefaultMsg(WazaSick sickID, [In] ref BTL_SICKCONT cont, BTL_POKEPARAM bpp, StrParam str)
	{
	}

	public static bool CheckBatonTouchInherit(WazaSick sick, BTL_POKEPARAM bpp)
	{
		return default(bool);
	}

	public static bool MakeSickDamageMsg(StrParam strParam, BTL_POKEPARAM bpp, WazaSick sickID)
	{
		return default(bool);
	}

	public static short GetSpecificSickFailStrID(WazaSick sickID)
	{
		return default(short);
	}
}
