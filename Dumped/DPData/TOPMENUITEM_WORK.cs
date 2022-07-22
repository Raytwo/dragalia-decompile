using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 8)]
public struct TOPMENUITEM_WORK
{
	public int index;

	public bool isNew;
}
