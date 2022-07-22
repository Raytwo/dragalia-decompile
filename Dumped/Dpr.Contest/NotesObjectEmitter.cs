using UnityEngine;

namespace Dpr.Contest;

public class NotesObjectEmitter
{
	private ObjectPoolSystem<NoteIcon> noteIconPool;

	private ObjectPoolSystem<LongTapNotesBg> notesBgPool;

	private float moveSpeed;

	private float noteFadeDuration;

	private int currentCreateNum;

	public bool CanCreateNoteIcon => default(bool);

	public void Initialize(NoteIcon noteComponent, Transform noteParent, LongTapNotesBg bgComponent, Transform bgContent)
	{
	}

	public void SetupParam(float moveSpeed, float noteFadeDuration)
	{
	}

	public void OnFinalize()
	{
	}

	public NoteIcon CreateNextNoteIcon(float elapsedTime, NotesDataModel noteData, float validTapTimeRange)
	{
		return null;
	}

	public void DecCreateIconNum()
	{
	}

	public LongTapNotesBg CreateNotesBg(NotesDataModel startNote, NotesDataModel endNote, double elapsedTime)
	{
		return null;
	}
}
