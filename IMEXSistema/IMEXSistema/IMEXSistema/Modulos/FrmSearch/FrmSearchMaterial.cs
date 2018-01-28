﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BMSworks.UI;
using BmsSoftware;
using BMSworks.Firebird;
using BMSworks.Model;
using BmsSoftware.Modulos.Cadastros;

namespace BmsSoftware.Modulos.FrmSearch
{
    public partial class FrmSearchMaterial : Form
    {
        Utility Util = new Utility();

        LIS_MATERIALCollection LIS_MATERIALColl = new LIS_MATERIALCollection();

        public FrmSearchMaterial()
        {
            InitializeComponent();
            RegisterFocusEvents(this.Controls);
          }

        public int Result { get; set; }

        private void RegisterFocusEvents(Control.ControlCollection controls)
        {

            foreach (Control control in controls)
            {
                if ((control is TextBox) ||
                  (control is RichTextBox) ||
                  (control is ComboBox) ||
                  (control is MaskedTextBox))
                {
                    control.Enter += new EventHandler(controlFocus_Enter);
                    control.Leave += new EventHandler(controlFocus_Leave);
                }

                RegisterFocusEvents(control.Controls);
            }
        }

        void controlFocus_Leave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = ConfigSistema1.Default.ColorExitTxtBox;
        }

        void controlFocus_Enter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = ConfigSistema1.Default.ColorEnterTxtBox;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            CreaterCursor Cr = new CreaterCursor();
            this.Cursor = Cr.CreateCursor(Cr.btmap, 0, 0);
            PesquisaMaterial();
            this.Cursor = Cursors.Default;
        }

        private void FrmSearchFornecedor_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false; this.FormBorderStyle = FormBorderStyle.FixedDialog;
            btnCadProduto.Image = Util.GetAddressImage(6);
            txtNomePesquisa.Focus();
        }

        private void txtNomePesquisa_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.Enter)
            {
                PesquisaMaterial();
            }           
           else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
           {
               DataGriewSearch.Focus();
           }
        }

        private void PesquisaMaterial()
        {
            try
            {
                LIS_MATERIALProvider LIS_MATERIALP = new LIS_MATERIALProvider();

                RowsFiltroCollection RowRelatorio = new RowsFiltroCollection();
                RowRelatorio.Add(new RowsFiltro("NOMEMATERIAL", "System.String", "like", txtNomePesquisa.Text));

                LIS_MATERIALColl = LIS_MATERIALP.ReadCollectionByParameter(RowRelatorio, "NOMEMATERIAL");
                DataGriewSearch.AutoGenerateColumns = false;
                DataGriewSearch.DataSource = LIS_MATERIALColl;
                txtNomePesquisa.Focus();
            }
            catch (Exception)
            {
                
                MessageBox.Show(ConfigMessage.Default.searchFieldType,
                               ConfigSistema1.Default.NomeEmpresa,
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error,
                               MessageBoxDefaultButton.Button1);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSearchFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }            

            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void DataGriewSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (LIS_MATERIALColl.Count > 0)
            {
                int rowindex = e.RowIndex;
                if (rowindex != -1)
                {
                    Result = Convert.ToInt32(LIS_MATERIALColl[rowindex].IDMATERIAL);
                    this.Close();

                }
            }
        }

        private void DataGriewSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
           {
               if (LIS_MATERIALColl.Count > 0)
               {
                   //Obter a linha da célula selecionada
                   DataGridViewRow linhaAtual = DataGriewSearch.CurrentRow;

                   //Exibir o índice da linha atual
                   int indice = linhaAtual.Index;
                   Result = Convert.ToInt32(LIS_MATERIALColl[indice].IDMATERIAL);
                   this.Close();
               }
           }
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            using (FrmMaterial frm = new FrmMaterial())
            {
                frm.ShowDialog();
            }
        }

       

       
    }
}