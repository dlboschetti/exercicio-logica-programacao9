using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_logica_programacao9
{
    public class Eleicao
    {
        public int totalEleitores = 100000;

        public int votosValidos = 80000;

        public int votosBrancos = 15000;

        public int votosNulos = 5000;

        public double PercVotosValidos()
        {
            double percVotos  = (double)votosValidos / (double)totalEleitores;
            return percVotos;
        }

        public double PercVotosBrancos()
        {
            double percVotos = (double)votosBrancos / (double)totalEleitores;
            return percVotos;
        }

        public double PercVotosNulos()
        {
            double percVotos = (double)votosNulos / (double)totalEleitores;
            return percVotos;
        }
    }
}
