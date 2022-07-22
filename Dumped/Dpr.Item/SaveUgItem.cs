using System;
using System.Runtime.InteropServices;

namespace Dpr.Item;

[Serializable]
[StructLayout(0, Pack = 4, Size = 12)]
public struct SaveUgItem
{
	public int Count;

	public bool VanishNew;

	public bool FavoriteFlag;
}
