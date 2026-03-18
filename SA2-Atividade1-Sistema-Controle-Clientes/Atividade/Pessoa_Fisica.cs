using System;

namespace Atividade
{
    // O ':' indica que Pessoa_Fisica herda as características de Clientes
    public class Pessoa_Fisica : Clientes
    {
        public string cpf { get; set; }
        public string rg { get; set; }

        // Sobrescrevemos o método Pagar_Imposto para Pessoa Física
        public override void Pagar_Imposto(float v)
        {
            this.valor = v;
            // No SENAI, costumamos usar 10% para Física e 20% para Jurídica (ou conforme o exercício)
            this.valor_imposto = this.valor * 0.1f; 
            this.total = this.valor + this.valor_imposto;
        }
    }
}