using System;
using System.Collections;
using System.Collections.Generic;
using DPData;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class TvRankingWindow : UIWindow
{
	[Serializable]
	private class RankingParam
	{
		public Sprite titleBg;
	}

	public class Param
	{
		public enum RankingType
		{
			Group,
			Global,
			Num
		}

		public enum RankingCategory
		{
			Pokemon,
			BattleTower,
			Contest,
			Num
		}

		public RankingType rankingType;

		public RankingCategory rankingCategory;
	}

	[SerializeField]
	private UIText _title;

	[SerializeField]
	private UIText _subTitie;

	[SerializeField]
	private Image _titleBg;

	[SerializeField]
	private Cursor _cursorMenu;

	[SerializeField]
	private Cursor _cursorRank;

	[SerializeField]
	private RectTransform _menuItemRoot;

	[SerializeField]
	private RectTransform _rankItemRoot;

	[SerializeField]
	private UIText _menuDescription;

	[SerializeField]
	private RankingParam[] _rankingParam;

	private int _selectMenuIndex;

	private int _selectRankIndex;

	private List<TvRankingMenuItem> _menuItems;

	private List<TvRankingRankItem> _rankItems;

	private bool _isActiveMenu;

	private const int _rankMaxNum = 6;

	private Param _param;

	public override void OnCreate()
	{
	}

	public void Open(Param param, UIWindowID prevWindowId)
	{
	}

	public IEnumerator OpOpen(Param param, UIWindowID prevWindowId)
	{
		return null;
	}

	public static int GetRankingId(RECORD_ID recordId)
	{
		return default(int);
	}

	public static int GetRankingFlagIndex(int rankingId, Param.RankingType rankingType)
	{
		return default(int);
	}

	private void SetupRankParamRanks(List<TvRankingMenuItem.RankParam> rankParams)
	{
	}

	private void SetupRanking(TvRankingMenuItem menuItem)
	{
	}

	private void SetupKeyguide()
	{
	}

	public void Close(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
	}

	public IEnumerator OpClose(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void DeleteRank()
	{
	}

	protected override void OnAddContextMenuYesNoItemParams(List<ContextMenuItem.Param> contextMenuItemParams)
	{
	}

	private void SetActiveList(bool isActiveMenu)
	{
	}

	private bool UpdateSelect()
	{
		return default(bool);
	}

	private bool UpdateSelectMenu()
	{
		return default(bool);
	}

	private bool SetSelectMenuIndex(int selectIndex, bool isInitialize = false)
	{
		return default(bool);
	}

	private bool UpdateSelectRank()
	{
		return default(bool);
	}

	private bool SetSelectRankingIndex(int selectIndex, bool isInitialize = false)
	{
		return default(bool);
	}
}
