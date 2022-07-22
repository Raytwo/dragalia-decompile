using System;

namespace Dpr.NX;

internal class ClockSnapshot
{
	public const int SNAPSHOT_SIZE = 208;

	private static extern int GetSnapshotSize();

	private static extern void GetClockSnapshot(IntPtr buf);

	private static extern bool CompareClockSnapshot(IntPtr oldSnapshot, IntPtr newSnapshot);

	public static void GetSnapshot(ref byte[] buf)
	{
	}

	public static bool Compare(byte[] oldSnapshot, byte[] newSnapshot)
	{
		return default(bool);
	}
}
