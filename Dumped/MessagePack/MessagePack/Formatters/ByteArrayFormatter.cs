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

namespace MessagePack.Formatters
{
	public sealed class ByteArrayFormatter : IMessagePackFormatter<byte[]>
	{
		// Fields
		public static readonly ByteArrayFormatter Instance;
	
		// Constructors
		private ByteArrayFormatter();
		static ByteArrayFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, byte[] value, IFormatterResolver formatterResolver);
		public byte[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
