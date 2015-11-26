package com.company;
import java.util.Scanner;

/**
 * Created by Deny on 15/10/2015.
 */

public class FormattingNumbers {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);

        int firstNumber = getInput.nextInt();
        double secondNumber = getInput.nextDouble();
        double thirdNumber = getInput.nextDouble();

        String toHex = Integer.toHexString(firstNumber).toUpperCase();
        String toBinary = Integer.toBinaryString(firstNumber);

        System.out.printf("|%-10s|00%s|%10.2f|%-10.3f|", toHex, toBinary, secondNumber, thirdNumber);
    }
}
