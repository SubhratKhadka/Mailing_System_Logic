﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Dispatcher.Navs.SubNavs
{
    public partial class ViewGroupMembers : Form
    {
        public ViewGroupMembers(int id)
        {
            InitializeComponent();

            // db to view group members
            Console.WriteLine(id);
        }
    }
}