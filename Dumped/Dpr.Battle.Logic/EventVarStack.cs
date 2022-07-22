namespace Dpr.Battle.Logic;

public sealed class EventVarStack
{
	private const uint EVENTVAL_STACK_DEPTH = 96u;

	private EventVar[] m_variables;

	private uint m_sp;

	private void createVariables()
	{
	}

	public void ToEmpty()
	{
	}

	public bool IsEmpty()
	{
		return default(bool);
	}

	public void Push()
	{
	}

	public void Pop()
	{
	}

	public EventVar GetNewPoint(EventVar.Label label)
	{
		return null;
	}
}
