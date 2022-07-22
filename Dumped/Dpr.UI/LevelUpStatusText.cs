using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class LevelUpStatusText : MonoBehaviour
{
	private const string MessageFileName = "ss_level_up";

	private const string AddStatusValueMessageLabel = "SS_level_up_01_02";

	private const float FadeInYValue = 10f;

	private const float FadeOutXValue = -10f;

	private const float FadeDuration = 0.5f;

	[SerializeField]
	private TextMeshProUGUI valueText;

	[SerializeField]
	private TextMeshProUGUI addValueText;

	[SerializeField]
	private Image addValueBaseImage;

	private int afterValue;

	public void SetValue(int value, int addValue)
	{
	}

	public void FadeInAddValue()
	{
	}

	public void FadeOutAddValue()
	{
	}
}
