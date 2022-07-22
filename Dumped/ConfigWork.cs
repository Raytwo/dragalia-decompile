using DPData;
using UnityEngine.Events;

public static class ConfigWork
{
	public const int MAX_VOLUME = 10;

	public static UnityAction<ConfigID, int> onValueChanged;

	public static void Initialize(ref CONFIG config)
	{
	}

	public static void Reset(ref CONFIG config)
	{
	}

	private static void CheckAndInvokeChangedValues(ref CONFIG config, ref CONFIG prevConfig)
	{
	}

	public static void InvokeChangedValues(ref CONFIG config)
	{
	}
}
