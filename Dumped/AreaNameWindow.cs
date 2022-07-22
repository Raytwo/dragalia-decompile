using System.Text;
using DG.Tweening;
using Dpr.Message;
using TMPro;
using UnityEngine;

public class AreaNameWindow : MonoBehaviour
{
	private const string FRAME_SPR_NAME = "cmn_wd_areaname_01";

	private const int CAPACITY = 32;

	[SerializeField]
	private float showTime;

	[SerializeField]
	private TextMeshProUGUI nameText;

	private DOTweenAnimation moveTween;

	private MessageManager msgManagerPtr;

	private MessageMsgFile useMsgFile;

	private StringBuilder showingLabelName;

	private StringBuilder reservLabelName;

	private MessageEnumData.MsgLangId prevLangID;

	private bool isKanji;

	private float timer;

	private int showLabelHash;

	private int lastShowLabelHash;

	private bool showing;

	public void Initialize()
	{
	}

	private void SetActive(bool active)
	{
	}

	private void OnDestroy()
	{
	}

	public void OnEnableFieldCanvas()
	{
	}

	public void OnDisableFieldCanvas()
	{
	}

	public void ResetParam()
	{
	}

	public void Open(string labelName)
	{
	}

	public void ImmidiateClose()
	{
	}

	private bool IsSameShowingLabel(string nextLabelName)
	{
		return default(bool);
	}

	private bool IsSameLastShowingLabel(string nextLabelName)
	{
		return default(bool);
	}

	private void PerformShowAreaName(string labelName)
	{
	}

	private void SetNameText(string labelName)
	{
	}

	private void CheckUseMsgFile()
	{
	}

	private void DoMoveWindow()
	{
	}

	public void OnComplete()
	{
	}

	public void OnRewind()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}
}
