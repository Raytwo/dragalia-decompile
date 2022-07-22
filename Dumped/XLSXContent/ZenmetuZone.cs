using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class ZenmetuZone : ScriptableObject
{
	[Serializable]
	public class Sheetdata
	{
		public ZoneID zoneID;

		public int gridX;

		public int gridZ;

		public int height;

		public int dir;

		public ZoneID townMapZoneID;

		public int locators;
	}

	public Sheetdata[] data;

	public Sheetdata this[int index] => null;
}
