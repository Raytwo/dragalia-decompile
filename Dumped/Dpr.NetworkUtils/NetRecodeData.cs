using DPData;

namespace Dpr.NetworkUtils;

public struct NetRecodeData
{
	public byte myVersion;

	public RECORD recodeData;

	public RANDOM_SEED randomSeed;

	public UnionWork.TvRecodeData tvRecode;

	public byte PersonalityIsNotEmpty;

	public int PersonalityBranchData;

	public TV_STR_DATA PersonalityPlayerName;

	public byte BallDecorationIsNotEmpty;

	public int BallDecorationBranchData;

	public int Trainer;

	public byte KasekihoriIsNotEmpty;

	public int KasekihoriBranchData;

	public int ItemNo;

	public TV_STR_DATA KasekihoriPlayerName;

	public byte StatueIsNotEmpty;

	public int StatueBranchData;

	public int StatueCount;

	public TV_STR_DATA StatuePlayerName;

	public byte FashionIsNotEmpty;

	public int FashionBranchData;

	public int Style;

	public int PlaceNo;

	public TV_STR_DATA FashionPlayerName;

	public RECORD_HEAD recodeHeadData;
}
