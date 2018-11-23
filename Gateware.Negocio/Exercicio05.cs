using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gateware.Negocio
{
    public class Exercicio05
    {
        public static string Executar()
        {
            string STRSQL = @"

select
	ltr.uf,
	col.nome_colaborador,
	sum(valor_pago) as total_salario_recebido
from COLABORADORES col
    join LOCAL_DE_TRABALHO ltr on (ltr.id_colaborador = col.id_colaborador)
    join SALARIOS sal on (sal.id_colaborador=col.id_colaborador)
where 1=1
    and year(data_pagamento)=2014
group by 
	ltr.uf,
	col.nome_colaborador
order by ltr.uf, col.nome_colaborador;
";

            return STRSQL;
        }
    }
}
