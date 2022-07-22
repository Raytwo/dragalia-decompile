using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace INL1;

public class IlcaNetServerDelivery : IlcaNetServer
{
	private static Stopwatch sp;

	private static TimeSpan span;

	private static bool isMount;

	public const int OkurimonoIdFlagArray256size = 256;

	public const int FileFlagArraySize = 13;

	public const int MaxFileNameArraySize = 100;

	private static bool isReading;

	private static uint s_directoryNum;

	private static uint s_fileNum;

	private static byte[] s_data;

	private static bool s_finish;

	private static int s_ret;

	public static void Init()
	{
	}

	public static bool MountStorageAsync(MonoBehaviour callobj, IlcaNetServerAsyncCallback callback)
	{
		return default(bool);
	}

	private static IEnumerator MountStorageAsyncCore(IlcaNetServerAsyncCallback callback)
	{
		return null;
	}

	private static IEnumerator MountStorageAsyncCoreSub2()
	{
		return null;
	}

	public static bool UnMountStorage()
	{
		return default(bool);
	}

	public static bool ImmediateSyncRequestAsync(MonoBehaviour callobj, IlcaNetServerAsyncCallback callback)
	{
		return default(bool);
	}

	public static bool ImmediateSyncRequestAsync(MonoBehaviour callobj, IlcaNetServerAsyncCallback callback, bool mount)
	{
		return default(bool);
	}

	private static IEnumerator ImmediateSyncRequestAsyncCore(IlcaNetServerAsyncCallback callback, bool mount)
	{
		return null;
	}

	public static int FileCountGet(uint directoryNum)
	{
		return default(int);
	}

	public static bool OkurimonoIdFlagCheck(int OkurimonoID, byte[] OkurimonoIdFlagArray256)
	{
		return default(bool);
	}

	public static bool OkurimonoIdFlagSet(int OkurimonoID, ref byte[] OkurimonoIdFlagArray256)
	{
		return default(bool);
	}

	public static bool OkurimonoIdFlagInit(ref byte[] OkurimonoIdFlagArray256)
	{
		return default(bool);
	}

	public static bool FileFlagCheck(byte fileName, byte[] fileFlagArray)
	{
		return default(bool);
	}

	public static bool FileFlagSet(byte fileName, ref byte[] fileFlagArray)
	{
		return default(bool);
	}

	public static List<byte> FileListGetWithFlag(uint directoryNum, byte[] fileFlagArray)
	{
		return null;
	}

	public static int FileCountNameArrayGet(uint directoryNum, byte[] fileNameArray)
	{
		return default(int);
	}

	public static long FileSizeGet(uint directoryNum, uint fileNum)
	{
		return default(long);
	}

	public static int FileRead(uint directoryNum, uint fileNum, byte[] data)
	{
		return default(int);
	}

	public static bool FileReadAsync(MonoBehaviour callobj, uint directoryNum, uint fileNum, byte[] data, IlcaNetServerAsyncCallback callback)
	{
		return default(bool);
	}

	private static IEnumerator FileReadAsyncCore(uint directoryNum, uint fileNum, byte[] data, IlcaNetServerAsyncCallback callback)
	{
		return null;
	}

	private static void FileReadWorkerThread()
	{
	}
}
