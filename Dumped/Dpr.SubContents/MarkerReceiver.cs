using System;
using UnityEngine;
using UnityEngine.Playables;

namespace Dpr.SubContents;

public class MarkerReceiver : MonoBehaviour, INotificationReceiver
{
	public Action<int, float> OnCheckEnd;

	public Action<int> OnTextUpdate;

	public Action<int> OnToBattleScale;

	public Action<int> OnToMenuScale;

	public void OnNotify(Playable origin, INotification notification, object context)
	{
	}

	private void OnDestroy()
	{
	}
}
