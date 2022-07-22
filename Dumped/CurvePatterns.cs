using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu]
public class CurvePatterns : ScriptableObject
{
	[SerializeField]
	private AnimationCurve[] curves;

	public float[] times
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int Count => default(int);

	public AnimationCurve this[int index] => null;

	public void OnEnable()
	{
	}
}
