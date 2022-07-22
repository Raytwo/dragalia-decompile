using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu]
public class PokemonWalkingDatas : ScriptableObject
{
	[Serializable]
	public class Preset
	{
		public float scale;

		public float radius;

		public float falloffNear;

		public float falloffFar;

		public float walkSpeed;

		public float runSpeed;

		public float walkThreshold;

		public float runThreshold;

		public float eraseThreshold;
	}

	[Serializable]
	public class Parameters
	{
		public int index;

		public int size;

		public float scale;

		public float radius;

		public float falloffNear;

		public float falloffFar;

		public float walkSpeed;

		public float runSpeed;

		public float walkThreshold;

		public float runThreshold;

		public float eraseThreshold;

		public bool footEffectEnable;
	}

	[SerializeField]
	public Preset presetS;

	[SerializeField]
	public Preset presetM;

	[SerializeField]
	public Preset presetL;

	[SerializeField]
	public Preset presetLL;

	[SerializeField]
	public Parameters[] list;

	[NonSerialized]
	public int currentIndex;

	[NonSerialized]
	public bool debugBoundsEnable;

	public Parameters currentData => null;

	public Preset GetPreset(int size)
	{
		return null;
	}
}
