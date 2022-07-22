using System;
using UnityEngine;

namespace Dpr.Battle.View.Playables;

[Serializable]
public struct CameraData
{
	public string name;

	public ControlType type;

	public float nearLength;

	public float farLength;

	public float fovy;

	public Vector3 rotation;

	public Vector3 translate;

	public Vector3 upVector;

	public Vector3 aimPos;

	public DofParam dofParam;

	public float twist;

	public static CameraData Factory()
	{
		return default(CameraData);
	}
}
