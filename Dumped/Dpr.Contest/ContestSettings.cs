using UnityEngine;

namespace Dpr.Contest;

[CreateAssetMenu]
public class ContestSettings : ScriptableObject
{
	public ModelPosition[] modelPosArray;

	public LightSetting[] stageLightParam;

	public VisualHeartParam visualHeartParam;

	public HeartBeziePath[] heartBezierPath;

	public NPCHeartParam npcHeartParam;

	public Vector3 resultLightOffsetPos;

	public Vector3 confettiOffsetPos;
}
