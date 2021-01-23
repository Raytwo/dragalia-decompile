﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;

// Image 48: MessagePack.dll - Assembly: MessagePack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Decoders
{
	internal sealed class FixExt16Header : IExtHeaderDecoder
	{
		// Fields
		internal static readonly IExtHeaderDecoder Instance;
	
		// Constructors
		private FixExt16Header();
		static FixExt16Header();
	
		// Methods
		public ExtensionHeader Read(byte[] bytes, int offset, out int readSize);
	}
}
