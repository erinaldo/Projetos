﻿namespace BmsSoftware.Modulos.Cadastros
{
    partial class FrmWebService
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWebService));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblObsField = new System.Windows.Forms.Label();
            this.tabControlLocalCobranca = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbUF2 = new System.Windows.Forms.ComboBox();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblTotalPesquisa = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.DataGriewDados = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBGrava = new System.Windows.Forms.ToolStripButton();
            this.TSBNovo = new System.Windows.Forms.ToolStripButton();
            this.TSBDelete = new System.Windows.Forms.ToolStripButton();
            this.TSBFiltro = new System.Windows.Forms.ToolStripButton();
            this.TSBPrint = new System.Windows.Forms.ToolStripButton();
            this.TSBVolta = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gravaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.CAMINHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tabControlLocalCobranca.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriewDados)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblObsField);
            this.panel1.Controls.Add(this.tabControlLocalCobranca);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 341);
            this.panel1.TabIndex = 0;
            // 
            // lblObsField
            // 
            this.lblObsField.AutoSize = true;
            this.lblObsField.ForeColor = System.Drawing.Color.Blue;
            this.lblObsField.Location = new System.Drawing.Point(13, 319);
            this.lblObsField.Name = "lblObsField";
            this.lblObsField.Size = new System.Drawing.Size(32, 13);
            this.lblObsField.TabIndex = 82;
            this.lblObsField.Text = "Obs.:";
            // 
            // tabControlLocalCobranca
            // 
            this.tabControlLocalCobranca.Controls.Add(this.tabPage1);
            this.tabControlLocalCobranca.Controls.Add(this.tabPage3);
            this.tabControlLocalCobranca.Location = new System.Drawing.Point(12, 90);
            this.tabControlLocalCobranca.Name = "tabControlLocalCobranca";
            this.tabControlLocalCobranca.SelectedIndex = 0;
            this.tabControlLocalCobranca.Size = new System.Drawing.Size(634, 226);
            this.tabControlLocalCobranca.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.cbUF2);
            this.tabPage1.Controls.Add(this.txtCaminho);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtObservacao);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 200);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Cadastrais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbUF2
            // 
            this.cbUF2.FormattingEnabled = true;
            this.cbUF2.Location = new System.Drawing.Point(563, 25);
            this.cbUF2.MaxLength = 2;
            this.cbUF2.Name = "cbUF2";
            this.cbUF2.Size = new System.Drawing.Size(49, 21);
            this.cbUF2.TabIndex = 46;
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(11, 26);
            this.txtCaminho.MaxLength = 100;
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(540, 20);
            this.txtCaminho.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Web Service:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(11, 65);
            this.txtObservacao.MaxLength = 500;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(601, 118);
            this.txtObservacao.TabIndex = 2;
            this.txtObservacao.Tag = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Observação:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblTotalPesquisa);
            this.tabPage3.Controls.Add(this.label33);
            this.tabPage3.Controls.Add(this.DataGriewDados);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(626, 200);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pesquisa";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblTotalPesquisa
            // 
            this.lblTotalPesquisa.AutoSize = true;
            this.lblTotalPesquisa.Location = new System.Drawing.Point(100, 176);
            this.lblTotalPesquisa.Name = "lblTotalPesquisa";
            this.lblTotalPesquisa.Size = new System.Drawing.Size(13, 13);
            this.lblTotalPesquisa.TabIndex = 2;
            this.lblTotalPesquisa.Text = "0";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 176);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(94, 13);
            this.label33.TabIndex = 1;
            this.label33.Text = "Total da pesquisa:";
            // 
            // DataGriewDados
            // 
            this.DataGriewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGriewDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CAMINHO});
            this.DataGriewDados.Location = new System.Drawing.Point(6, 17);
            this.DataGriewDados.Name = "DataGriewDados";
            this.DataGriewDados.ReadOnly = true;
            this.DataGriewDados.Size = new System.Drawing.Size(594, 156);
            this.DataGriewDados.TabIndex = 0;
            this.DataGriewDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGriewDados_CellDoubleClick);
            this.DataGriewDados.Enter += new System.EventHandler(this.DataGriewDados_Enter);
            this.DataGriewDados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGriewDados_KeyDown);
            this.DataGriewDados.Leave += new System.EventHandler(this.DataGriewDados_Leave);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(44, 44);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBGrava,
            this.TSBNovo,
            this.TSBDelete,
            this.TSBFiltro,
            this.TSBPrint,
            this.TSBVolta});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(673, 51);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStripCadatro";
            // 
            // TSBGrava
            // 
            this.TSBGrava.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBGrava.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBGrava.Name = "TSBGrava";
            this.TSBGrava.Size = new System.Drawing.Size(23, 48);
            this.TSBGrava.Text = "toolStripButton1";
            this.TSBGrava.ToolTipText = "Grava";
            this.TSBGrava.Click += new System.EventHandler(this.TSBGrava_Click);
            // 
            // TSBNovo
            // 
            this.TSBNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBNovo.Image = ((System.Drawing.Image)(resources.GetObject("TSBNovo.Image")));
            this.TSBNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBNovo.Name = "TSBNovo";
            this.TSBNovo.Size = new System.Drawing.Size(48, 48);
            this.TSBNovo.Text = "toolStripButton2";
            this.TSBNovo.Click += new System.EventHandler(this.TSBNovo_Click);
            // 
            // TSBDelete
            // 
            this.TSBDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBDelete.Image = ((System.Drawing.Image)(resources.GetObject("TSBDelete.Image")));
            this.TSBDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBDelete.Name = "TSBDelete";
            this.TSBDelete.Size = new System.Drawing.Size(48, 48);
            this.TSBDelete.Text = "toolStripButton1";
            this.TSBDelete.Click += new System.EventHandler(this.TSBDelete_Click);
            // 
            // TSBFiltro
            // 
            this.TSBFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBFiltro.Image = ((System.Drawing.Image)(resources.GetObject("TSBFiltro.Image")));
            this.TSBFiltro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBFiltro.Name = "TSBFiltro";
            this.TSBFiltro.Size = new System.Drawing.Size(48, 48);
            this.TSBFiltro.Text = "toolStripButton3";
            this.TSBFiltro.Click += new System.EventHandler(this.TSBFiltro_Click);
            // 
            // TSBPrint
            // 
            this.TSBPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBPrint.Image = ((System.Drawing.Image)(resources.GetObject("TSBPrint.Image")));
            this.TSBPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBPrint.Name = "TSBPrint";
            this.TSBPrint.Size = new System.Drawing.Size(48, 48);
            this.TSBPrint.Text = "toolStripButton4";
            this.TSBPrint.Click += new System.EventHandler(this.TSBPrint_Click);
            // 
            // TSBVolta
            // 
            this.TSBVolta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBVolta.Image = ((System.Drawing.Image)(resources.GetObject("TSBVolta.Image")));
            this.TSBVolta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBVolta.Name = "TSBVolta";
            this.TSBVolta.Size = new System.Drawing.Size(48, 48);
            this.TSBVolta.Text = "toolStripButton1";
            this.TSBVolta.Click += new System.EventHandler(this.TSBVolta_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gravaToolStripMenuItem,
            this.novoToolStripMenuItem,
            this.apagaToolStripMenuItem,
            this.pesquisaToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.voltaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gravaToolStripMenuItem
            // 
            this.gravaToolStripMenuItem.Name = "gravaToolStripMenuItem";
            this.gravaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.gravaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.gravaToolStripMenuItem.Text = "&Grava";
            this.gravaToolStripMenuItem.Click += new System.EventHandler(this.gravaToolStripMenuItem_Click);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.novoToolStripMenuItem.Text = "&Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // apagaToolStripMenuItem
            // 
            this.apagaToolStripMenuItem.Name = "apagaToolStripMenuItem";
            this.apagaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.apagaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.apagaToolStripMenuItem.Text = "&Apaga";
            this.apagaToolStripMenuItem.Click += new System.EventHandler(this.apagaToolStripMenuItem_Click);
            // 
            // pesquisaToolStripMenuItem
            // 
            this.pesquisaToolStripMenuItem.Name = "pesquisaToolStripMenuItem";
            this.pesquisaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.pesquisaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pesquisaToolStripMenuItem.Text = "&Pesquisar";
            this.pesquisaToolStripMenuItem.Click += new System.EventHandler(this.pesquisaToolStripMenuItem_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            this.relatórioToolStripMenuItem.Click += new System.EventHandler(this.relatórioToolStripMenuItem_Click);
            // 
            // voltaToolStripMenuItem
            // 
            this.voltaToolStripMenuItem.Name = "voltaToolStripMenuItem";
            this.voltaToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.voltaToolStripMenuItem.Text = "&Volta";
            this.voltaToolStripMenuItem.Click += new System.EventHandler(this.voltaToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // CAMINHO
            // 
            this.CAMINHO.DataPropertyName = "CAMINHO";
            this.CAMINHO.HeaderText = "Caminho";
            this.CAMINHO.Name = "CAMINHO";
            this.CAMINHO.ReadOnly = true;
            this.CAMINHO.Width = 500;
            // 
            // FrmWebService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 341);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "FrmWebService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Service";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMarca_FormClosing);
            this.Load += new System.EventHandler(this.FrmTipoRegiao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMarca_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlLocalCobranca.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriewDados)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gravaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSBGrava;
        private System.Windows.Forms.ToolStripButton TSBNovo;
        private System.Windows.Forms.ToolStripButton TSBDelete;
        private System.Windows.Forms.ToolStripButton TSBFiltro;
        private System.Windows.Forms.ToolStripButton TSBPrint;
        private System.Windows.Forms.ToolStripButton TSBVolta;
        private System.Windows.Forms.TabControl tabControlLocalCobranca;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblTotalPesquisa;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridView DataGriewDados;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblObsField;
        private System.Windows.Forms.ComboBox cbUF2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAMINHO;
    }
}