public class Calculadora {
    public static void soma (double num1, double num2) {
        double resultado = num1 + num2;
        System.out.println("A soma de " + num1 + " + " + num2 + " = " + resultado);
    }

    public static void subtracao (double num1, double num2) {
        double resultado = num1 - num2;
        System.out.println("A diferença de " + num1 + " - " + num2 + " = " + resultado);
    }

    public static void multiplicacao (double num1, double num2) {
        double resultado = num1 * num2;
        System.out.println("O produto de " + num1 + " x " + num2 + " = " + resultado);
    }

    public static void divisao (double num1, double num2) {
        double resultado = num1 / num2;
        System.out.println("O quociente de " + num1 + " / " + num2 + " = " + resultado);
    }
}
