using SmartPoint.AssetAssistant;

namespace Audio;

public class AudioData : RefCounted
{
	public enum LoadState
	{
		None,
		Loading,
		Loaded,
		Unloading
	}

	public string _bankName;

	public uint _bankId;

	public LoadState _loadState;

	public override int Release()
	{
		return default(int);
	}
}
