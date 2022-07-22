namespace SmartPoint.Components;

public abstract class PlayerPrefsProvider<T> where T : new()
{
	private bool _loaded;

	private static T _instance;

	protected virtual string key => null;

	protected static T instance => (T)null;

	protected virtual void Initialization()
	{
	}

	protected virtual bool CustomLoadOperation()
	{
		return default(bool);
	}

	protected virtual bool CustomSaveOperation()
	{
		return default(bool);
	}

	protected virtual bool CustomLoadAsyncOperation()
	{
		return default(bool);
	}

	protected virtual bool CustomSaveAsyncOperation()
	{
		return default(bool);
	}

	protected virtual void OnPostLoad()
	{
	}

	protected virtual void OnPreSave()
	{
	}

	public static void Load(bool forceReload = false, bool isAsync = false)
	{
	}

	public static void Save(bool isAsync = false)
	{
	}

	public static void Clear()
	{
	}
}
