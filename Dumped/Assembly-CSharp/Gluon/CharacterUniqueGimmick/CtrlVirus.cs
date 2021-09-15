﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Event;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.CharacterUniqueGimmick
{
	public class CtrlVirus : CUGCtrlBase
	{
		// Fields
		private State _state;
		private float _duration;
		private float _timer;
		private float _sqrRange;
		private float _fixedAbnormalResist;
		private int _cutTimerHeal;
		public const string VIRUS_EFFECT_NAME = "EFF_BOS_CHR_STR_0080301_008";
		public const string SE_NAME = "SE_ENE_CHR_STR_0080301_01_0001";
		public const string SE_PANDEMIC_NAME = "SE_ENE_CHR_STR_0080301_01_0002";
		private const int EFF_TRIG_INFECTION_NORMAL = 8;
		private const int EFF_TRIG_INFECTION_BIG = 9;
		private const int EFF_TRIG_PANDEMIC_NORMAL = 10;
		private const int EFF_TRIG_PANDEMIC_BIG = 11;
		private const int EFF_TRIG_HIDDEN = 12;
		private EffectObject _eoVirus;
		private bool _isEffDisplay;
		private bool _isForm2ndOwner;
		private List<CharacterSpecialState> _recvEventList;
		private bool _isWaitingForPandemic;
		private bool _isWaitingForErase;
	
		// Properties
		public State state { get; private set; }
		public override bool active { get; }
		public float fixedAbnormalResist { get; }
	
		// Nested types
		public enum State
		{
			Idle = 0,
			Start = 1,
			Infection = 2,
			Pandemic = 3,
			Erase = 4,
			Abort = 5,
			End = 6
		}
	
		// Constructors
		public CtrlVirus();
	
		// Methods
		public void Setup(CharacterBase owner, float duration, float range, int fixedAbnormalRate, int healValue);
		public void Reset();
		public override void ResetState();
		public void Start();
		public override void Abort();
		public override void Update(CharacterBase src);
		private void Pandemic(bool ignoreInfluence = false);
		public override void OnDead();
		public override void OnShapeShift();
		public override void OnAreaChange();
		public void OnHeal(int healVal);
		private void OnPandemic();
		private void FixedAbnormalResist();
		public override void PlayEffect();
		public override void StopEffect();
		public void DeleteEffect();
		private void CheckEffectDisplay();
		public static void CreateVirusUI();
		private void ShowVirusUI();
		private void HideVirusUI();
		private void SetVirusUIGaugeTimer();
		private void SendVirusEvent();
		public void OnReceiveVirusEvent(CharacterSpecialState recvData);
		public void OnReceiveRequestInfection(CharacterSpecialState recvData);
		private void ProcessReceivedEvent();
	}
}
