﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CtrlOverdrive : MonoBehaviour
	{
		// Fields
		private Phase _phase;
		private EnemyCharacter _owner;
		[CompilerGenerated]
		private float _baseOD_k__BackingField;
		[CompilerGenerated]
		private float _baseBreak_k__BackingField;
		[CompilerGenerated]
		private bool _canSetPoint_k__BackingField;
		[SerializeField]
		private float _limit;
		[SerializeField]
		private float _point;
		private float _odSpeed;
		private static CharacterSpecialState _tmpChangeBossState;
		[CompilerGenerated]
		private bool _isOnRageAction_k__BackingField;
		public bool isOverdriveReserved;
		public bool isBreakReserved;
		private const int HIDE_EFF_TRIG = 13;
		[CompilerGenerated]
		private int _playedLoopEffTrg_k__BackingField;
		[CompilerGenerated]
		private bool _isShowingLoopEff_k__BackingField;
	
		// Properties
		public Phase phase { get; private set; }
		public float baseOD { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float baseBreak { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool canSetPoint { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float limit { get; set; }
		public float point { get; set; }
		public float rate { get; }
		public bool isOnRageAction { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int playedLoopEffTrg { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isShowingLoopEff { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum Phase
		{
			Initilize = 0,
			Ordinary = 1,
			Overdrive = 2,
			Break = 3,
			End = 4
		}
	
		// Constructors
		public CtrlOverdrive();
		static CtrlOverdrive();
	
		// Methods
		private void OnRateChanged();
		public void Setup(EnemyCharacter owner, float baseOD_, float baseBreak_);
		public void Reset();
		public void OnUpdate();
		private void UpdateOrdinary();
		private void OnOverdrive();
		private void UpdateOverdrive();
		private void OnBreak(CharacterBase attacker = null);
		private void UpdateBreak();
		private void OnOrdinary();
		public void OnDamaged(float dmg, CharacterBase attacker = null);
		public void OnDamagedRate(float percentage);
		public void OnEnd();
		public bool CheckOverdrive();
		public void CheckBreak(CharacterBase attacker = null);
		public void OnOverdriveReceived();
		public void OnBreakReceived();
		private void SendOverdrive();
		private void SendBreak();
		private bool CanInterrupt();
		public void SetOverdrive(bool canReserve = false);
		public void HideEff();
		public void RestoreEffect();
	}
}
