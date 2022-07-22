using UnityEngine;

[CreateAssetMenu]
public class EventCameraTable : ScriptableObject
{
	public EventCameraCurveTable curve;

	public EventCameraData[] table;

	public EventCameraData this[int index] => null;
}
