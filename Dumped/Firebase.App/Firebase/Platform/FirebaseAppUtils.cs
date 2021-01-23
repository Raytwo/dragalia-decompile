﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 41: Firebase.App.dll - Assembly: Firebase.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase.Platform
{
	internal class FirebaseAppUtils : IFirebaseAppUtils
	{
		// Fields
		private static FirebaseAppUtils instance;
	
		// Properties
		public static FirebaseAppUtils Instance { get; }
	
		// Constructors
		public FirebaseAppUtils();
		static FirebaseAppUtils();
	
		// Methods
		public void TranslateDllNotFoundException(Action action);
		public void PollCallbacks();
		public PlatformLogLevel GetLogLevel();
	}
}
