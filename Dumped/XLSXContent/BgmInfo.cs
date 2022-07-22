using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class BgmInfo : ScriptableObject
{
	[Serializable]
	public class SheetBgmData
	{
		public bool valid_flag;

		public ushort id;

		public string triggerEvent;

		public string seqFileName;

		public int bpm;

		public int introSpan;
	}

	public SheetBgmData[] BgmData;

	public SheetBgmData this[int index] => null;
}
