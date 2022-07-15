﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrCalculator.Presentation.Screm
{
    public static class Messages
    {
        public const string Header = @"----------Calculadora de IR----------
";
        public const string Invalid = "Entrada inválida, aperte qualquer tecla para tentar novamente";
        public const string NameMessage = "Informe seu nome:";
        public const string TotalValueMessage = "Informe o montante para o calculo de imposto:";
        public const string TaxResult = "A taxa paga de imposto é ";
        public const string AliquotUsed = "A aliquota para sua faixa salarial é ";
        public const string DeductionUsed = "A isenção para sua faixa salarial é ";
        public const string Apresentation = ", esse é o resultado do seu calculo";
        public const string ThanksMessage = "Obrigado por usar nosso serviço";
        public const string MainMenu = @"Qual a opção desejada:
1 - Calcular IR
2 - Ver aliquotas de acordo com a faixa salarial
3 - Sair";
        public const string TableAliqout = " | Aliquota:";
        public const string TableAmount = "| Faixa salarial até ";
        public const string TableAmount_ = "| Faixa salarial acíma de ";
        public const string TableDeduction = " | Dedução de ";
        public const string QuitMessage = "Aperte qualquer tecla para sair";
        public const string ReturnMessage = @"
Aperte qualquer tecla para voltar ao menu";



    }
}
