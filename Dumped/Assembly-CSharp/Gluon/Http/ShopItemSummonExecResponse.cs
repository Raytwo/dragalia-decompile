﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class ShopItemSummonExecResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public AtgenUserItemSummon user_item_summon;
			public AtgenBuildEventRewardEntityList[] item_summon_reward_list;
			public UpdateDataList update_data_list;
			public EntityResult entity_result;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public ShopItemSummonExecResponse();
	}
}
