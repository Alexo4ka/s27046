// See https://aka.ms/new-console-template for more information
public class MyUtility {
    public static double calculateAverage(int[] arr) {
        double sum = 0;
        for (int i = 0; i < arr.length; i++) {
            sum += arr[i];
        }
        return sum / arr.length;
    }
}