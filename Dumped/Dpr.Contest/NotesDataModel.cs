namespace Dpr.Contest;

public sealed class NotesDataModel : NotesData
{
	public float arriveSec;

	public int index;

	public bool emitFlag;

	public bool isLast;

	public NotesDataModel(int index, bool valid_flag, ushort id, float arriveSec, NoteTypeID notesType, bool isLast)
	{
	}

	public void Reset()
	{
	}
}
