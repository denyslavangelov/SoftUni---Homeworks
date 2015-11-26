package SortArrayOfNumbers;

import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;

public class SortArrayOfNumbers {

    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);
        int numbers = getInput.nextInt();
        int[] arrayOfNumbers = new int[numbers];

        for (int i = 0; i < numbers; i++) {
            arrayOfNumbers[i] = getInput.nextInt();
        }

        Arrays.sort(arrayOfNumbers);
        System.out.println(Arrays.toString(arrayOfNumbers));
    }
}
