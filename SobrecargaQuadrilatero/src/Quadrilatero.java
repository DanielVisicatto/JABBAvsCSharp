public class Quadrilatero {
    public static void area(double lado){
        System.out.println("Area do quadrado: " + Math.pow(lado, 2));
    }

    public static void area(double lado1, double lado2){
        System.out.println("Area do quadrado: " + (lado1 + lado2));
    }

    public static void area(double baseMaior, double baseMenor, double altura){
        System.out.println("Area do trapézio: " +(((baseMaior + baseMenor)*altura) / 2));
    }

}
