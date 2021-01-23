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
	public class WeaponPassiveAbility : IMaster<Gluon.Master.WeaponPassiveAbility>
	{
		// Fields
		[SerializeField]
		private WeaponPassiveAbilityDictionary dict;
	
		// Properties
		public WeaponPassiveAbilityDictionary Dict { get; }
		public SerializableDictionary<int, WeaponPassiveAbilityElement> List { get; }
	
		// Constructors
		public WeaponPassiveAbility();
	}
}
