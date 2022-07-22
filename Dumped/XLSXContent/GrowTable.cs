using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class GrowTable : ScriptableObject
{
	[Serializable]
	public class SheetData
	{
		public uint[] exps;
	}

	public SheetData[] Data;
}
