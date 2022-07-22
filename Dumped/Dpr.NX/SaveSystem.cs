using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Dpr.NX;

public class SaveSystem
{
	public const string MOUNT_NAME = "SaveData";

	public const string SAVEDATA_PATH = "SaveData:/SaveData.bin";

	public const string BACKUP_PATH = "SaveData:/Backup.bin";

	public static readonly int SAVELOAD_BUFFER_SIZE;

	private static SaveSystem _Instance;

	private bool _isMounted;

	private bool _isBusy;

	private byte[] _buffer;

	private Thread _saveLoadThread;

	private bool _threadEnable;

	private bool _saveRequest;

	private byte[] _saveDataPtr;

	private bool _writeMain;

	private bool _writeBackup;

	private bool _loadRequest;

	private bool _fromBackup;

	private bool _loadResult;

	private Action<bool> _postLoadFunction;

	private SynchronizationContext _mainThread;

	private SaveSystem()
	{
	}

	public static bool IsBusy()
	{
		return default(bool);
	}

	public static byte[] GetLoadedData()
	{
		return null;
	}

	public static bool Save(byte[] data, bool writeMain, bool writeBackup)
	{
		return default(bool);
	}

	public static void SaveAsync(byte[] data, bool writeMain, bool writeBackup)
	{
	}

	public static bool Load(bool fromBackup)
	{
		return default(bool);
	}

	public static bool LoadCore(string path)
	{
		return default(bool);
	}

	public static void LoadAsync(bool fromBackup, [Optional] Action<bool> onComplete)
	{
	}

	public static bool SaveDataExists()
	{
		return default(bool);
	}

	public static bool BackupExists()
	{
		return default(bool);
	}

	private void MountSaveData()
	{
	}

	private void StartThread()
	{
	}

	private void ThreadLoop()
	{
	}

	private static void OnPostSave(object state)
	{
	}

	private static void OnPostLoad(object state)
	{
	}
}
