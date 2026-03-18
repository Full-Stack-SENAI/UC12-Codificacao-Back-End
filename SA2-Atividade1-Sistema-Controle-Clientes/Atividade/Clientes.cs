using System;

namespace Atividade
{
    public class Clientes
    {
        // Propriedades básicas (O que todo cliente tem)
        public string nome { get; set; }
        public string endereco { get; set; }
        
        // O 'protected set' permite que apenas esta classe e as filhas alterem o valor
        public float valor { get; protected set; }
        public float valor_imposto { get; protected set; }
        public float total { get; protected set; }

        // O 'virtual' é a chave para a herança funcionar corretamente
        public virtual void Pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 0.1f; // 10% de imposto padrão
            this.total = this.valor + this.valor_imposto;
        }
    }
}