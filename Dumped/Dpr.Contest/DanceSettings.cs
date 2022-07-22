using UnityEngine;

namespace Dpr.Contest;

[CreateAssetMenu]
public class DanceSettings : ScriptableObject
{
	public float waitEmitHeartSpan;

	public float notesFadeDuration;

	public float tensionIconTweenDuration;

	public float tensionIconJumpPower;

	public float waitWazaStartTime;

	public float addScoreGaugeValue;

	public float lockGaugeFxTime;

	public float gaugeIconJumpDuration;

	public float gaugeIconJumpPower;

	public int gaugeIconJumpCount;

	public float limitIconRotZ;
}
