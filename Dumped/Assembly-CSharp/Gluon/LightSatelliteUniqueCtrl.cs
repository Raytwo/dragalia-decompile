﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class LightSatelliteUniqueCtrl : EnemyUniqueCtrl
	{
		// Fields
		private Vector3 _position;
		[CompilerGenerated]
		private float _angularSpeed_k__BackingField;
	
		// Properties
		public float angularSpeed { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public LightSatelliteUniqueCtrl();
	
		// Methods
		public override void Initialize();
		public override void FastUpdate();
		private void OnInitState();
	}
}
