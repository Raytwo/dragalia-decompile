using UnityEngine;

public class AkBasePlatformSettings : ScriptableObject
{
	public virtual AkInitializationSettings AkInitializationSettings => null;

	public virtual AkSpatialAudioInitSettings AkSpatialAudioInitSettings => null;

	public virtual AkCallbackManager.InitializationSettings CallbackManagerInitializationSettings => null;

	public virtual string SoundBankPersistentDataPath => null;

	public virtual string InitialLanguage => null;

	public virtual bool RenderDuringFocusLoss => default(bool);

	public virtual string SoundbankPath => null;

	public virtual AkCommunicationSettings AkCommunicationSettings => null;

	public virtual bool UseAsyncOpen => default(bool);
}
