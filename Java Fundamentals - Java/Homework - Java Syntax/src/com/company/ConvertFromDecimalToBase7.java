package com.company;
import java.util.Scanner;

/**
 * Created by Deny on 16/10/2015.
 */

public class ConvertFromDecimalToBase7 {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);
        int number = getInput.nextInt();
        StringBuilder sb = new StringBuilder();

        while (number > 0) {
            int remainder = number % 7;
            sb.insert(0,remainder);
            number = number / 7;
        }

        System.out.println(sb);
    }
}