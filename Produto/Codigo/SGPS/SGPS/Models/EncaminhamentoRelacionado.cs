using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGPS.Models
{
    public class EncaminhamentoRelacionado
    {
        #region Variáveis Locais
        private int idEncaminhamento;
        private int idHospital;
        private int idPaciente;
        private string nomeHospital;
        private string nomePaciente;
        private string motivo;
        private string situacaoAtual;
        private DateTime dataEncaminhamento;
        #endregion

        #region Propriedades

        public int IdEncaminhamento
        {
            get { return idEncaminhamento; }
            set { idEncaminhamento = value; }
        }

        public int IdHospital
        {
            get { return idHospital; }
            set { idHospital = value; }
        }

        public int IdPaciente
        {
            get { return idPaciente; }
            set { idPaciente = value; }
        }

        public string NomeHospital
        {
            get { return nomeHospital; }
            set { nomeHospital = value; }
        }

        public string NomePaciente
        {
            get { return nomePaciente; }
            set { nomePaciente = value; }
        }

        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

        public string SituacaoAtual
        {
            get { return situacaoAtual; }
            set { situacaoAtual = value; }
        }

        public DateTime DataEncaminhamento
        {
            get { return dataEncaminhamento; }
            set { dataEncaminhamento = value; }
        }

        #endregion

        #region Construtor

        public EncaminhamentoRelacionado(int _idEncaminhamento, int _idHospital, 
            int _idPaciente, string _motivo, string _situacao, DateTime _data)
        {
            IdEncaminhamento = _idEncaminhamento;
            IdHospital = _idHospital;
            IdPaciente = _idPaciente;
            Motivo = _motivo;
            SituacaoAtual = _situacao;
            DataEncaminhamento = _data;
        }
        #endregion
    }
}