package com.company;

import java.util.ArrayList;
import java.util.Scanner;

/**
 * Created by Deny on 17/10/2015.
 */

public class GetFirstOddOrEven {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);

        String[] inputString = getInput.nextLine().split(" ");
        int[] intArray = new int[inputString.length];
        String command = getInput.nextLine();
        String[] commandsArray = command.split(" ");
        int count = Integer.parseInt(commandsArray[1]);
        ArrayList<Integer> evenList = new ArrayList();
        ArrayList<Integer> oddList = new ArrayList();

        for (int i = 0; i < inputString.length; i++) {
            intArray[i] = Integer.parseInt(inputString[i]);
        }

        for (int i = 0; i < intArray.length; i++) {
            if (intArray[i] % 2 == 0) {
                evenList.add(intArray[i]);
            } else if (intArray[i] % 2 == 1) {
                oddList.add(intArray[i]);
            }
        }

        if (commandsArray[2].equals("odd")) {
            for (int i = 0; i < count; i++) {
                System.out.printf("%d ", oddList.get(i));
            }
        } else if (commandsArray[2].equals("even")) {
            for (int i = 0; i < count; i++) {
                System.out.printf(evenList.get(i) + " ");
            }
        }
    }
}