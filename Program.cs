//Salario hora: SH
//Horas totais: HT
//Horas extras: HE

double Salario(double SH, double HT, double HE)
{
    return (SH * (HT - HE)) + (SH * HE * 1.4);
}

Console.WriteLine("+------------------------------- Horas Extras --------------------------------+");
Console.WriteLine($"|salario-hora {14:C}, {300} horas, sendo {0,2} horas-extra, salário = {Salario(12, 300, 0):C}|");
Console.WriteLine($"|salario-hora {14:C}, {300} horas, sendo {20} horas-extra, salário = {Salario(12, 300, 20):C}|");
Console.WriteLine("+-----------------------------------------------------------------------------+");
Console.WriteLine($"|salario-hora {31:C}, {300} horas, sendo {0,2} horas-extra, salário = {Salario(24, 300, 0):C}|");
Console.WriteLine($"|salario-hora {31:C}, {300} horas, sendo {20} horas-extra, salário = {Salario(24, 300, 20):C}|");
Console.WriteLine("+-----------------------------------------------------------------------------+");