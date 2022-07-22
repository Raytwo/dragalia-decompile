using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 20)]
public struct UgStoneStatue
{
	public int statueId;

	public int pedestalId;

	public int posX;

	public int posY;

	public int dir;
}
