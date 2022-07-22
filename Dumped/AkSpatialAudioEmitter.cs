using System;
using AK.Wwise;
using UnityEngine;

[Obsolete]
public class AkSpatialAudioEmitter : MonoBehaviour
{
	public AuxBus reflectAuxBus;

	public float reflectionMaxPathLength;

	public float reflectionsAuxBusGain;

	public uint reflectionsOrder;

	public float roomReverbAuxBusGain;

	public uint diffractionMaxEdges;

	public uint diffractionMaxPaths;

	public uint diffractionMaxPathLength;
}
