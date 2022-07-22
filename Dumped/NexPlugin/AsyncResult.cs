using nn;

namespace NexPlugin;

public class AsyncResult
{
	public uint asyncId;

	public AsyncResultNum asyncNum;

	public Result nnResult;

	public uint netErrCode;

	public int returnCode;

	public uint errorCode;

	public bool IsSuccess()
	{
		return default(bool);
	}

	public bool IsFailure()
	{
		return default(bool);
	}

	public void Trace()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
