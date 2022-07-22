using UnityEngine;

namespace Dpr.Contest;

[CreateAssetMenu]
public class ResultSettings : ScriptableObject
{
	public float addRankGaugeDuration;

	public float addScoreGaugeDuration;

	public Vector3 confettiPos;

	public WaitTimeData waitTimeData;
}
