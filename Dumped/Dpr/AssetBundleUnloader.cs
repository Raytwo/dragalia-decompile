using SmartPoint.AssetAssistant;

namespace Dpr;

public class AssetBundleUnloader : RefCounted
{
	private string _assetBundleName;

	private bool _isUnloadAllLoadedObjects;

	private int _unloadDelayFrameCount;

	private bool _isUnloaded;

	public string assetBundleName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool isUnloadAllLoadedObjects
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public int unloadDelayFrameCount
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public bool isUnloaded
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public override int Release()
	{
		return default(int);
	}
}
