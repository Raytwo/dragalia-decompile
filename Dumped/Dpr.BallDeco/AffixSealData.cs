using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Dpr.BallDeco;

[Serializable]
[StructLayout(0, CharSet = CharSet.Unicode, Pack = 4, Size = 8)]
public struct AffixSealData
{
	public ushort SealId;

	public short PositionX;

	public short PositionY;

	public short PositionZ;

	public void Clear()
	{
	}

	public void SetPosition(Vector3 pos)
	{
	}

	public Vector3 GetPosition()
	{
		return default(Vector3);
	}

	private static short ConvertPositionValue(float value)
	{
		return default(short);
	}

	private static float ConvertPositionValue(short value)
	{
		return default(float);
	}
}
