using System;
using System.Collections.Generic;
using DG.Tweening;
using Dpr.SubContents;
using Effect;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Contest;

public class NotesLane : MonoBehaviour
{
	private readonly EmitEffectParam[] COMMON_TAP_GRADE_FX;

	[SerializeField]
	private GameObject barLineObj;

	[SerializeField]
	private GameObject noteObj;

	[SerializeField]
	private GameObject longTapBgObj;

	private Sprite[] tapGradeSprArray;

	private List<NoteIcon> currentUseNoteList;

	private List<LongTapNotesBg> currentNotesBgList;

	private List<BarLine> currentBarLineList;

	private UITimingGrade[] uiTimingGradeArray;

	private NotesObjectEmitter noteObjEmitter;

	private EffectEmitter fxEmitter;

	private EffectInstance holdFxInst;

	private DOTweenAnimation uiMusicFadeTween;

	private NoteIcon longStartNote;

	private NoteIcon longEndNote;

	private Image heartGaugeImage;

	private RectTransform tapIconRect;

	private Transform fxCanvasTransform;

	private Transform objParent;

	private float validTapTimeRange;

	private int loadCount;

	private int loadedCount;

	private Action<NoteTypeID> onFailedTap;

	private Action<NoteIcon> onDeactiveNote;

	private Action onStopHoldFx;

	public Vector3 TapIconCenterPos => default(Vector3);

	public bool CanCreateNote => default(bool);

	public void Initialize(Action<NoteTypeID> onFailedTap, Action<NoteIcon> onDeactiveNote, Action onStopHoldFx)
	{
	}

	private void GenerateTimingGradePool()
	{
	}

	private void CreateTapGradeSpr()
	{
	}

	private string GetBestTapGradeTexName()
	{
		return null;
	}

	public bool IsReady()
	{
		return default(bool);
	}

	public void Setup(float validTimeSpan, float moveSpeed, float beatSec, float noteFadeDuration, int bgmSigunature, int lineNum)
	{
	}

	private void CreateBarLine(float moveSpeed, float beatSec, int bgmSigunature, int lineNum)
	{
	}

	private void LoadFx()
	{
	}

	private void LoadTapGradeFx()
	{
	}

	private void LoadLongTapFx()
	{
	}

	public void ResetParam(float beatSec, int bgmSigunature)
	{
	}

	public void OnFinalize()
	{
	}

	public void CreateNote(float elapsedTime, NotesDataModel nextNoteData)
	{
	}

	public void CreateLongTapNotesBG(float elapsedTime, NotesDataModel startNoteData, NotesDataModel endNoteData)
	{
	}

	public void OnUpdate(float elapsedTime)
	{
	}

	private void UpdateNotes(float elapsedTime)
	{
	}

	private int FailedNote(int noteIndex, NoteIcon note)
	{
		return default(int);
	}

	private void RemoveNote(int listIndex, NoteIcon target)
	{
	}

	private void UpdateNoteUI(float elapsedTime)
	{
	}

	private void UpdateBarLine(float elapsedTime)
	{
	}

	private void UpdateFx()
	{
	}

	public NoteIcon OnInputDecideButton()
	{
		return null;
	}

	private NoteIcon FindNearTapTimingNote()
	{
		return null;
	}

	private bool IsValidNormalTap(float noteLifeTime)
	{
		return default(bool);
	}

	private void TapNormalNote(NoteIcon targetNote)
	{
	}

	private void TapLongStartNote(NoteIcon targetNote)
	{
	}

	public void OnStartLongTap(int startNoteID)
	{
	}

	private NoteIcon FindNoteByID(int targetId)
	{
		return null;
	}

	public float OnReleaseHold()
	{
		return default(float);
	}

	public void DeactiveHoldFx()
	{
	}

	public void FailedTapLongStart()
	{
	}

	public void HideNotesUntilTime(float elaspedTimeRange)
	{
	}

	public void DeactiveNotesBg(int endNoteId)
	{
	}

	public void SetHeartGaugeRatio(float ratio)
	{
	}

	public void ShowTimingGrade(NoteTapTimingID timingID)
	{
	}

	private UITimingGrade FindInactiveTimingGradeObj()
	{
		return null;
	}

	private EffectContestID ConvertTimingIDToEffectID(NoteTapTimingID timingID)
	{
		return default(EffectContestID);
	}

	public void DoPlayUIFadeTween(bool forward)
	{
	}
}
