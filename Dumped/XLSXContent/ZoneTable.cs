using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class ZoneTable : ScriptableObject
{
	public ZoneID[] ZoneIDs;

	public int Width;

	public ZoneID this[int index] => default(ZoneID);

	public ZoneID this[int gridX, int gridY] => default(ZoneID);

	public int Length => default(int);
}
