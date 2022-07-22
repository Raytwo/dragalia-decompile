using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 616)]
public struct UgSecretBase
{
	public short zoneID;

	public short posX;

	public short posY;

	public byte direction;

	public byte expansionStatus;

	public int goodCount;

	public UgStoneStatue[] ugStoneStatue;

	public bool isEnable;

	public bool isNull => default(bool);

	public Vector2Int ReturnPos()
	{
		return default(Vector2Int);
	}
}
