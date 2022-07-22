using UnityEngine;
using UnityEngine.Events;

namespace Effect;

public class ParticleSystemController : MonoBehaviour
{
	public enum StopStateBits
	{
		None = 0,
		Stopping = 1,
		Stopped = 2,
		Manual = 4
	}

	private UnityAction<object> _onFinished;

	private object _reference;

	private ParticleSystem _particleSystem;

	private ParticleSystem[] _particleSystems;

	private MaterialController[] _materialControllers;

	private StopStateBits _stopStateBits;

	public StopStateBits stopStateBits => default(StopStateBits);

	public void Setup(ParticleSystem particleSystem, UnityAction<object> onFinished, object reference)
	{
	}

	public void Stop(bool isForce)
	{
	}

	public void OnParticleSystemStopped()
	{
	}

	public bool OnUpdate(float deltaTime)
	{
		return default(bool);
	}

	private void Finish()
	{
	}

	public void SetMultiplyColor(Color color)
	{
	}
}
