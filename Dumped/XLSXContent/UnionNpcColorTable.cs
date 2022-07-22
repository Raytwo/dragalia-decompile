using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class UnionNpcColorTable : ScriptableObject
{
	[Serializable]
	public class SheetSheet1
	{
		public int NO;

		public int ColorSet;
	}

	public SheetSheet1[] Sheet1;

	public SheetSheet1 this[int index] => null;
}
