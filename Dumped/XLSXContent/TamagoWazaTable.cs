using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class TamagoWazaTable : ScriptableObject
{
	[Serializable]
	public class SheetData
	{
		public ushort no;

		public ushort formNo;

		public ushort[] wazaNo;
	}

	public SheetData[] Data;
}
