using System.Collections.Generic;

namespace Dpr.Contest;

public sealed class CollectNotesDataModel
{
	private sealed class NotesDensityData
	{
		public int notesNum;

		public int startNoteIndex;

		public int endNoteIndex;
	}

	private List<NotesDensityData> containNotesDataList;

	private List<int> notesNumList;

	private List<int> notesIndexList;

	public void CreateContainsNotesData(List<NotesDataModel> notesList, float beatSec, float skillAnimDuration, int bgmSigunature)
	{
	}

	private NotesDensityData CreateContainNotesData(List<NotesDataModel> notesList, int noteIndex, float endTime)
	{
		return null;
	}

	public int FindNotesIndexByDensityOarder(int index)
	{
		return default(int);
	}
}
