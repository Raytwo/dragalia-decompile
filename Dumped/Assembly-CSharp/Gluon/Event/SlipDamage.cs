﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class SlipDamage : EventBase<SlipDamage>
	{
		// Fields
		[Key]
		[Required]
		public CharacterId target;
		[Key]
		public short type;
		[Key]
		public int damage;
		[Key]
		public CharacterId attacker;
		[Key]
		public bool isFollower;
	
		// Constructors
		public SlipDamage();
	}
}
