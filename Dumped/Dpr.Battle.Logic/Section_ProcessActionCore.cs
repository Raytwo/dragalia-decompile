using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_ProcessActionCore : Section
{
	public class Description
	{
		public PokeAction pokeAction;
	}

	public class Result
	{
	}

	public Section_ProcessActionCore([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void onLegendDemo_legendPokeAction(BTL_POKEPARAM pActPoke)
	{
	}

	private bool cantActionByFreeFall(PokeAction pokeAction)
	{
		return default(bool);
	}

	private void cancelAction(PokeAction pokeAction)
	{
	}

	private void reinforceRaidBoss(PokeAction pokeAction)
	{
	}

	private void putInterruptActionInfo(PokeAction pokeAction)
	{
	}

	private void event_StartAction(PokeAction pokeAction)
	{
	}

	private void action(PokeAction pokeAction)
	{
	}

	private void action_Fight(PokeAction pokeAction)
	{
	}

	private void action_Change(PokeAction pokeAction)
	{
	}

	private byte memberChange(PokeAction pokeAction)
	{
		return default(byte);
	}

	private void afterMemberIn(byte inPokeID)
	{
	}

	private void action_CantAction(PokeAction pokeAction)
	{
	}

	private bool action_Escape(PokeAction pokeAction)
	{
		return default(bool);
	}

	private void action_ItemUse(PokeAction action)
	{
	}

	private void action_GStart(PokeAction pPokeAction)
	{
	}

	private void action_Cheer(PokeAction pPokeAction)
	{
	}

	private void action_RaidBossExtraAction(PokeAction pPokeAction)
	{
	}

	private void event_EndAction(PokeAction pokeAction)
	{
	}
}
