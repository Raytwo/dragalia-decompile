﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopTreasureTradeTopTableViewCell : TableViewCell<Gluon.ShopTradeModel.TreasureTradeTopData>
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text beginTimeText;
		public UnityEngine.UI.Text endTimeText;
		public UnityEngine.UI.Text beginEndText;
		public Image banner;
		private ShopTreasureTradeShopTopView panel;
		private ShopTradeExchangeTopView exchangePanel;
		private ShopTradeModel.TreasureTradeTopData data;
	
		// Constructors
		public ShopTreasureTradeTopTableViewCell();
	
		// Methods
		private void Start();
		public override void UpdateContent(ShopTradeModel.TreasureTradeTopData data);
		private string CreateBannerSpritePath();
		public void OnBannerPressed();
	}
}
