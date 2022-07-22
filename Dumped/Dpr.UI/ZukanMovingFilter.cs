using System.Runtime.InteropServices;
using Audio;

namespace Dpr.UI;

public class ZukanMovingFilter : ZukanMovingEffecter
{
	public void OnUpdate(float deltaTime, [Optional] AudioInstance voiceInstance)
	{
	}

	public float GetSensorValue()
	{
		return default(float);
	}
}
