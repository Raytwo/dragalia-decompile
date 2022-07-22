using Dpr.Message;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class CardFrontView : MonoBehaviour
{
	[SerializeField]
	private Image cardImage;

	[SerializeField]
	private Image titleImage;

	[SerializeField]
	private UIText numberText;

	[SerializeField]
	private UIText nameText;

	[SerializeField]
	private UIText moneyText;

	[SerializeField]
	private UIText dexText;

	[SerializeField]
	private UIText playTimeText;

	[SerializeField]
	private UIText startTimeText;

	[SerializeField]
	private UIText clearTimeText;

	[SerializeField]
	private Image cover1Image;

	[SerializeField]
	private Image cover2Image;

	private int currentPlayTimeMinute;

	private bool isUpdatePlayTime;

	public void Initialize()
	{
	}

	public void Initialize(UICard.Param param)
	{
	}

	public void SetCardImageSprite(Sprite cardSprite, Sprite titleSprite, Sprite cover1Sprite, Sprite cover2Sprite)
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	public void SetText(uint id, PlayerNameData nameData, int money, int zukanCount, ushort playTimeHour, ushort playTimeMinute, long startTime, uint clearTime)
	{
	}

	private void UpdatePlayTimeText(bool isForce = false)
	{
	}

	private void SetDateMessageWord(long timeStamp)
	{
	}

	private void SetDateMessageWord(uint timeStamp)
	{
	}

	private string GetPlayerIdText(uint id)
	{
		return null;
	}
}
