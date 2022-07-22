using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EventCameraData : ScriptableObject
{
	public enum EventType
	{
		Path,
		Fade,
		EventEnd,
		StopEnd,
		DofLength,
		NewPath,
		Rotation,
		ReturnDefaultCamera,
		ReturnDefaultRotate,
		FieldOfView
	}

	public enum FadeType
	{
		In,
		Out
	}

	public enum VectorType
	{
		Local,
		World,
		Default,
		Before
	}

	public enum DofValType
	{
		Input,
		Defaul,
		Work
	}

	[Serializable]
	public class ReturnDefault
	{
		public int curveIndex;

		public float workTime;

		public float workTimeScale;
	}

	[Serializable]
	public class RotationData
	{
		public int curveIndex;

		public float workTime;

		public float workTimeScale;

		public bool isDefaultRotate;

		public Vector3 Angle1;

		public Vector3 Angle2;
	}

	[Serializable]
	public class PathData2
	{
		public int curveIndex;

		public float workTime;

		public float workTimeScale;

		public VectorType vTypeStart;

		public VectorType vTypeEnd;

		public Vector3 Pos1;

		public Vector3 Pos2;

		public Vector3 Pos3;
	}

	[Serializable]
	public class PathData
	{
		public float workTime;

		public float workTimeScale;

		public VectorType vTypeStart;

		public VectorType vTypeEnd;

		public Vector3 startPosition;

		public Vector3 Vectol;

		public Vector3 endPosition;

		public bool isDefaultRotate;

		public Vector3 startRotation;

		public Vector3 endRotation;
	}

	[Serializable]
	public class FadeData
	{
		public FadeType type;

		public Color color;

		public float duration;
	}

	[Serializable]
	public class DofData
	{
		public float workTime;

		public float workTimeScale;

		public bool[] use;

		public DofValType[] typeStart;

		public DofValType[] typeEnd;

		public float[] valStart;

		public float[] valEnd;

		public Vector3 targetOffset;
	}

	[Serializable]
	public class FovData
	{
		public int curveIndex;

		public float workTime;

		public float workTimeScale;

		public float field_of_view_start;

		public float field_of_view;

		public bool is_default_start;

		public bool is_default_end;
	}

	public float baseTime;

	public float timeScale;

	public int length;

	public List<EventType> type;

	public List<bool> isEnd;

	public List<float> startTime;

	public List<FadeData> fadeData;

	public List<PathData> pathData;

	public List<DofData> dofData;

	public List<PathData2> pathData2;

	public List<RotationData> rotationData;

	public List<ReturnDefault> returnDefault;

	public List<ReturnDefault> returnDefaultRotate;

	public List<FovData> fovData;
}
