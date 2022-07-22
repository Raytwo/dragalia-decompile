using System;
using Dpr.EvScript;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class HoneyTree : ScriptableObject
{
	[Serializable]
	public class SheetHoneyTreeIndex
	{
		public ZoneID ZoneID;

		public EvWork.SYSFLAG_INDEX HoneyStartFlag;

		public Vector2 HoneyPosXZ;
	}

	[Serializable]
	public class SheetHoneyTreeShake
	{
		public int Big;

		public int Normal;

		public int None;

		public int Super;
	}

	public SheetHoneyTreeIndex[] HoneyTreeIndex;

	public SheetHoneyTreeShake[] HoneyTreeShake;

	public SheetHoneyTreeIndex this[int index] => null;
}
