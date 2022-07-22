using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NexAssets;

public abstract class RankingBoardBase : MonoBehaviour
{
	public enum SIZE_TYPE
	{
		PIXEL,
		PERCENTAGE
	}

	public enum POSITION_TYPE
	{
		ALIGN,
		INPUT
	}

	public enum POSITION_ALIGN_V
	{
		TOP,
		CENTER,
		BOTTOM
	}

	public enum POSITION_ALIGN_H
	{
		LEFT,
		CENTER,
		RIGHT
	}

	[Serializable]
	public struct COLUMN_ARG
	{
		public int indexType;

		public int priority;

		public int param;

		public int size;

		public string title;

		public bool disp;

		public COLUMN_ARG(int indexType_, string title_)
		{
		}
	}

	[Serializable]
	public class RankingBoardParam
	{
		public bool GuiFold;

		public GUISkin GuiSkin;

		public string ScoreboardTitle;

		public int TitleHeight;

		public SIZE_TYPE GuiSizeType;

		public POSITION_TYPE GuiPosType;

		public POSITION_ALIGN_V GuiPosAlign_v;

		public POSITION_ALIGN_H GuiPosAlign_h;

		public int GuiPosMargin_v;

		public int GuiPosMargin_h;

		public Vector2 RankingBoardPosition;

		public Vector2 RankingBoardSize;

		public Vector2 RankingBoardPercentage;
	}

	protected const int MENU_WIDTH = 320;

	protected const int MENU_HEIGHT = 240;

	protected const int COLUMN_SIZE = 48;

	protected const float GUI_BASE_ALPHA = 1f;

	private Image m_RankingPanel;

	private Image m_RankingNoneDataPanel;

	private Image m_HeaderScrollArea;

	private Image m_HeaderScrollPanel;

	private Image m_ScrollArea;

	private Image m_ScrollPanel;

	private Scrollbar m_VScrollbar;

	private Scrollbar m_HScrollbar;

	private GameObject[] m_HeaderObj;

	private GameObject[] m_CellObj;

	protected List<COLUMN_ARG> m_ColumnList;

	public RankingBoardParam m_RankingBoardParam;

	private Image RankingPanel => null;

	private Image RankingNoneDataPanel => null;

	private Image HeaderScrollArea => null;

	private Image HeaderScrollPanel => null;

	private Image ScrollArea => null;

	private Image ScrollPanel => null;

	private Scrollbar VScrollbar => null;

	private Scrollbar HScrollbar => null;

	private GameObject[] HeaderObj => null;

	private GameObject[] CellObj => null;

	public float VScroll
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float HScroll
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	protected abstract string HeaderTextTag { get; }

	protected abstract string ParamTextTag { get; }

	protected void Start()
	{
	}

	public void SetRankingBoardEnable(bool enable)
	{
	}

	protected abstract void CreateColumnIndex();

	protected abstract string GetContent(COLUMN_ARG columnArg);

	protected abstract int GetDataCount();

	protected void CreateColumn(COLUMN_ARG columnArg)
	{
	}

	protected void RankingBoard(bool enable = true)
	{
	}
}
