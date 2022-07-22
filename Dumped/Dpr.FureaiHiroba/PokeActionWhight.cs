using Dpr.SubContents;

namespace Dpr.FureaiHiroba;

public class PokeActionWhight : IHaveWeight
{
	public string Name;

	public int ActionNo;

	private float _weight;

	public float lotteryWeight => default(float);

	public PokeActionWhight(string name, int ActionNo, float weight)
	{
	}
}
