using System;
using Dpr.EvScript;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class StopData : ScriptableObject
{
	[Serializable]
	public class SheetData
	{
		public string ID;

		public Vector2 Position;

		public int HeightLayer;

		public Vector2 Size;

		public string ContactLabel;

		public int Param;

		public EvWork.WORK_INDEX Work;
	}

	public SheetData[] Data;

	public SheetData this[int index] => null;
}
