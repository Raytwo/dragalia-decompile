using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class ZukanMovingPan : MonoBehaviour
{
	[SerializeField]
	private Slider _slider;

	private float[] _values;

	public void Setup()
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	public float GetSensorValue()
	{
		return default(float);
	}
}
