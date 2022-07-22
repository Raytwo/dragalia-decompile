using System.Collections.Generic;
using DG.Tweening;
using Dpr.Message;
using Dpr.UI;
using UnityEngine;

namespace Dpr.UnderGround;

public class UgInfoSet : MonoBehaviour
{
	private RectTransform View;

	private UIText uiText;

	private static readonly Vector3 HidePos;

	private static readonly Vector3 ViewPos;

	public float duration;

	private DG.Tweening.Sequence anim;

	public bool isPlaying;

	private List<(string, float)> StockMessageList;

	private const string UG_MSG_FILE = "dlp_underground";

	private const string Label_EnterOtherPlayer = "DLP_underground_758";

	private const string Label_ExitOtherPlayer = "DLP_underground_759";

	private const string Label_StartKousekiBonus = "DLP_underground_738";

	private const string Label_StartKousekiSagashi = "DLP_underground_739";

	public int Button01;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void Play(float displayTime)
	{
	}

	public void SetText(string message, float displayTime = 1.5f)
	{
	}

	public void OnOtherPlayerEnter(PlayerNameData nameData)
	{
	}

	public void OnOtherPlayerExit(PlayerNameData nameData)
	{
	}

	public void OnStartKousekiBonus()
	{
	}

	public void OnStartKousekiSagashi()
	{
	}
}
