using System;

namespace INL1;

internal class IlcaNetSwkInlineService
{
	public enum UpdateSKICs
	{
		RUNNING,
		NORMALL_END,
		CRASH_END
	}

	private const int TextMaxLength = 500;

	private static byte[] SoftwareKeyboardTextBuff;

	public static string SoftwareKeyboardText;

	public static void InitializeSoftwareKeyboardInlineCs(uint textMaxLength, int textMinLength, int HeapSize = 16777216, bool miniaturize = false, uint invalidButtonFlag = 0u, uint invalidCharFlag = 0u, bool isCancelButtonDisabled = false, bool isPredictionEnabled = false, bool isUseNewLine = false, uint keyboardMode = 0u, short leftOptionalSymbolKey = 0, short rightOptionalSymbolKey = 0)
	{
	}

	public static UpdateSKICs UpdateSoftwareKeyboardInlineCs()
	{
		return default(UpdateSKICs);
	}

	public static void FinalizeSoftwareKeyboardInlineCs()
	{
	}

	public static bool GetImageSoftwareKeyboardInlineCs(out IntPtr buff, out int size)
	{
		return default(bool);
	}
}
