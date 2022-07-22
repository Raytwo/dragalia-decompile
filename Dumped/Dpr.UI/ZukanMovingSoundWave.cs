using System.Collections.Generic;
using Audio;
using UnityEngine;

namespace Dpr.UI;

public class ZukanMovingSoundWave : MonoBehaviour
{
	private class Point
	{
		public Vector2 pos;
	}

	[SerializeField]
	private float _speed;

	[SerializeField]
	private float _lineWidth;

	[SerializeField]
	private Material _material;

	[SerializeField]
	private Color _color;

	private Mesh _mesh;

	private const float _minDecibel = -48f;

	private const float _maxDecibel = 0f;

	private Queue<Point> _pointQueue;

	private const float _maxHeight = 100f;

	private List<Vector2> _points;

	private VoiceRTPC.VoiceRTPCDataList _voiceRtpcData;

	private CanvasRenderer _canvasRenderer;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void Setup(VoiceRTPC.VoiceRTPCDataList voiceRtpcData)
	{
	}

	private void CreateMesh()
	{
	}

	private float GetRTPCValue(AudioInstance audioInstance, uint paramId)
	{
		return default(float);
	}

	public void OnUpdate(float deltaTime, AudioInstance audioInstance)
	{
	}

	private void UpdateMesh()
	{
	}

	private float ToLevelValue(float value, float min = -48f, float max = 0f)
	{
		return default(float);
	}

	private void OnWillRenderCanvases()
	{
	}
}
