namespace Dpr.NetworkUtils;

public enum SessionEventType
{
	None,
	JoinIn_Mine,
	JoinIn_OtherPlayer,
	ChangeHost_Mine,
	ChangeHost_OtherPlayer,
	Leave_Mine,
	Leave_OtherPlayer,
	GamingError,
	Crash,
	ResumeGame
}
