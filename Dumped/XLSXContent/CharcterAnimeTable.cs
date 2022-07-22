using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class CharcterAnimeTable : ScriptableObject
{
	[Serializable]
	public class Sheetcliplist
	{
		public int clipindex;

		public CharcterAnimeEvent data;
	}

	public Sheetcliplist[] cliplist;

	public Sheetcliplist this[int index] => null;
}
