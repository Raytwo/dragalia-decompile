using NexPlugin;

namespace NexAssets;

public class Ranking2Board : RankingBoardBase
{
	public enum GUIINDEX
	{
		PID = 1,
		UID = 2,
		RANK = 4,
		SCORE = 8,
		MISC = 0x10,
		COMMON = 0x20
	}

	private enum GUIINDEX_NUM
	{
		RANK,
		PID,
		UID,
		SCORE,
		MISC,
		COMMON,
		MAX
	}

	public bool m_ParamFold;

	private Ranking2Info m_RankingInfo;

	public GUIINDEX m_GuiIndex;

	public COLUMN_ARG rankArg;

	public COLUMN_ARG pidArg;

	public COLUMN_ARG uidArg;

	public COLUMN_ARG scoreArg;

	public COLUMN_ARG miscArg;

	public COLUMN_ARG commonArg;

	protected override string HeaderTextTag => null;

	protected override string ParamTextTag => null;

	public void ShowRankingBoard(Ranking2Info rankingInfo, bool enable = true)
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
