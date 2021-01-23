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
	public interface SimpleCharacterFacialControlInterface
	{
		// Methods
		void Setup(Material material);
		void SetEnable(bool f);
		bool GetEnable();
		void LateUpdate();
		void SetTrigger(string triggerName);
		void SetFaceEye(CharaFaceEye faceEye);
		void SetFaceMouth(CharaFaceMouth faceMouth);
	}
}
