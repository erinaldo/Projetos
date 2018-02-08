﻿using BMSworks.Firebird;
using BMSworks.Model;
using BMSworks.UI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Data;


namespace BMSworks.IMEXAppClass
{
    public partial class PRODUTODATAMODELIMEXAPPProvider
    {
        CONFISISTEMAProvider CONFISISTEMAP = new CONFISISTEMAProvider();
        CONFISISTEMAEntity CONFISISTEMATy = new CONFISISTEMAEntity();

        IList<PRODUTODATAMODELIMEXAPPEntity> PRODUTODATAMODELIMEXAPPColl;

        Utility Util = new Utility();

        public async void Save(PRODUTODATAMODELIMEXAPPEntity Entity)
        {
            try
            {
                //Busca dados da Configuração
                CONFISISTEMATy = CONFISISTEMAP.Read(1);

                string token = CONFISISTEMATy.TOKENIMEXAPP.Trim();
                string URI = BmsSoftware.Modulos.IMEXApp.UrlIMEXApp.Default.PostProdutos;

                Entity.IDPRODUTO = null;
                Entity.IDEMPRESA = Convert.ToInt32(CONFISISTEMATy.IDEMPRESAIMEXAPP);
                Entity.IDASPNETUSERSINCLUSAO =  CONFISISTEMATy.IDASPNETUSERSINCLUSAO.Trim();
                Entity.DTULTIMAALTERACAO = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                Entity.IDREPRESENTADA = Convert.ToInt32(CONFISISTEMATy.IDREPRESIMEXAPP);

                Entity.PICMS = 0;// DECIMAL NUMBER
                Entity.PIPI = 0;//DECIMAL NUMBER
                Entity.PST = 0;//DECIMAL NUMBER
                Entity.POUTRAS = 0; //DECIMAL NUMBER
                Entity.VESTOQUEMAX = 0;//DECIMAL NUMBER
                Entity.VESTOQUEMIN = 0;//DECIMAL NUMBER
                Entity.XFABRICANTE = string.Empty; // STRING
                Entity.PCOMISSAO = 0;// DECIMAL NUMBER
                Entity.STVENDASEMESTOQUE = true;// BOOLEAN
                Entity.XFILEIMAGEPRINCIPAL = string.Empty; // STRING
                Entity.PLUCRO = 0;// DECIMAL NUMBER
                Entity.PIPIVENDA = 0;// DECIMAL NUMBER
                Entity.PSTVENDA = 0; //DECIMAL NUMBER
                Entity.CEAN = string.Empty; //STRING
                Entity.XCODCSTPIS = string.Empty; //STRING
                Entity.XCODCSTCOFINS = string.Empty;//STRING
                Entity.DALIQOPICMSST = 0; //DECIMAL NUMBER
                Entity.XCODCSTIPI = string.Empty;//STRING
                Entity.XCODCSTICMS = string.Empty;//STRING
                Entity.XORIGEM = string.Empty;// STRING
                Entity.XCFOP_INTER = string.Empty; //STRING
                Entity.DPESOLIQ = 0;// DECIMAL NUMBER
                Entity.DPESOBRUTO = 0; //DECIMAL NUMBER
                Entity.CEANEMB = string.Empty; //STRING
                Entity.XNOMEDET = string.Empty; //STRING
                Entity.CORIGEM = string.Empty;// STRING
                Entity.STATUALIZADO = true; // BOOLEAN
                Entity.BEXIBIRANOTACAONOPEDIDO = true; //BOOLEAN
                Entity.IDIMPORTACAO = null; //INTEGER
                Entity.BEXIBIRCATALOGO = true;//BOOLEAN
                Entity.BDESTAQUECATALOGO = true;// BOOLEAN
                Entity.XDETALHESCATALOGO = string.Empty;//STRING
                Entity.XTAMANHOSCATALOGO = string.Empty;//STRING
                Entity.XINFTECNICASCATALOGO = string.Empty; //STRING
                Entity.DTATIVACAOCATALOGO = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")); //DATE

                using (var client = new System.Net.Http.HttpClient())
                {
                    var serializedObjeto = JsonConvert.SerializeObject(Entity);

                    string RegistroStr = "\"Registro\"";
                    string xToken = "\"xToken\"";
                    token = "\"" + token + "\"";
                    serializedObjeto = "{ " + RegistroStr + ": " + serializedObjeto + ", " + xToken + ": " + token + " }";
                    var content = new StringContent(serializedObjeto, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(URI, content);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Técnico: " + ex.Message);
            }
        } 

        public async void Delete(int CodRegistro)
        {
            try
            {
                //Busca dados da Configuração
                CONFISISTEMATy = CONFISISTEMAP.Read(1);
                string token = CONFISISTEMATy.TOKENIMEXAPP.Trim();
                string URI = BmsSoftware.Modulos.IMEXApp.UrlIMEXApp.Default.DeleteRegistrosProdutos + token + "/";

                //exclui o registro
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(URI);
                    HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", URI, CodRegistro));

                    if (!responseMessage.IsSuccessStatusCode)
                        MessageBox.Show("Falha ao Exxcluir Registro: " + responseMessage.StatusCode);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Técnico: " + ex.Message);
            }
        }

        public int GetID(int CodRegistro)
        {
            int Result = -1;
            try
            {
                //Busca dados da Configuração
                CONFISISTEMATy = CONFISISTEMAP.Read(1);
                string token = CONFISISTEMATy.TOKENIMEXAPP.Trim();
                string URI = BmsSoftware.Modulos.IMEXApp.UrlIMEXApp.Default.GetRegistrosProdutos;
                URI = URI + token + "/" + "2016-06-19T00:00:00";

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(URI);
                    MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                    client.DefaultRequestHeaders.Accept.Add(contentType);
                    HttpResponseMessage response = client.GetAsync(URI).Result;
                    var stringData = response.Content.ReadAsStringAsync().Result;

                    int tamanhostring = stringData.Length;
                    int posinicio = stringData.IndexOf("[");
                    string ProdutoJsonString2 = stringData.ToString().Substring(posinicio, tamanhostring - posinicio);
                    int posifim = ProdutoJsonString2.IndexOf("Message");
                    ProdutoJsonString2 = ProdutoJsonString2.ToString().Substring(0, posifim - 2);
                    string jsonString = ProdutoJsonString2;

                    PRODUTODATAMODELIMEXAPPColl = DeserializeToList<PRODUTODATAMODELIMEXAPPEntity>(jsonString);
                }

                //Localiza o ID
                Result = BuscaID(CodRegistro);
                return Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Técnico: " + ex.Message);
                return Result;
            }
        }


        public int BuscaID(int IDRegistro)
        {
            int result = -1;

            try
            {
                foreach (var item in PRODUTODATAMODELIMEXAPPColl)
                {
                    if (item.XMEUID == IDRegistro.ToString())
                    {
                        result = Convert.ToInt32(item.IDPRODUTO);
                        break;
                    }
                }
                
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Técnico: " + ex.Message);
                return result;
            }
        }


        public static List<string> InvalidJsonElements;
        public static IList<T> DeserializeToList<T>(string jsonString)
        {
            InvalidJsonElements = null;
            var array = JArray.Parse(jsonString);
            IList<T> objectsList = new List<T>();

            foreach (var item in array)
            {
                try
                {
                    // CorrectElements
                    objectsList.Add(item.ToObject<T>());
                }
                catch (Exception ex)
                {
                    InvalidJsonElements = InvalidJsonElements ?? new List<string>();
                    InvalidJsonElements.Add(item.ToString());
                    MessageBox.Show("Erro Técnico: " + ex.Message);
                }
            }

            return objectsList;
        }


    }
}