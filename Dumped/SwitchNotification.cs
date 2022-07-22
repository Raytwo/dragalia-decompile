using UnityEngine;
using UnityEngine.Switch;

public class SwitchNotification
{
	public delegate void NotificationEvent(int value);

	public static NotificationEvent ExitRequest;

	public static NotificationEvent FocusStateChanged;

	public static NotificationEvent Resume;

	public static NotificationEvent OperationModeChanged;

	public static NotificationEvent PerformanceModeChanged;

	public static NotificationEvent InFocus;

	public static NotificationEvent OutOfFocus;

	public static NotificationEvent Background;

	public static Notification.FocusHandlingMode CurrentFocusHandlingMode;

	public static void SetFocusHandlingModeNotify()
	{
	}

	public static void SetFocusHandlingModeSuspend()
	{
	}

	private static extern void SwitchInvokeNotificationNativeExample();

	private static void NotificationMessageReceived(Notification.Message message)
	{
	}

	[RuntimeInitializeOnLoadMethod]
	private static void OnRuntimeMethodLoad()
	{
	}

	private static void OnMessage_ExitRequest()
	{
	}

	private static void OnMessage_FocusStateChanged()
	{
	}

	private static void OnMessage_Resume()
	{
	}

	private static void OnMessage_OperationModeChanged()
	{
	}

	private static void OnMessage_PerformanceModeChanged()
	{
	}

	private static void OnFocusState_InFocus()
	{
	}

	private static void OnFocusState_OutOfFocus()
	{
	}

	private static void OnFocusState_Background()
	{
	}
}
