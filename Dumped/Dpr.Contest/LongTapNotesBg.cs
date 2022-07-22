using UnityEngine;

namespace Dpr.Contest;

public class LongTapNotesBg : MonoBehaviour, IPoolObject
{
	private RectTransform rect;

	private NotesDataModel endNoteData;

	private float moveSpeed;

	private float arriveSec;

	private float lifeTime;

	private int startNoteID;

	private int endNoteID;

	private bool active;

	private bool isHold;

	public int StartNoteID => default(int);

	public int EndNoteID => default(int);

	public bool IsActive()
	{
		return default(bool);
	}

	public void Create(NotesDataModel startNoteData, NotesDataModel endNoteData, double elapsedTime, float moveSpeed)
	{
	}

	public void Deactive()
	{
	}

	private void SetActive(bool active)
	{
	}

	private void CalcWidth(float startSecTime, float endSecTime)
	{
	}

	public void OnStartHold()
	{
	}

	public void OnUpdate(double elapsedTime)
	{
	}

	private void UpdateMovePosition(float time)
	{
	}
}
