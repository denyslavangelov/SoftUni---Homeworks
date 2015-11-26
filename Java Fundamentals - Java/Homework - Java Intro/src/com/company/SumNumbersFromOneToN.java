package com.company;

import java.util.Scanner;

/**
 * Created by Deny on 12/10/2015.
 */
public class SumNumbersFromOneToN {
    public static void main(String[] args) {

        Scanner getInput = new Scanner(System.in);
        int number = Integer.parseInt(getInput.nextLine());
        int sum = 0;

        for (int i = 0; i <= number; i++) {
            sum += i;
        }

        System.out.print(sum);


    }
}
