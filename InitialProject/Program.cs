// See https://aka.ms/new-console-template for more information
public class MyUtility {
    public static double calculateAverage(int[] arr) {
        double total = 0; // Changed variable name here
        for (int i = 0; i < arr.length; i++) {
            total += arr[i];
        }
        return total / arr.length;
    }
}