using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 8)]
public struct BadgeSaveData
{
	public const byte DefaultCleanValue = 150;

	public byte[] CleanValues;

	public void Clear()
	{
	}
}
