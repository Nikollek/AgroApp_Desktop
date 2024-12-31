using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroApp_Desktop
{
    internal class Relatorio
    {
        public string total_ingressos;
        public string total_venda_alimentos;
        public string ganho_total;
        public Dictionary<string, double> map_top_cinco_alimentos_fornecidos;
        public Dictionary<string, double> map_top_cinco_alimentos_ingresso;

    }
}
