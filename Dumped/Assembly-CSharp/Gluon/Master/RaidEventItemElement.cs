﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class RaidEventItemElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _RaidEventId;
		[SerializeField]
		private string _Name;
		[SerializeField]
		private string _Detail;
		[SerializeField]
		private RaidEventItemType _RaidEventItemType;
		[SerializeField]
		private DetailLinkType _DetailLinkType;
		[SerializeField]
		private int _MoveQuest1;
		[SerializeField]
		private int _MoveQuest2;
		[SerializeField]
		private int _MoveQuest3;
		[SerializeField]
		private int _MoveQuest4;
		[SerializeField]
		private int _MoveQuest5;
		[SerializeField]
		private string _Description;
		[SerializeField]
		private int _PouchRarity;
	
		// Properties
		public int Id { get; }
		public int RaidEventId { get; }
		public string Name { get; }
		public string Detail { get; }
		public RaidEventItemType RaidEventItemType { get; }
		public DetailLinkType DetailLinkType { get; }
		public int MoveQuest1 { get; }
		public int MoveQuest2 { get; }
		public int MoveQuest3 { get; }
		public int MoveQuest4 { get; }
		public int MoveQuest5 { get; }
		public string Description { get; }
		public int PouchRarity { get; }
	
		// Constructors
		public RaidEventItemElement();
	}
}
