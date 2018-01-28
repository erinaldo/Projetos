using System;

// Classe de Modelo (Objeto de transporte)
namespace BMSworks.Model
{
	[Serializable]
	public partial class SCRIPTVERSAOEntity
	{
		private int _IDSCRIPT;
		private int? _IDVERSAO;
		private string _DESCRICAO;
		private string _FLAGEXECUTADO;

		#region Construtores

		//Construtor default
		public SCRIPTVERSAOEntity() {
			this._IDVERSAO = null;
		}

		public SCRIPTVERSAOEntity(int IDSCRIPT, int? IDVERSAO, string DESCRICAO, string FLAGEXECUTADO) {

			this._IDSCRIPT = IDSCRIPT;
			this._IDVERSAO = IDVERSAO;
			this._DESCRICAO = DESCRICAO;
			this._FLAGEXECUTADO = FLAGEXECUTADO;
		}
		#endregion

		#region Propriedades Get/Set

		public int IDSCRIPT
		{
			get { return _IDSCRIPT; }
			set { _IDSCRIPT = value; }
		}

		public int? IDVERSAO
		{
			get { return _IDVERSAO; }
			set { _IDVERSAO = value; }
		}

		public string DESCRICAO
		{
			get { return _DESCRICAO; }
			set { _DESCRICAO = value; }
		}

		public string FLAGEXECUTADO
		{
			get { return _FLAGEXECUTADO; }
			set { _FLAGEXECUTADO = value; }
		}

		#endregion
	}
}