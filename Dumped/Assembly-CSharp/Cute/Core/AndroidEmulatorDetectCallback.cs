﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Core
{
	public class AndroidEmulatorDetectCallback : AndroidJavaProxy
	{
		// Fields
		private Action<bool> finishCallback;
	
		// Constructors
		public AndroidEmulatorDetectCallback(Action<bool> finishCallback);
	
		// Methods
		private void onReceiveResult(bool isEmulator);
	}
}
