using System.Runtime.InteropServices;

public class AkLogger
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void ErrorLoggerInteropDelegate(string message);

	private static AkLogger ms_Instance;

	private ErrorLoggerInteropDelegate errorLoggerDelegate;

	public static AkLogger Instance => null;

	private AkLogger()
	{
	}

	~AkLogger()
	{
	}

	public void Init()
	{
	}

	public static void WwiseInternalLogError(string message)
	{
	}

	public static void Message(string message)
	{
	}

	public static void Warning(string message)
	{
	}

	public static void Error(string message)
	{
	}
}
