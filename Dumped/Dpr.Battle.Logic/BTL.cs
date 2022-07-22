using System.Text;

namespace Dpr.Battle.Logic;

public static class BTL
{
	private const string CONDITION = "DMY";

	public static int s_printBit;

	private static StringBuilder sb;

	public static StringBuilder GetStringBuilder(bool isClear = true)
	{
		return null;
	}

	public static void PRINT(BtlLog logType, string s)
	{
	}

	public static void PRINT(string s)
	{
	}

	public static void ASSERT(bool condition)
	{
	}

	public static void ASSERT(bool condition, string s)
	{
	}

	public static void SetEnableLog(BtlLog logType, bool isOn)
	{
	}

	public static bool IsEnableLog(BtlLog logType)
	{
		return default(bool);
	}

	public static void N_Printf(BtlDebugStrID strID, object[] args)
	{
	}

	public static void DEBUGPRINT_Ctrl()
	{
	}

	public static void N_PrintfSimple(BtlDebugStrID strID, object[] args)
	{
	}

	public static void UTIL_SetPrintType(BtlPrintType type)
	{
	}
}
