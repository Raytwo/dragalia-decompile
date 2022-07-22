using System;
using Pml;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class MonohiroiTable : ScriptableObject
{
	[Serializable]
	public class SheetMonoHiroi
	{
		public ItemNo ID;

		public byte[] Ratios;
	}

	public SheetMonoHiroi[] MonoHiroi;

	public SheetMonoHiroi this[int index] => null;
}
