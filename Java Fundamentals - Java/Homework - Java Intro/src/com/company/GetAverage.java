package com.company;

import java.util.Scanner;

/**
 * Created by Deny on 13/10/2015.
 */
public class GetAverage {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        double value1 = scanner.nextDouble();
        double value2 = scanner.nextDouble();
        double value3 = scanner.nextDouble();

        double sum = value1 + value2 + value3;

        double average = sum / 3;

        System.out.printf("%.2f", average);
    }
}
