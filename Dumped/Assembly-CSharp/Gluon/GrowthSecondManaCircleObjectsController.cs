﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthSecondManaCircleObjectsController : GrowthManaCircleObjectsController
	{
		// Fields
		public GameObject[] SprialEffectObjBase;
		public Vector3[] pointNodesPos;
		public GameObject godRayObjBase;
		public GrowthSecondManaCircleManaPieceObject[] points;
		public float totalCircleRotation;
		public Vector3[] piecePos;
		protected GrowthSecondManaCircleModel secondModel;
		protected GrowthSecondManaCircleScene secondScene;
		private GameObject[] pointNodes;
		private GameObject[] pointObjects;
		private const int roundPieceCount = 10;
		private const float baseMoveupRate = 2.5f;
		private List<int> billboardPieceIds;
		private GrowthManaCircleEffectSettings efs;
		private bool isEndPieceCameraAngle;
		private bool isPlayEndPieceCameraMove;
		public const int numOfPoints = 20;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__18_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _LoadMotifEffect_b__18_0();
		}
	
		[CompilerGenerated]
		private sealed class _LoadMotifEffect_d__18 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthSecondManaCircleObjectsController __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadMotifEffect_d__18(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private struct _AddBoxColliderToPieceObject_d__21 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthSecondManaCircleObjectsController __4__this;
			public int index;
			private UniTask<int> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class _ChangeReleasePointCoroutine_d__37 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthSecondManaCircleObjectsController __4__this;
			public bool isLastPiece;
			public EffectObject effectObject;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ChangeReleasePointCoroutine_d__37(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private struct _PlayFirstEnterSprialEffectAsync_d__38 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthSecondManaCircleObjectsController __4__this;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _PlaySymbolEffectAsync_d__39 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthSecondManaCircleObjectsController __4__this;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0
		{
			// Fields
			public GrowthSecondManaCircleScene secondScene;
			public GrowthSecondManaCircleObjectsController __4__this;
	
			// Constructors
			public __c__DisplayClass41_0();
	
			// Methods
			internal void _PlayFirstEnterEffectAsync_b__0(float value);
		}
	
		[CompilerGenerated]
		private struct _PlayFirstEnterEffectAsync_d__41 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthSecondManaCircleObjectsController __4__this;
			private __c__DisplayClass41_0 __8__1;
			private UniTask.Awaiter __u__1;
			private TweenExtensions.TweenAwaiter __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public GrowthSecondManaCircleObjectsController();
	
		// Methods
		public override void Init();
		[IteratorStateMachine]
		protected override IEnumerator LoadMotifEffect();
		public EffectObject CreateFirstSymbolObject();
		public void CreateCircleObject();
		private async void AddBoxColliderToPieceObject(int index);
		private void SetupPiecePointNodes(int setupCount);
		public override void RotateCircle(float value);
		public override int GetCenterTouchPointIndex();
		public override void LateUpdateCircle();
		public void SetTouchablePoints(int centerIndex);
		public void UpdetePieceAngle();
		public override void UpdateCircleRotation();
		private void StartAdjustAnimation();
		private void PlaySprialAnimating(float rotate);
		public void SetSprialRotation(float rotate);
		private void AdjustAnimationComplete();
		public override bool ShouldPointDescDraw();
		public bool IsReleasePiece(int pieceIndex);
		public override void MovePointToFront(int index);
		public void PlayReleasePointEffect(GrowthSecondManaCircleManaPieceObject touchPoint);
		[IteratorStateMachine]
		private IEnumerator ChangeReleasePointCoroutine(EffectObject effectObject, bool isLastPiece);
		public async void PlayFirstEnterSprialEffectAsync();
		public async void PlaySymbolEffectAsync();
		public void ResetSprialEffect();
		public async void PlayFirstEnterEffectAsync();
		private void DoFirstEnterEffectCameraRotate();
		private Vector3 GetBezierCurvePos(float t);
		private void SetEndPieceCameraAngle();
		public override void Reset();
		[CompilerGenerated]
		private void _StartAdjustAnimation_b__29_0(float value);
		[CompilerGenerated]
		private void _StartAdjustAnimation_b__29_1();
		[CompilerGenerated]
		private void _MovePointToFront_b__35_0(float value);
		[CompilerGenerated]
		private void _MovePointToFront_b__35_1();
		[CompilerGenerated]
		private void _SetEndPieceCameraAngle_b__44_0();
	}
}
