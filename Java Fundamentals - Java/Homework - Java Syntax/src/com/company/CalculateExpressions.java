package com.company;
import java.util.Scanner;

/**
 * Created by Deny on 15/10/2015.
 */

public class CalculateExpressions {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);
        double a = getInput.nextDouble();
        double b = getInput.nextDouble();
        double c = getInput.nextDouble();

        // First formula.
        double firstFormula = Math.pow(((a * a + b * b) / (a * a - b * b)), (a + b + c) / Math.sqrt(c));
        // Second formula.
        double secondFormula = Math.pow(((a * a + b * b) - c * c * c), (a - b));
        double firstAverage = (a + b + c) / 3;
        double secondAverage = (firstFormula + secondFormula) / 2;
        double difference;

        if (firstAverage > secondAverage){
            difference = firstAverage - secondAverage;
        }
        else {
            difference = secondAverage - firstAverage;
        }

        System.out.printf("F1 result: %.2f; F2 result = %.2f; Diff: %.2f", firstFormula, secondFormula, difference);
    }
}
