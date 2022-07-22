namespace Dpr.FureaiHiroba;

public class PokeSanpoPairModel
{
	public FureaiPokeModel masterPoke;

	public FureaiPokeModel slavePoke;

	public bool isMaster;

	public FureaiPokeModel self => null;

	public FureaiPokeModel pair => null;

	public PokeSanpoPairModel(bool isMaster, FureaiPokeModel masterPoke, FureaiPokeModel slavePoke)
	{
	}

	public void Destroy()
	{
	}
}
