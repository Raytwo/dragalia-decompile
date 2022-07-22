using UnityEngine;

namespace Dpr.SequenceEditor;

[CreateAssetMenu]
public class CustomEasingPresets : ScriptableObject
{
	[SerializeField]
	private AnimationCurve[] _presets;

	public bool TryGetValue(int index, float ft, out float value)
	{
		return default(bool);
	}
}
