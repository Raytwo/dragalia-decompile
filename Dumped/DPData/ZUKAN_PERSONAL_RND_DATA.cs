using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 100)]
public struct ZUKAN_PERSONAL_RND_DATA
{
	private const int PattiiruPersonalRndSize = 4;

	private const int ReservedSize = 17;

	public uint[] PattiiruSeePersonalRnds;

	public uint[] PattiiruGetPersonalRnds;

	public uint[] Reserved;

	public void Clear()
	{
	}
}
