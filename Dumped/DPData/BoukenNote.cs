using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 24)]
public struct BoukenNote
{
	public byte[] VanishNew;

	public BoukenNote(int a)
	{
	}
}
