using System;
using nn.account;

namespace INL1;

public class IlcaNetNative
{
	public static extern void CallSwitchNativeFunction(int i);

	public static extern void PrintLine(string line);

	public static extern void ErrorViewerDispCancelControl(bool on);

	public static extern void ShowApplicationError(uint code, string dialog, string screen, string lang);

	public static extern void InternetCurrentTimeGet(ref long getTime);

	public static extern void InitializeSoftwareKeyboardInline(uint textMaxLength, int textMinLength, int HeapSize = 16777216, bool miniaturize = false, uint invalidButtonFlag = 0u, uint invalidCharFlag = 0u, bool isCancelButtonDisabled = false, bool isPredictionEnabled = false, bool isUseNewLine = false, uint keyboardMode = 0u, short leftOptionalSymbolKey = 0, short rightOptionalSymbolKey = 0);

	public static extern int UpdateSoftwareKeyboardInline(byte[] text, ref int size);

	public static extern void FinalizeSoftwareKeyboardInline();

	public static extern bool GetImageSoftwareKeyboardInline(out IntPtr buff, out int size);

	public static extern bool LICLoadNetworkServiceLicenseInfoAsync(UserHandle user);

	public static extern bool LICLoadNetworkServiceLicenseInfoAsyncWait();

	public static extern int LICGetNetworkServiceLicenseKind();

	public static extern bool VerifySignature(byte[] pPublicKey, int publicKeysize, byte[] pPokemonDataList, int pokemonListSize, byte[] pSignature);

	public static extern void BCATInitialize();

	public static extern void BCATMountDeliveryCacheStorage();

	public static extern bool BCATMountDeliveryCheck();

	public static extern int BCATMountDeliveryCheck2();

	public static extern int BCATMountDeliveryCheck3();

	public static extern int BCATWaitForDone();

	public static extern void BCATgetStart();

	public static extern void BCATgetStart2();

	public static extern bool BCATgetStart2x1();

	public static extern bool BCATgetStart2x2();

	public static extern int BCATgetStart3();

	public static extern void BCATEnumerateAll();

	public static extern void BCATUnmountDeliveryCacheStorage();

	public static extern int BCATFileCountGet(uint dirNum);

	public static extern int BCATFileCountListGet(uint dirNum, byte[] fileNameArray);

	public static extern long BCATFileSizeGet(uint dirNum, uint fileNum);

	public static extern int BCATFileRead(uint dirnum, uint filenum, byte[] data, int dataMaxSize);

	public static extern ushort FP32toFP16(float src);

	public static extern float FP16toFP32(ushort src);

	public static extern uint FP32toFP24(float src);

	public static extern float FP24toFP32(uint src);

	public static extern float BToFP32(uint src);

	public static extern uint FP32ToB(float src);

	public static extern double BToFP64(ulong src);

	public static extern ulong FP64ToB(double src);

	public static extern int INLpiaSessionGetStatus();

	public static extern int INLpiaSessionGetSessionId();

	public static extern int INLpiaSessionIsHost();

	public static extern int INLpiaSessionGetHostStationIndex();

	public static extern int INLpiaSessionGetThisStationIndex();

	public static extern ulong INLpiaSessionGetHostConstantId();

	public static extern ulong INLpiaSessionGetThisConstantId();

	public static extern int INLpiaSessionGetStationIndex(ulong id);

	public static extern ulong INLpiaSessionGetConstantId(uint id);

	public static extern int INLpiaSessionGetPlayerNum();

	public static extern int INLpiaSessionGetStationNum();

	public static extern int INLpiaSessionGetPlayerInfo(ulong id, byte[] name, ref byte lang, ref uint nameBytes);

	public static extern int INLpiaSessionGetConstantIdArray(ulong[] id_array);

	public static extern int INLpiaSessionGetRttArray(int[] rtt_array, int maxStation);

	public static extern int INLpiaStationTURNconnectIndex(uint id);

	public static extern int INLpiaStationTURNconnectConstantID(ulong constantid);

	public static extern uint INLnifmGetCurrentPrimaryIpAddress();

	public static extern bool NEXTradeObject(int target_point, byte[] core_binary, int core_binary_size, byte[] signature_binary, int signature_binary_size, IntPtr ptr);

	public static extern int NEXTradeObjectPolling();

	public static extern void NEXTradeObjectSuccessGet(byte[] core_binary, ref int core_binarysize, byte[] signature_binary, ref int signature_binarysize, ref ushort point);

	public static extern uint NEXTradeObjectResultGet();

	public static extern void hagegga(byte[] nanka, int size);
}
