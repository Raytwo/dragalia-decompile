using DG.Tweening;
using UnityEngine;

namespace Dpr.GMS;

[CreateAssetMenu]
public class GMSCameraConfig : ScriptableObject
{
	public int initDistLevel;

	public float distanceTweenDuration;

	public Ease distTweenEaseType;

	public float snapTweenDuration;

	public Ease snapTweenEaseType;

	public float[] distanceArray;

	public Vector2 moveSpeedDemicalOnDist;

	public float snapThreshold;

	public float addAngleSec;

	public float decAngleSec;

	public float maxAngle;

	public float addAroundAngle;

	public float[] fixedCameraDotRange;

	public Vector2 rotTweenDurationRange;
}
