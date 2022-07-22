using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

namespace Effect;

public class EffectInstance : IObjectPoolInstance
{
	private EffectData _effectData;

	private ParticleSystem _particleSystem;

	private ParticleSystemController _particleSystemController;

	private UnityAction<object> _onFinished;

	private UnityAction<EffectInstance> _onPlayFinished;

	private Transform _attachedTransform;

	private Vector3 _localPosition;

	private Quaternion _localRotation;

	private Color _mulColor;

	private float _stopFadeLifeTime;

	private float _stopFadeTime;

	public EffectData effectData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ParticleSystem particleSystem
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GameObject gameObject => null;

	public string name => null;

	public Transform attachedTransform => null;

	public Vector3 localPosition => default(Vector3);

	public Quaternion localRotation => default(Quaternion);

	void IObjectPoolInstance.SetGameObject(GameObject obj)
	{
	}

	GameObject IObjectPoolInstance.GetGameObject()
	{
		return null;
	}

	void IObjectPoolInstance.OnCreate()
	{
	}

	void IObjectPoolInstance.OnRelease()
	{
	}

	internal void _Setup(EffectData effectData, Vector3 position, Quaternion rotation, Transform attachedTransform, UnityAction<object> onFinished)
	{
	}

	private void SetupParticleSystemController(UnityAction<object> onFinished)
	{
	}

	private void OnFinished(object reference)
	{
	}

	public EffectInstance Play([Optional] UnityAction<EffectInstance> onFinished)
	{
		return null;
	}

	public void Stop(float fadeTime = 0f, bool isForce = false)
	{
	}

	private void StopInternal(bool isForce)
	{
	}

	internal bool _Update(float deltaTime)
	{
		return default(bool);
	}

	private void UpdateFader(float deltaTime)
	{
	}

	internal void _UpdateTransform()
	{
	}

	public static void MatrixMultiply4x3(out Matrix4x4 mT, ref Matrix4x4 lhs, ref Matrix4x4 rhs)
	{
	}

	public void SetMultiplyColor(Color mulColor)
	{
	}

	public Color GetMulColor()
	{
		return default(Color);
	}

	public void SetTransformParent(Transform parent, bool worldPositionStays)
	{
	}

	public void RestoreTransformParent()
	{
	}
}
