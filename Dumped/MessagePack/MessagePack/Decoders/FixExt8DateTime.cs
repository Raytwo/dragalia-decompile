﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 48: MessagePack.dll - Assembly: MessagePack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Decoders
{
	internal sealed class FixExt8DateTime : IDateTimeDecoder
	{
		// Fields
		internal static readonly IDateTimeDecoder Instance;
	
		// Constructors
		private FixExt8DateTime();
		static FixExt8DateTime();
	
		// Methods
		public DateTime Read(byte[] bytes, int offset, out int readSize);
	}
}
