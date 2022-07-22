using System.Runtime.InteropServices;
using Pml;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class WazaParam
{
	public WazaNo wazaID;

	public WazaNo orgWazaID;

	public WazaNo gSrcWazaID;

	public PokeTypePair userType;

	public byte wazaType;

	public WazaDamageType damageType;

	public bool touchFlag;

	public WazaTarget targetType;

	public int wazaPri;

	public ushort wazaPower;

	public bool fMagicCoat;

	public bool fYokodori;

	public bool fItazuraGokoro;

	public bool fInvalidMessageDisable;

	public void ClearFlags()
	{
	}

	public bool canInvalidMessageDisplay(uint count)
	{
		return default(bool);
	}

	public void CopyFrom(WazaParam src)
	{
	}

	public static void Init(WazaParam pParam)
	{
	}

	public static void Copy(WazaParam pDest, [In] ref WazaParam src)
	{
	}
}
