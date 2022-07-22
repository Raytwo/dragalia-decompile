namespace Dpr.Battle.Logic;

public class EventVarSetStack
{
	private const uint STACK_SIZE = 32u;

	private EventVarSet[] m_varSets;

	private uint m_stackPointer;

	private void createVarSets()
	{
	}

	public void ToEmpty()
	{
	}

	public virtual void Dispose()
	{
	}

	public EventVarSet GetCurrent()
	{
		return null;
	}

	public void Push()
	{
	}

	public void Pop()
	{
	}
}
