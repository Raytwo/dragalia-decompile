using Dpr.Message;
using TMPro;
using UnityEngine;

namespace Dpr.UI;

public class MenuHeader : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI _timeText;

	[SerializeField]
	private GameObject _timerObj;

	[SerializeField]
	private string useMsbtName;

	[SerializeField]
	private string timeLabelName;

	private MessageMsgFile _useMsgFile;

	public void Setup()
	{
	}

	public void HideTimer()
	{
	}

	private void SetTimerActive(bool active)
	{
	}

	public void SetTime(int minut, int second)
	{
	}

	public void SetTime(string minutStr, string secondStr)
	{
	}

	private bool CheckHaveMsgFile()
	{
		return default(bool);
	}
}
