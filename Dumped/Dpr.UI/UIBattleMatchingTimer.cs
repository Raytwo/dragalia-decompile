using Dpr.Message;
using UnityEngine;

namespace Dpr.UI;

public class UIBattleMatchingTimer : MonoBehaviour
{
	[SerializeField]
	private UIText _textTimer;

	[SerializeField]
	private UIText _textRemaining;

	[SerializeField]
	private UIText _textCount;

	[SerializeField]
	private GameObject _objCount;

	private MessageMsgFile _msgFile;

	private int _maxCount;

	public void SetTimerMessage(string label)
	{
	}

	public void SetTimerMessage(string msbt, string label)
	{
	}

	public void SetActive(bool active)
	{
	}

	public void SetActiveChild(bool active)
	{
	}

	public void SetTimer(string minutes, string seconds)
	{
	}

	public void SetActiveRemainingText(bool active)
	{
	}

	public void RemainingWarningText(bool warning = true)
	{
	}

	public void SetupCount(int max)
	{
	}

	public void SetCount(int count)
	{
	}
}
