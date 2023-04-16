import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        // System.out.println("Hello, World!");
        // int x = 3;
        // String name = "Кинжал";
        // x = x * 17;
        // System.out.println("x равен" + x);
        // double d = Math.random();
        // while (x > 12) {
        // x = x - 1;
        // System.out.println("x равен" + x);
        // }
        // for (int index = 0; index < 10; index++) {
        // System.out.println("x равен" + index);
        // }
        // if (x == 10) {
        // System.out.println("x равен" + x);
        // } else {
        // System.out.println("x не равен 10");
        // }
        // System.out.println(name.equals("Кинжал"));
        // // String s = new String("set");
        Scanner sd = new Scanner(System.in);
        // String string = sd.nextLine(); // int nextInt()
        // // System.out.println(string);
        // int value;
        // do {
        // System.out.println("Введите 5");
        // value = sd.nextInt();
        // } while (value != 5);
        // System.out.println("Введили 5");
        System.out.println("Введите возраст");
        int age = sd.nextInt();
        switch (age) {
            case 0:
                System.out.println("0");
                break;

            default:
                break;
        }

    }
}
