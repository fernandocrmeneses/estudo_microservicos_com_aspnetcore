using System;
using System.Collections.Generic;
using System.Text;

namespace CmsProject.Templates.Domain
{
    public enum WorkFlowEnum
    {
        PENDENTE,
        APROVADO,
        REPROVADO,
        ANALISANDO,
        ERRO,
        EM_FILA_APROVACAO,
        EM_FILA_PARA_REPROVACAO,
        EM_FILA_PARA_DELETAR,
        NOVO
    }
}
