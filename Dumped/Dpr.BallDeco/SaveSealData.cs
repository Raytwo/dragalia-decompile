using System;
using System.Runtime.InteropServices;

namespace Dpr.BallDeco;

[Serializable]
[StructLayout(0, CharSet = CharSet.Unicode, Pack = 4, Size = 12)]
public struct SaveSealData
{
	public bool IsGet;

	public int Count;

	public int TotalCount;
}
