using System;

public class PlayReportEvent
{
	public const int PLAYREPORT_SIZE = 56;

	public const int DEFAULT_BUFFER_SIZE = 512;

	private IntPtr _playReportPtr;

	private IntPtr _buffer;

	private static extern int GetPlayReportSize();

	private static extern void CreatePlayReportEvent(string eventName, IntPtr prepoEventPtr, IntPtr buffer, int bufferSize);

	private static extern void SavePlayReportEvent(IntPtr eventPtr, ulong uid0, ulong uid1);

	private static extern void AddBoolValue(IntPtr eventPtr, string key, bool value);

	private static extern void AddLongValue(IntPtr eventPtr, string key, long value);

	private static extern void AddCharValue(IntPtr eventPtr, string key, string value);

	public PlayReportEvent(string eventName, int bufferSize = 512)
	{
	}

	~PlayReportEvent()
	{
	}

	public void SaveEvent()
	{
	}

	public void AddBool(string key, bool value)
	{
	}

	public void AddLong(string key, long value)
	{
	}

	public void AddString(string key, string value)
	{
	}
}
