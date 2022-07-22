public class AkSoundEngineController
{
	private static AkSoundEngineController ms_Instance;

	public static AkSoundEngineController _Instance
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static AkSoundEngineController Instance => null;

	private AkSoundEngineController()
	{
	}

	~AkSoundEngineController()
	{
	}

	public void LateUpdate()
	{
	}

	public void Init(AkInitializer akInitializer)
	{
	}

	public void OnDisable()
	{
	}

	public void Terminate()
	{
	}

	public void OnApplicationPause(bool pauseStatus)
	{
	}

	public void OnApplicationFocus(bool focus)
	{
	}

	private void ActivateAudio(bool activate, bool renderAnyway = false)
	{
	}
}
