using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Contest;

public class NoteIcon : MonoBehaviour, IPoolObject
{
	public enum NoteStatusID
	{
		Move,
		Miss,
		ReachedEnd,
		InActive
	}

	private static readonly Vector3 HIDE_NOTE_POS;

	private Image iconImage;

	private RectTransform rect;

	private NotesDataModel noteData;

	private NoteStatusID statusID;

	private Vector3 iconPos;

	private float lifeTime;

	private float fadeTime;

	private float moveSpeed;

	private float validTapTimeRange;

	private float fadeDuration;

	private bool canTap;

	private bool isTap;

	private bool active;

	public NotesDataModel NoteData => null;

	public NoteTypeID NoteType => default(NoteTypeID);

	public float arriveSec => default(float);

	public NoteStatusID StatusID => default(NoteStatusID);

	public float LifeTime => default(float);

	public float AbsLifeTime => default(float);

	public bool CanTap => default(bool);

	public bool IsActive()
	{
		return default(bool);
	}

	public void Create(NotesDataModel noteData, float elapsedTime, float moveSpeed, float validTapTimeRange, float fadeDuration)
	{
	}

	public void Deactive()
	{
	}

	private void SetActive(bool active)
	{
	}

	public void OnUpdate(float elapsedTime)
	{
	}

	private void UpdateNormalNote()
	{
	}

	private void UpdateLongStartNote()
	{
	}

	private void UpdateLongEndNote()
	{
	}

	private void MoveNote()
	{
	}

	private void UpdatePosition(float time)
	{
	}

	private void FadeOut()
	{
	}

	private void UpdateColor(float ratio)
	{
	}

	public void OnTap()
	{
	}

	public void SetTapEnabled(bool enabled)
	{
	}

	public void ChangeStateMiss()
	{
	}
}
