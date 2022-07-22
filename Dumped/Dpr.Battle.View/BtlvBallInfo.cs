using Dpr.BallDeco;
using Pml;

namespace Dpr.Battle.View;

public struct BtlvBallInfo
{
	public static readonly BtlvBallInfo Default;

	public BallId ballId;

	public bool hasCapsule;

	public bool isStrangeBall;

	public AffixSealData[] affixSealDatas;

	public byte sealCnt;

	public bool HasBallSeal => default(bool);

	public void Clear()
	{
	}
}
