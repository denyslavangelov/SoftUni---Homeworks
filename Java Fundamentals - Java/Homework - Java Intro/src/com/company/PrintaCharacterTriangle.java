package com.company;

import java.util.Scanner;

/**
 * Created by Deny on 12/10/2015.
 */
public class PrintaCharacterTriangle {
    public static void main(String[] args) {

        Scanner numbers = new Scanner(System.in);
        int number = Integer.parseInt(numbers.nextLine());

        for (int i = 0; i <= number * 2 - 1; i++) {
            for (char j = 0; j < i ; j++) {
                System.out.println((char) (j + 97) + " ");
            }
        }
        System.out.println();
    }
}
