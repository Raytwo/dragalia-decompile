using System;
using System.Collections.Generic;
using SmartPoint.Components;
using UnityEngine;

public class EncEffectSequenceData : ScriptableObject
{
	public enum eSpecialType
	{
		Normal,
		Gym,
		Tower,
		League,
		AfterImage
	}

	public enum Command
	{
		PlayEffect,
		SetColor,
		FadeOut,
		FadeIn,
		MoveObject,
		End,
		SetFadeColor,
		ChangeEffectLoop,
		PlayGym,
		PlaySE,
		CameraPosition,
		CameraRotation,
		SetAfterImage
	}

	public enum DrawType
	{
		World,
		UI
	}

	public enum State
	{
		Wait,
		Run,
		Finish
	}

	[Serializable]
	public class KeyData
	{
		public Command command;

		public float startTime;

		public float endTime;

		public string path;

		public Color minColor;

		public Color maxColor;

		public float duration;

		public Fader.FadeMode fademode;

		public bool useSystemColor;

		public int fadeTexIndex;

		public string seEventName;

		public Vector3 cameraOffset;

		public bool saveCameraOffset;

		public float AfterImageAngle;

		public float AfterImageScale;

		[HideInInspector]
		public State state;
	}

	public EncEffectSeqDataTable table;

	public EffectFieldID EffectFieldID;

	public eSpecialType SpecialType;

	public List<KeyData> keyData;
}
