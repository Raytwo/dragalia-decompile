using System;
using System.Diagnostics;

public class SimpleStopwatch : IDisposable
{
	private string _label;

	private Stopwatch _stopwatch;

	private long _lastTime;

	public long elapsedMilliseconds => default(long);

	public long elapsedMillisecondsSinceLastCall => default(long);

	public SimpleStopwatch(string label)
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	~SimpleStopwatch()
	{
	}
}
