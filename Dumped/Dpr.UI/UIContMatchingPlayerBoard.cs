using Dpr.Message;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class UIContMatchingPlayerBoard : MonoBehaviour
{
	[SerializeField]
	private UIText _playerName;

	private GameObject loadingMonboObj;

	private Image preparationIconImage;

	private Sprite waitIconSpr;

	private Sprite readyIconSpr;

	public void Initialize(string initPlayerNameText, Sprite waitIconSpr, Sprite readyIconSpr)
	{
	}

	public void SetPlayerName(string playerNameSrt)
	{
	}

	public void SetPlayerName(string playerNameSrt, MessageEnumData.MsgLangId langId)
	{
	}

	public void ShowPreparatioIcon(bool isReady)
	{
	}

	public void HidePreparatioIcon()
	{
	}

	private void SetPreparatioIconActive(bool active)
	{
	}

	public void SetLoadingMonboObjActive(bool active)
	{
	}
}
