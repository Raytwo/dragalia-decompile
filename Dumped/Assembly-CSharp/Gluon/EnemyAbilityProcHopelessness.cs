﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyAbilityProcHopelessness : EnemyAbilityProcBase
	{
		// Fields
		private CharacterBase _linked;
		private List<CharacterBase> _listReceiver;
	
		// Constructors
		public EnemyAbilityProcHopelessness(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void Play();
		public override void Stop();
		public override void OnUpdate();
		public override void OnAttack(CharacterBase receiver, CollisionHitAttribute hitAttr);
	}
}
