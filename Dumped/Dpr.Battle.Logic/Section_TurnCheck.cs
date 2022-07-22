using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_TurnCheck : Section
{
	public class Description
	{
	}

	public class Result
	{
	}

	private enum TurnCheckResult
	{
		DONE,
		LEVELUP,
		POKECHANGE,
		QUIT
	}

	private enum SeqturnCheck
	{
		SEQ_START,
		SEQ_WEATHER,
		SEQ_WEATHER_TERMINATE,
		SEQ_WEATHER_POKECHANGE,
		SEQ_KAWAIGARI_EFFECT,
		SEQ_EVENT_BEGIN,
		SEQ_EVENT_BEGIN_TERMINATE,
		SEQ_EVENT_BEGIN_POKECHANGE,
		SEQ_SICK,
		SEQ_SICK_TERMINATE,
		SEQ_SICK_POKECHANGE,
		SEQ_SIDE,
		SEQ_FIELD,
		SEQ_EVENT_END,
		SEQ_EVENT_END_TERMINATE,
		SEQ_EVENT_END_POKECHANGE,
		SEQ_EVENT_DONE,
		SEQ_END
	}

	public Section_TurnCheck([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private TurnCheckResult turnCheck()
	{
		return default(TurnCheckResult);
	}

	private void storeFrontPokeByAgilityOrder(PokeSet pPokeSet)
	{
	}

	private bool turnCheck_Weather()
	{
		return default(bool);
	}

	private void turnCheck_FriendshipCure()
	{
	}

	private bool turnCheck_Event(EventID eventID)
	{
		return default(bool);
	}

	private bool turnCheck_Sick()
	{
		return default(bool);
	}

	private void turnCheck_SideEffect()
	{
	}

	private void turnCheck_Field()
	{
	}
}
