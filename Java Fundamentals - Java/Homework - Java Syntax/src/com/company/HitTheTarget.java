package com.company;
import java.util.Scanner;

public class HitTheTarget {
    public static void main(String[] args) {
        Scanner Console=new Scanner(System.in);
        int inputNumber = Integer.parseInt(Console.nextLine());

        for (int firstNumber = 1; firstNumber <= 20 ; firstNumber++) {
            for (int secondNumber = 1; secondNumber <= 20 ; secondNumber++) {

                if (firstNumber + secondNumber == inputNumber){
                    System.out.printf("%1$d + %2$d = %3$d \n",firstNumber, secondNumber,inputNumber);
                }

                else if (firstNumber - secondNumber == inputNumber) {
                    System.out.printf("%1$d - %2$d = %3$d \n",firstNumber, secondNumber,inputNumber);
                }
            }
        }
    }
}