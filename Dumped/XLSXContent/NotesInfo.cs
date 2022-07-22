using System;
using Dpr.Contest;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class NotesInfo : ScriptableObject
{
	[Serializable]
	public class SheetNoteData
	{
		public bool valid_flag;

		public ushort id;

		public float beat;

		public NoteTypeID noteType;
	}

	public SheetNoteData[] NoteData;

	public SheetNoteData this[int index] => null;
}
