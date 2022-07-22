using Dpr.Trainer;

namespace Dpr.Battle.View;

public struct TrainerSimpleParam
{
	public TrainerType trainerType;

	public string modelID;

	public int colorID;

	public int hatVariation;

	public int shoesVariation;

	public HandDominance dominanceHand;

	public HandDominance holdBallHand;

	public float loseLoopTime;

	public TrainerAge trainerAge;

	public int blinkIntervalMin;

	public int blinkIntervalMax;

	public int blinkTwiceRate;

	public static TrainerSimpleParam Factory(TrainerType trainerType)
	{
		return default(TrainerSimpleParam);
	}
}
