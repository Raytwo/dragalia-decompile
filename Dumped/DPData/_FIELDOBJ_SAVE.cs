using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 68000)]
public struct _FIELDOBJ_SAVE
{
	public const int MAX = 1000;

	public FIELD_OBJ_SAVE_DATA[] fldobj_sv;
}
