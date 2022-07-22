using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 20)]
public struct LOCATION_WORK
{
	public int zoneID;

	public float posX;

	public float posY;

	public float posZ;

	public int dir;
}
