package com.company;
import java.util.Scanner;

/**
 * Created by Deny on 15/10/2015.
 */

public class OddAndEvenPairs {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);

        String[] arr = getInput.nextLine().split(" ");
        int[] array = new int[arr.length];

        for (int i = 0; i < arr.length; i++) {
            array[i] = Integer.parseInt(arr[i]);
        }


        for (int i = 0; i < array.length; i+=2)
        {
            if (array.length % 2 == 1){
                System.out.println("Invalid length.");
                break;
            }

            if (array[i] % 2 == 0 & array[i + 1] % 2 == 1 || array[i] % 2 == 1 & array[i + 1] % 2 == 0){
                System.out.println(array[i] + ", " + array[i + 1] + "-> different");
            }

            else if (array[i] % 2 == 0 & array[i + 1] % 2 == 0){
                System.out.println(array[i] + ", " + array[i + 1] + "-> both are even");
            }

            else if (array[i] % 2 == 1 & array[i + 1] % 2 == 1){
                System.out.println(array[i] + ", " + array[i + 1] + "-> both are odd");
            }


        }
    }
}
