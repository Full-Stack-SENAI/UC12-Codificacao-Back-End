using System;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Coleta de dados básicos
            Console.WriteLine("Informe o Nome: ");
            string var_nome = Console.ReadLine() ?? ""; // ?? "" evita erro de valor nulo
            
            Console.WriteLine("Informe o Endereço:");
            string var_endereco = Console.ReadLine() ?? "";
            
            Console.WriteLine("Pessoa Física (f) ou Jurídica (j)?");
            string var_tipo = Console.ReadLine()?.ToLower() ?? ""; // ToLower facilita a digitação

            if (var_tipo == "f")
            {
                // Instanciação da Pessoa Física
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                
                Console.WriteLine("Informe o CPF:");
                pf.cpf = Console.ReadLine() ?? "";
                
                Console.WriteLine("Informe o RG:");
                pf.rg = Console.ReadLine() ?? "";
                
                Console.WriteLine("Informe o valor de compra: ");
                // O '!' garante ao C# que o valor não é nulo
                float val_pag = float.Parse(Console.ReadLine()!);
                
                pf.Pagar_Imposto(val_pag);
                
                Console.WriteLine("-------- Pessoa Física --------");
                Console.WriteLine($"Nome ..........: {pf.nome}");
                Console.WriteLine($"Endereço ......: {pf.endereco}");
                Console.WriteLine($"CPF ...........: {pf.cpf}");
                Console.WriteLine($"RG ............: {pf.rg}");
                Console.WriteLine($"Valor de Compra: {pf.valor:C}");
                Console.WriteLine($"Imposto .......: {pf.valor_imposto:C}");
                Console.WriteLine($"Total a Pagar .: {pf.total:C}");

            }
            else if (var_tipo == "j")
            {
                // Instanciação da Pessoa Jurídica
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                
                Console.WriteLine("Informe o CNPJ:");
                pj.cnpj = Console.ReadLine() ?? "";
                
                Console.WriteLine("Informe a IE:");
                pj.ie = Console.ReadLine() ?? "";
                
                Console.WriteLine("Informar Valor de Compra:");
                float val_pag = float.Parse(Console.ReadLine()!);
                
                pj.Pagar_Imposto(val_pag);
                
                Console.WriteLine("-------- Pessoa Jurídica --------");
                Console.WriteLine($"Nome ..........: {pj.nome}");
                Console.WriteLine($"Endereço ......: {pj.endereco}");
                Console.WriteLine($"CNPJ ..........: {pj.cnpj}");
                Console.WriteLine($"IE ............: {pj.ie}");
                Console.WriteLine($"Valor de Compra: {pj.valor:C}");
                Console.WriteLine($"Imposto .......: {pj.valor_imposto:C}");
                Console.WriteLine($"Total a Pagar .: {pj.total:C}");
            }
            else
            {
                Console.WriteLine("Tipo inválido selecionado.");
            }
        }
    }
}