using System;
using System.Runtime.InteropServices;

namespace NexPlugin;

[StructLayout(0, Size = 8)]
public struct NpDateTime
{
	public short year;

	public byte month;

	public byte day;

	public byte hour;

	public byte minute;

	public byte second;

	private byte isNotNever;

	public static readonly NpDateTime INVALID_DATE_TIME;

	public static readonly NpDateTime Future;

	public static readonly NpDateTime PERMANENT_DATE_TIME;

	public static readonly NpDateTime Never;

	public NpDateTime(DateTime dt)
	{
	}

	public NpDateTime(short srcYear, byte srcMonth, byte srcDay, byte srcHour, byte srcMinute, byte srcSecond)
	{
	}

	public NpDateTime(IntPtr src)
	{
	}

	public NpDateTime(bool notnever)
	{
	}

	public void Trace()
	{
	}

	internal new string ToString()
	{
		return null;
	}
}
