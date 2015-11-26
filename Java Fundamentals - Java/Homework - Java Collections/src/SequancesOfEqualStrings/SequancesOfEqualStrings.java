package SequancesOfEqualStrings;

import java.util.Scanner;

public class SequancesOfEqualStrings {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);
        String[] inputLine = getInput.nextLine().split(" ");


        System.out.print(inputLine[0] + " ");
        for (int i = 1; i < inputLine.length; i++) {
            if (inputLine[i].equals(inputLine[i - 1])){
                System.out.print(inputLine[i] + " ");
            } else {
                System.out.print("\n" + inputLine[i] + " ");
            }
        }
        System.out.println();
    }
}
