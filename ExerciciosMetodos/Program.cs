using ExerciciosMetodos;

// Calculadora.
Console.WriteLine("Calculadora:");
Calculadora.Soma(3, 6);
Calculadora.Subtracao(9, 1.8);
Calculadora.Multiplicacao(7,8);
Calculadora.Divisao(5, 2.5);

//Mensagem.
Console.WriteLine("\nMensagem:");
Mensagem.ObterMensagem(9);
Mensagem.ObterMensagem(14);
Mensagem.ObterMensagem(1);


//Empréstimo
Console.WriteLine("\nEmpréstimo:");
Emprestimo.Calcular(1000, Emprestimo.GetDuasParcelas());
Emprestimo.Calcular(1000, Emprestimo.GetTresParcelas());
Emprestimo.Calcular(1000, 5);