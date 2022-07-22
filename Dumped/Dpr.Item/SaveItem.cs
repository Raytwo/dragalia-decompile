using System;
using System.Runtime.InteropServices;

namespace Dpr.Item;

[Serializable]
[StructLayout(0, Pack = 4, Size = 16)]
public struct SaveItem
{
	public int Count;

	public bool VanishNew;

	public bool FavoriteFlag;

	public bool ShowWazaNameFlag;

	private byte Dummy1;

	private byte Dummy2;

	public ushort SortNumber;
}
