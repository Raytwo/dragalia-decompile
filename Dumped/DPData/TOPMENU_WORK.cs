using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 68)]
public struct TOPMENU_WORK
{
	public TOPMENUITEM_WORK[] items;

	public TOPMENUITEMTYPE selectType;
}
