using UnityEngine;

[DisallowMultipleComponent]
[DefaultExecutionOrder(0)]
public class AkInitializer : MonoBehaviour
{
	private static AkInitializer ms_Instance;

	public AkWwiseInitializationSettings InitializationSettings;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	private void OnApplicationFocus(bool focus)
	{
	}

	private void OnApplicationQuit()
	{
	}

	public void LateUpdate()
	{
	}
}
