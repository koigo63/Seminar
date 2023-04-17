public class Converter {
    public static void main(String[] args) {
        System.out.println(mpgToKPM(1));
    }

    public static float mpgToKPM(final float mpg) {
        float kpl = (float) Math.round(mpg * 1.609344 * 100 / 4.54609188) / 100;
        System.out.println(kpl);
        return kpl;
    }
}
