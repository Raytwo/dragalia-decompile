using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, CharSet = CharSet.Unicode, Pack = 4, Size = 960)]
public struct RECORD_ADD_DATA
{
	public RECORD_HEAD[] head;

	public RECORD_RANKING[] rankingFlag;
}
