using System;

namespace Nintendo.MessageStudio.Lib;

public abstract class BinLibmsFileBase : IDisposable
{
	private IntPtr resourceFilePtr;

	private IntPtr fileObjectPtr;

	private static LoadResource loadResourceFunc;

	private bool disposedValue;

	protected IntPtr FileObjectPtr => default(IntPtr);

	public bool IsFileLoaded => default(bool);

	public static void SetLoadResourceFunc(LoadResource func)
	{
	}

	public void Load(string fileName)
	{
	}

	protected void ResetResourceFilePtr(IntPtr resourceFilePtr)
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	~BinLibmsFileBase()
	{
	}

	public void Dispose()
	{
	}

	protected abstract IntPtr InitObject(IntPtr resourcePtr);

	protected abstract void CloseObject(IntPtr objectPtr);
}
