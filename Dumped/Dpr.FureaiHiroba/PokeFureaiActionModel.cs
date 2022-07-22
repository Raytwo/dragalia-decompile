using Dpr.Field.Walking;

namespace Dpr.FureaiHiroba;

public class PokeFureaiActionModel
{
	public CorSystem corSystem;

	protected float IntervalTime;

	protected float elapsedTime;

	public bool IsAction => default(bool);

	protected void Init()
	{
	}
}
