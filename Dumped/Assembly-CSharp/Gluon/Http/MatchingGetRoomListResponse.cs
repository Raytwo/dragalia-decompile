﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class MatchingGetRoomListResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public RoomList[] room_list;
			public RoomList[] friend_room_list;
			public RoomList[] event_room_list;
			public RoomList[] event_friend_room_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public MatchingGetRoomListResponse();
	}
}
