// See https://aka.ms/new-console-template for more information
public class MyUtility {
    public static int findMax(int[] arr) {
        if (arr.length == 0) {
            throw new IllegalArgumentException("Array must not be empty");
        }
        int max = arr[0];
        for (int i = 1; i < arr.length; i++) {
            if (arr[i] > max) {
                max = arr[i];
            }
        }
        return max;
    }
}