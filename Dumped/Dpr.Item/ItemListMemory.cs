using System.Runtime.CompilerServices;

namespace Dpr.Item;

public class ItemListMemory
{
	public int CategoryIndex
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int[] Indexes
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float[] ScrollPositions
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int CurrentIndex => default(int);

	public float CurrentScrollPosition => default(float);

	public void SetCategory(int index)
	{
	}

	public void SetIndexAndScrollPosition(int index, float pos)
	{
	}

	public void Reset()
	{
	}
}
