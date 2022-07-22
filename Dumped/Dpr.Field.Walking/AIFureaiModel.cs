using System;
using Dpr.FureaiHiroba;

namespace Dpr.Field.Walking;

public class AIFureaiModel : AIModel
{
	public PokeSanpoModel sanpoModel;

	public Action OnPlayerNear;

	public Emoticon emoticon;

	public FureaiPokeModel fureaiModel => null;

	public AIFureaiModel(FureaiPokeController controller)
	{
	}

	public override void Destroy()
	{
	}
}
