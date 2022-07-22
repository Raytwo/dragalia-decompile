public abstract class AkCommonPlatformSettings : AkBasePlatformSettings
{
	public override AkInitializationSettings AkInitializationSettings => null;

	public override AkSpatialAudioInitSettings AkSpatialAudioInitSettings => null;

	public override AkCallbackManager.InitializationSettings CallbackManagerInitializationSettings => null;

	public override string InitialLanguage => null;

	public override string SoundBankPersistentDataPath => null;

	public override bool RenderDuringFocusLoss => default(bool);

	public override string SoundbankPath => null;

	public override bool UseAsyncOpen => default(bool);

	public override AkCommunicationSettings AkCommunicationSettings => null;

	protected abstract AkCommonUserSettings GetUserSettings();

	protected abstract AkCommonAdvancedSettings GetAdvancedSettings();

	protected abstract AkCommonCommSettings GetCommsSettings();
}
