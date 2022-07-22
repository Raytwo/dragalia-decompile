using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UnderGround.LightStone;

public class UgLightStoneGauge : MonoBehaviour
{
	[SerializeField]
	private UgLightStoneCount lightStoneCount;

	[SerializeField]
	private Image gauge;

	[SerializeField]
	private Animator rainbowEffectAnim;

	private void Start()
	{
	}

	public void Initialize()
	{
	}

	public void UpdateStoneNum()
	{
	}

	public void UpdateBonusState()
	{
	}
}
