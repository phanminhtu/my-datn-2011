﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TFM.Common.Models;
using OperationCtrl.Constant;
using PNRSUtilities;

namespace OperationCtrl
{
    public partial class GetUpdatePriceListCtrl : Form
    {
        #region event
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fareInfo"></param>
        public delegate void UpdatePriceLsit(FareInfo fareInfo);

        /// <summary>
        /// 
        /// </summary>
        public event UpdatePriceLsit UpdateCurrenPriceList;
        #endregion

        #region public member

        

        #endregion

        public void DisplayCurrentPriceList() 
        {
            //label1.Text = currentPriceList.priceList.Price;
            //label2.Text = currentPriceList.priceList.Station.ToString();
           // PNRSData;
        }

        public GetUpdatePriceListCtrl()
        {
            InitializeComponent();

            //currentPriceList = new PriceList();
            //currentPriceList.Inittialize();

            //label1.Text = currentPriceList.priceList.Station.ToString();
            //label2.Text = currentPriceList.priceList.Price;
        }

        private void button1_Click1(object sender, EventArgs e)
        {
            //currentPriceList.GetUpdatePriceList();
            //label1.Text = currentPriceList.priceList.Station.ToString();
            //label2.Text = currentPriceList.priceList.Price;
        }

      
}
}
