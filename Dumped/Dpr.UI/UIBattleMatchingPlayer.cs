using System.Collections.Generic;
using Dpr.Message;
using Dpr.NetworkUtils;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class UIBattleMatchingPlayer : MonoBehaviour
{
	[SerializeField]
	private UIContMatchingPlayerBoard[] _playerBoards;

	private List<int> _indexList;

	private string[] uiPlayerNameArray;

	public void Initialize(int num, BattleModeID type, bool vs = false)
	{
	}

	public void SetPlayerName(int index, string name, MessageEnumData.MsgLangId languageId)
	{
	}

	public void SetLoadingMonboObjActive(int index, bool active)
	{
	}

	public void ShowPreparatioIconReady(int index)
	{
	}

	public void ShowPreparatioIconWait(int index)
	{
	}

	public void HidePreparatioIcon()
	{
	}

	public void HidePreparatioIcon(int index)
	{
	}

	public void ResetPreparatioIcon()
	{
	}

	public RawImage[] GetRowImages()
	{
		return null;
	}
}
