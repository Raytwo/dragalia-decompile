using UnityEngine;
using UnityEngine.UI;

namespace Dpr.DigFossil;

public class DigGauge : MonoBehaviour, IDigGauge
{
	[SerializeField]
	private Animator animator;

	[SerializeField]
	private Text debugGaugeValue;

	private float gaugeMax;

	private int stateNameHash;

	public void Initialize(float gaugeMax)
	{
	}

	public void SetGauge(float gaugeValue)
	{
	}
}
