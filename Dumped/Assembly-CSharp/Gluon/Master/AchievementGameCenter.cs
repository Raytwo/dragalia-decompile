﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using SerializableCollections;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	public class AchievementGameCenter : IMaster<Gluon.Master.AchievementGameCenter>
	{
		// Fields
		[SerializeField]
		private AchievementGameCenterDictionary dict;
	
		// Properties
		public AchievementGameCenterDictionary Dict { get; }
		public SerializableDictionary<int, AchievementGameCenterElement> List { get; }
	
		// Constructors
		public AchievementGameCenter();
	}
}
