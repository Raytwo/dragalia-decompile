using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_StoreActions : Section
{
	public class Description
	{
		public PokeActionContainer pokeActionContainer;

		public SVCL_ACTION clientInstructions;
	}

	public class Result
	{
	}

	public Section_StoreActions([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void createPokeAction_FromClientInstruction(PokeActionContainer pokeActionContainer, SVCL_ACTION clientInstructions)
	{
	}

	private void createPokeAction_FromClientInstruction(PokeActionContainer actionContainer, SVCL_ACTION instructions, byte clientID)
	{
	}

	private bool setupPokeAction_FromClientInstruction(PokeAction pokeAction, [In] ref BTL_ACTION_PARAM clientInstruction, byte clientID)
	{
		return default(bool);
	}

	private BTL_POKEPARAM getActionPoke([In] ref BTL_ACTION_PARAM clientInstruction, byte clientID)
	{
		return null;
	}

	private void createPokeAction_G(PokeActionContainer pPokeActionContainer)
	{
	}

	private void setupPokeAction_G(PokeAction gAction, [In] ref PokeAction fightAction)
	{
	}
}
