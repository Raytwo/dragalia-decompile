using System.Collections;
using System.Collections.Generic;
using SmartPoint.AssetAssistant;
using UnityEngine;

public class TheaterTrackPlayer : SingletonMonoBehaviour<TheaterTrackPlayer>
{
	private class SaveGameObject
	{
		public Behaviour behaviour;

		public Transform target;

		public Transform parent;

		public Vector3 position;

		public Vector3 angles;

		public Vector3 scale;

		public SaveGameObject(Transform target, Transform parent)
		{
		}

		public SaveGameObject(Behaviour behaviour, Transform parent)
		{
		}

		public void Resume()
		{
		}
	}

	public delegate void OnStartPlaying();

	public AnimationPlayer animationPlayer;

	public string trackName;

	public bool takeover;

	public int colorIndex;

	public bool shadowDistanceAdjust;

	public GameObject bgInstance;

	public float sensorScale;

	private Camera mainCamera;

	private string cameraName;

	private Transform cameraParent;

	private float fieldOfView;

	private Vector3 cameraPosition;

	private Vector3 cameraAngles;

	private int siblingIndex;

	private Transform aimTarget;

	private bool usePhysicalProperties;

	private bool isPlay;

	private bool isLoading;

	private float shadowNearPlaneOffset;

	private float shadowDistance;

	private Transform dofTarget;

	private Camera dofCamera;

	private float dofSensorScale;

	private Dictionary<string, FieldEventEntity> eventEntityMap;

	public OnStartPlaying onStart;

	private List<Transform> actors;

	private Dictionary<string, GameObject> objectTable;

	private List<Renderer> shadowRenderers;

	private List<SaveGameObject> saveGameObjects;

	public new static TheaterTrackPlayer Instance => null;

	public void Load(TheaterTrack track)
	{
	}

	private void PlayEffect(string key)
	{
	}

	private void PlayAnimation(string key)
	{
	}

	public void OnDestroy()
	{
	}

	private IEnumerator OnLoad(TheaterTrack track)
	{
		return null;
	}

	private void Update()
	{
	}
}
