using System;
using Dpr.EvScript;
using Pml;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class KinomiPlaceData : ScriptableObject
{
	[Serializable]
	public class SheetSheet1
	{
		public int Index;

		public string ID;

		public Vector3 Position;

		public AreaID AreaID;

		public ZoneID ZoneID;

		public ItemNo ItemNo;

		public int SeedNum;

		public int GroupId;

		public int DesignationIndex;

		public EvWork.SYSFLAG_INDEX SeedStartFlag;

		public Vector2 TownMapPosition;
	}

	public SheetSheet1[] Sheet1;

	public SheetSheet1 this[int index] => null;
}
