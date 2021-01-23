﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncPointerUpTrigger : AsyncTriggerBase, IPointerUpHandler
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onPointerUp;
		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerUps;
	
		// Constructors
		public AsyncPointerUpTrigger();
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises();
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData);
		public UniTask<PointerEventData> OnPointerUpAsync(CancellationToken cancellationToken = default);
	}
}
