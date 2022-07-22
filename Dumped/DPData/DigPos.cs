using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 4)]
public struct DigPos
{
	public short GridX;

	public short GridY;

	public bool IsNull => default(bool);

	public DigPos(short x, short y)
	{
	}

	public static implicit operator DigPos(Vector2Int v)
	{
		return default(DigPos);
	}
}
