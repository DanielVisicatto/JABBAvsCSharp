public class Main {
    public static void main(String[] args) {

       //Calculadora
        System.out.println("Calculadora:");
        Calculadora.soma(3,6);
        Calculadora.subtracao(9, 1.8);
        Calculadora.multiplicacao(7,8);
        Calculadora.divisao(5,2.5);

       //Mensagem
        System.out.println("\nMensagem:");
        Mensagem.obterMensagem(9);
        Mensagem.obterMensagem(14);
        Mensagem.obterMensagem(1);

        //Emprestimo
        System.out.println("\nEmprestimo:");
        Emprestimo.calcular(1000, Emprestimo.getDuasparcelas());
        Emprestimo.calcular(1000, Emprestimo.getTresParcelas());
        Emprestimo.calcular(1000, 5);
    }
}