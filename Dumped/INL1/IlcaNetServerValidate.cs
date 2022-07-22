using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;

namespace INL1;

public class IlcaNetServerValidate : IlcaNetServer
{
	[Serializable]
	public class CheckRequest
	{
		public string NsaIdToken;

		public ushort PublicKeyVersion;

		public ushort ROMVersion;

		public ushort GameMode;

		public ushort DataNum;

		public byte[] Data;

		public bool patch;

		public static string Serialize(CheckRequest data)
		{
			return null;
		}

		public static byte[] SerializeBinary(CheckRequest data)
		{
			return null;
		}
	}

	[Serializable]
	public class CheckResponse
	{
		public byte success;

		public ushort ROMVersion;

		public ushort GameMode;

		public ushort DataNum;

		public uint[] DataResult;

		public byte[] Signature;

		public static CheckResponse Deserialize(string json)
		{
			return null;
		}

		public static CheckResponse DeserializeBinary(byte[] data)
		{
			return null;
		}
	}

	[Serializable]
	public class PublicKeyRequest
	{
		public string NsaIdToken;

		public static string Serialize(PublicKeyRequest data)
		{
			return null;
		}

		public static byte[] SerializeBinary(PublicKeyRequest data)
		{
			return null;
		}
	}

	[Serializable]
	public class PublicKeyResponse
	{
		public ushort PublicKeyVersion;

		public byte[] PublicKeyValueBASE64;

		public static PublicKeyResponse Deserialize(string json)
		{
			return null;
		}

		public static PublicKeyResponse DeserializeBinary(byte[] data)
		{
			return null;
		}
	}

	private const int PokeCoreSize = 328;

	public const string DefaultPublicKeyBASE64 = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAyfdgDoOQrnwDynmAWJuFzKHAy6na8v8jHtMkFXcGoM3ogRL07Bh+BSWOroOwpXrCkIlvEYCVA0gX4zis0wrwhRhavBtWCvPJCJTXpjxrMpssj2Tk1/23bPHnT+yOv1eBuuwCrHNgUVUeQ1WlV6RtlCPrKRFbtprMQQ5HPVTCK4m9iNXKPk5k6xZdGi9mYkz5BboqFH9RnZwrNStWXZlwMNOUheZy9gtf+U7mszwXTNSRc+j4nY06qd9Xm7cX1s+PWGffJWZroBUsXHNWzarNI8mIeieOyS5N0PI6AmQBpOR7BSzjTMCHT8Tw+5rjiRfGjguDJ5h97xMOkmfb1MSh/QIDAQAB";

	private static ushort nowPublicKeyVersion;

	private static byte[] nowPublicKeyBASE64;

	private static byte[] nowPublicKeyBASE64Decode;

	private static CheckResponse cres;

	private static PublicKeyResponse pkres;

	private static MonoBehaviour s_callobj;

	private static CheckRequest s_cReq;

	private static IlcaNetServerAsyncCallback s_usercallback;

	private static bool next;

	private static bool abort;

	private static byte[] data;

	private static byte[] checkDataForVerifySignature;

	private static byte[] buffValidate;

	public const uint SignatureSize = 256u;

	public const uint PublicKeySizeBASE64 = 392u;

	static IlcaNetServerValidate()
	{
	}

	public static void Init(ushort publicKeyversion = 0, [Optional] byte[] publicKey)
	{
	}

	public static bool PublicKeyResponseGet(ref PublicKeyResponse pkr)
	{
		return default(bool);
	}

	public static bool CheckResponseGet(ref CheckResponse cr)
	{
		return default(bool);
	}

	public static bool CheckRequestAutoAsync(MonoBehaviour callobj, CheckRequest creq, IlcaNetServerAsyncCallback callback)
	{
		return default(bool);
	}

	private static void PublicKeySet(ushort ver, byte[] pk)
	{
	}

	private static void CheckRequestAutoCallback(bool isSuccess, IlcaNetServerCallbackEventType eve, IlcaNetServerCallbackResult result, long responseCode, string responseStr)
	{
	}

	private static bool CheckRequestAsync(MonoBehaviour callobj, CheckRequest cr, IlcaNetServerAsyncCallback callback)
	{
		return default(bool);
	}

	private static void CallbackNSAIDT(bool isSuccess, IlcaNetServerCallbackEventType eve, IlcaNetServerCallbackResult result, long responseCode, string responseStr)
	{
	}

	private static void NextAbort(bool isSuccess)
	{
	}

	private static IEnumerator CheckRequestAsyncCore(MonoBehaviour callobj, CheckRequest cr, IlcaNetServerAsyncCallback callback)
	{
		return null;
	}

	private static bool PublicKeyRequestAsync(MonoBehaviour callobj, IlcaNetServerAsyncCallback callback)
	{
		return default(bool);
	}

	private static IEnumerator PublicKeyRequestAsyncCore(MonoBehaviour callobj, IlcaNetServerAsyncCallback callback)
	{
		return null;
	}

	public static bool CheckVerifySignatureAdd4byte(byte[] coreDataAdd4byte, byte[] signature)
	{
		return default(bool);
	}

	private static bool CheckVerifySignature(CheckRequest creq, byte[] signature)
	{
		return default(bool);
	}

	public static byte[] CheckDataMakeAndSet(CheckRequest creq)
	{
		return null;
	}
}
