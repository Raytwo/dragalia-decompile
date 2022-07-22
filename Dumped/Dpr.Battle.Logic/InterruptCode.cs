namespace Dpr.Battle.Logic;

public enum InterruptCode : byte
{
	NONE,
	POKE_CHANGE,
	POKE_COVER,
	LEVELUP,
	QUIT_SHOWDOWN,
	QUIT_ESCAPE,
	QUIT_CAPTURE,
	QUIT_TURNOVER,
	QUIT_SAFARIBALL
}
