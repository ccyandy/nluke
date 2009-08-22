﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NLuke.Forms;
using NLuke.Helpers;
using NLuke.IndexWapper;

namespace NLuke
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DoOpen() {
            OpenerForm open = new OpenerForm();
            DialogResult result = open.ShowDialog(this);
            if (result == DialogResult.OK) {
                UpdatePanelUI();
            }
        }

        private void UpdatePanelUI() {

        }

        private void 关于NLukeToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutBox about = new AboutBox();
            about.ShowDialog(this);
        }

        private void 获取源码ToolStripMenuItem_Click(object sender, EventArgs e) {
            ProcessHelper.StartDefaultExplorer("http://code.google.com/p/nluke/");
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e) {
            DoOpen();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            
        }

        private void MainForm_Shown(object sender, EventArgs e) {
            if (!CurrentIndex.IsIndexBeOpend()) {
                DoOpen();
            }
        }

        private void 重新打开ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!CurrentIndex.IsIndexBeOpend()) {
                IndexOpen open = CurrentIndex.GetCurrentOpendIndex();
                open.ReOpen();

                UpdatePanelUI();
            }
        }
    }
}