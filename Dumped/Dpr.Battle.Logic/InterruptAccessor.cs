namespace Dpr.Battle.Logic;

public sealed class InterruptAccessor
{
	private InterruptCode m_interrupt;

	public void Clear()
	{
	}

	public void Request(InterruptCode interrupt)
	{
	}

	public bool IsRequested(InterruptCode interrupt)
	{
		return default(bool);
	}

	public bool IsRequested()
	{
		return default(bool);
	}

	public InterruptCode GetRequest()
	{
		return default(InterruptCode);
	}
}
