using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;

namespace INL1;

public class IlcaNetServerSerial : IlcaNetServer
{
	[Serializable]
	public class CheckSerialRequest
	{
		public string nuid;

		public string rom;

		public string serialcode;

		public string tok;

		public string langcode;

		public static string Serialize(CheckSerialRequest data)
		{
			return null;
		}
	}

	[Serializable]
	public class SerialResponseAuth
	{
		public string serialcodeStatus;

		public ushort dataNo;

		public static SerialResponseAuth Deserialize(string json)
		{
			return null;
		}
	}

	[Serializable]
	public class SerialResponseUpdate
	{
		public string serialcodeStatus;

		public static SerialResponseUpdate Deserialize(string json)
		{
			return null;
		}
	}

	private static CheckSerialRequest scsr;

	private static SerialResponseAuth sra;

	private static SerialResponseUpdate sru;

	private static bool next;

	private static bool abort;

	public static bool CheckSerialResponseGet(ref SerialResponseAuth RetSra)
	{
		return default(bool);
	}

	public static bool UpdateSerialResponseGet(ref SerialResponseUpdate RetSru)
	{
		return default(bool);
	}

	public static bool CheckSerialRequestAsync(MonoBehaviour callobj, CheckSerialRequest csr, IlcaNetServerAsyncCallback callback, [Optional] string nsaidtOver, ulong nexid = 0uL)
	{
		return default(bool);
	}

	public static bool UpdateSerialRequestAsync(MonoBehaviour callobj, IlcaNetServerAsyncCallback callback)
	{
		return default(bool);
	}

	private static void CallbackNSAIDT(bool isSuccess, IlcaNetServerCallbackEventType eve, IlcaNetServerCallbackResult result, long responseCode, string responseStr)
	{
	}

	private static void NextAbort(bool isSuccess)
	{
	}

	private static IEnumerator CheckSerialRequestAsyncCore(MonoBehaviour callobj, CheckSerialRequest csr, IlcaNetServerAsyncCallback callback, bool auth)
	{
		return null;
	}
}
