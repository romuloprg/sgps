using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGPS.Models
{
    public class AtendimentoPaciente
    {
        # region Variáveis Locais

        private int idPaciente;
        private int idAtendimento;
        private string nomePaciente;
        private string motivoAtendimento;
        private string providenciaAtendimento;
        private DateTime dataAtendimento;

        #endregion

        #region Propriedades

        public DateTime DataAtendimento
        {
            get { return dataAtendimento; }
            set { dataAtendimento = value; }
        }

        public int IdAtendimento
        {
            get { return idAtendimento; }
            set { idAtendimento = value; }
        }
        public int IdPaciente
        {
            get { return idPaciente; }
            set { idPaciente = value; }
        }

        public string NomePaciente
        {
            get { return nomePaciente; }
            set { nomePaciente = value; }
        }

        public string MotivoAtendimento
        {
            get { return motivoAtendimento; }
            set { motivoAtendimento = value; }
        }

        public string ProvidenciaAtendimento
        {
            get { return providenciaAtendimento; }
            set { providenciaAtendimento = value; }
        }

        #endregion

        #region Construtor
        public AtendimentoPaciente(int _idAtendimento, int _idPaciente, string _motivo, string _providencia, DateTime _data)
        {
            IdAtendimento = _idAtendimento;
            IdPaciente = _idPaciente;
            MotivoAtendimento = _motivo;
            ProvidenciaAtendimento = _providencia;
            DataAtendimento = _data;
        }
        #endregion
    }
}