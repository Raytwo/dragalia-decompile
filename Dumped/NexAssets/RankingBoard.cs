using NexPlugin;

namespace NexAssets;

public class RankingBoard : RankingBoardBase
{
	public enum GUIINDEX
	{
		PID = 1,
		UID = 2,
		CATEGORY = 4,
		ORDER = 8,
		SCORE = 0x10,
		GROUP0 = 0x20,
		GROUP1 = 0x40,
		PARAM = 0x80,
		COMMON = 0x100
	}

	private enum GUIINDEX_NUM
	{
		ORDER,
		PID,
		UID,
		CATEGORY,
		SCORE,
		GROUP0,
		GROUP1,
		PARAM,
		COMMON,
		MAX
	}

	public bool m_ParamFold;

	private RankingResult m_RankingInfo;

	public GUIINDEX m_GuiIndex;

	public COLUMN_ARG orderArg;

	public COLUMN_ARG pidArg;

	public COLUMN_ARG uidArg;

	public COLUMN_ARG categoryArg;

	public COLUMN_ARG scoreArg;

	public COLUMN_ARG group0Arg;

	public COLUMN_ARG group1Arg;

	public COLUMN_ARG paramArg;

	public COLUMN_ARG commonArg;

	protected override string HeaderTextTag => null;

	protected override string ParamTextTag => null;

	public void ShowRankingBoard(RankingResult rankingInfo, bool enable = true)
	{
	}

	protected override void CreateColumnIndex()
	{
	}

	protected override int GetDataCount()
	{
		return default(int);
	}

	protected override string GetContent(COLUMN_ARG columnArg)
	{
		return null;
	}
}
