﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using SPFX;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class FieldScreenEffectTrigger : FieldTriggerBase
	{
		// Fields
		[SerializeField]
		private FadeKind fadeKind;
		[SerializeField]
		private string effectName;
		[SerializeField]
		private bool setBillboardFlag;
		[SerializeField]
		private Color effectColor;
		[SerializeField]
		private int kickTrigger;
		[SerializeField]
		private float fadeInTime;
		[Range]
		[SerializeField]
		private float fadeInValue;
		[SerializeField]
		private float fadeOutTime;
		[Range]
		[SerializeField]
		private float fadeOutValue;
		private float _effectAlpha;
		private EffectObject _effectObject;
		private SPFXInstance effectInstance;
		private BoxCollider hitCollider;
		private Coroutine _progressCoroutine;
		protected FieldScreenEffectTrigger _lastCoroutineStarter;
		private PlayerCtrl prevPlayerCtrl;
	
		// Properties
		protected virtual float effectAlpha { get; set; }
		protected virtual EffectObject effectObject { get; set; }
		protected virtual Coroutine progressCoroutine { get; set; }
		protected virtual FieldScreenEffectTrigger lastCoroutineStarter { get; set; }
	
		// Nested types
		public enum FadeKind
		{
			InAndOut = 0,
			InOnly = 1
		}
	
		[CompilerGenerated]
		private sealed class _StartEffectCoroutine_d__30 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FieldScreenEffectTrigger __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartEffectCoroutine_d__30(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _TransitionAlpha_d__37 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float time;
			public FieldScreenEffectTrigger __4__this;
			public float toValue;
			private float _startAlpha_5__2;
			private float _diffAlpha_5__3;
			private float _timeProgress_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _TransitionAlpha_d__37(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public FieldScreenEffectTrigger();
	
		// Methods
		protected override void Awake();
		[IteratorStateMachine]
		protected virtual IEnumerator StartEffectCoroutine();
		public override void FastUpdate();
		private void OnTriggerEnter(Collider other);
		private void OnTriggerExit(Collider other);
		protected virtual void StartFadeIn();
		protected virtual void StartFadeOut();
		protected void StartFadeCoroutine(float fadeValue, float fadeTime);
		[IteratorStateMachine]
		private IEnumerator TransitionAlpha(float toValue, float time);
		private void ChangeEffectAlpha(float alpha);
	}
}
