package LargestSequenceofEqualStrings;

import java.util.Scanner;

public class LargestSequenceofEqualStrings {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        Scanner getInput = new Scanner(System.in);
        String[] inputLine = getInput.nextLine().split(" ");

        int repeat = 1;
        int counter = 1;
        int positionOfWord = 0;

        for (int i = 1; i < inputLine.length; i++) {

            if (inputLine[i].equals(inputLine[i - 1])) {
                counter++;
            } else {
                counter = 1;
            }

            if (counter > repeat) {
                repeat = counter;
                positionOfWord = i;
            }

        }

        for (int i = 0; i < repeat - 1; i++) {
            System.out.print(inputLine[positionOfWord] + " ");
        }
        System.out.println(inputLine[positionOfWord]);
    }
}
