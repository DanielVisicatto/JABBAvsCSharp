public class Emprestimo {
    public static int getDuasparcelas() {
        return 2;
    }

    public static int getTresParcelas() {
        return 3;
    }

    public static double getTaxaDuasparcelas() {
        return .3;
    }

    public static double getTaxaTresParcelas() {
        return .45;
    }

    public static void calcular(double valor, int parcelas) {
        if(parcelas == 2){
            double valorFinal = valor + (valor * getTaxaDuasparcelas());
            System.out.println("Valor Final do empréstimo para 2 parcelas: R$" + valorFinal);
        } else if (parcelas == 3) {
            double valorFinal = valor + (valor * getTaxaTresParcelas());
            System.out.println("Valor Final do empréstimo para 3 parcelas: R$" + valorFinal);
        }else{
            System.out.println("Quantidade de parcelas não aceitas!");
        }
    }
}