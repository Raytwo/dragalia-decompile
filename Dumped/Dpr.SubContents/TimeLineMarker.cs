using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Dpr.SubContents;

public class TimeLineMarker : Marker, INotification
{
	public enum Mode
	{
		CheckEnd,
		UpdateText,
		ToBattleScale,
		ToMenuScale
	}

	public Mode mode;

	public int value;

	public float frame;

	public PropertyName id => default(PropertyName);
}
