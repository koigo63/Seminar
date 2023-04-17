/**
 * InnerMyFirstApp
 */
public class MyFirstApp {
    public static void main(String[] args) {
        // int[] numbers = new int[5];
        // numbers[0] = 10;
        // String[] strings = new String[3];
        // strings[0] = "привет";
        // strings[1] = "пока";
        // strings[2] = "джава";
        // for (String string : strings) {
        // System.out.println(string);
        // }
        int[][] matrice = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        // System.out.println(matrice[2][2]);
        // String[][] strings = new String[2][3];
        // System.out.println(strings[0][1]);
        for (int i = 0; i < matrice.length; i++) {

            for (int j = 0; j < matrice[i].length; j++) {
                System.out.print(matrice[i][j] + " ");
            }
            System.out.println();
        }
    }

}
