using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class FreeSanpoActionProbability : ScriptableObject
{
	[Serializable]
	public class SheetSheet1
	{
		public string 種類;

		public int MonsNo;

		public int Kyoro;

		public int Sleep;

		public int UroUro;

		public int Run;
	}

	public SheetSheet1[] Sheet1;

	public SheetSheet1 this[int index] => null;
}
