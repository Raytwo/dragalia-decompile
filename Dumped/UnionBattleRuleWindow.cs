using System.Collections.Generic;
using Dpr.BattleMatching;
using Dpr.Message;
using Dpr.UI;
using UnityEngine;

public class UnionBattleRuleWindow : MonoBehaviour
{
	private const int TAG_INDEX_RULE = 0;

	private const int TAG_INDEX_PLAYER_NAME = 1;

	private static readonly string TITLE_RULE_TEXT_LABEL;

	private static readonly string TITLE_TARGET_TEXT_LABEL;

	private static readonly string SELECT_RULE_TEXT_LABEL;

	private static readonly string TARGET_PLAYER_NAME_TEXT_LABEL;

	[SerializeField]
	private UIText titleRuleText;

	[SerializeField]
	private UIText titleTargetText;

	[SerializeField]
	private List<UnionTargetPlate> targetNamePlateList;

	[SerializeField]
	private UIText battleRuleText;

	[SerializeField]
	private CanvasGroup canvasGroup;

	public void Init()
	{
	}

	public void SetText(string txtPlayerName, int ruleIndex, MessageEnumData.MsgLangId langId)
	{
	}

	public void SetText(List<UnionMatchWaitData> matchWaitDataList, int ruleIndex)
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	private string GetRuleText(int ruleIndex)
	{
		return null;
	}
}
