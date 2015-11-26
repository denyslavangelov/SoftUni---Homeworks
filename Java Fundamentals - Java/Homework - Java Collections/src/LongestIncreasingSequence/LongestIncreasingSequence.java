package LongestIncreasingSequence;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class LongestIncreasingSequence {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        String[] inputLine = Console.nextLine().split(" ");

        int counter = 1;
        int maxCount = 1;
        int positionOfInt = 0;

        System.out.print(inputLine[0] + " ");
        for (int i = 1; i < inputLine.length; i++) {
            if (Integer.parseInt(inputLine[i]) > Integer.parseInt(inputLine[i - 1])) {
                System.out.print(inputLine[i] + " ");
                counter ++;
            } else {
                System.out.print("\n" + inputLine[i] + " ");
                counter = 1;
            }

            if (counter > maxCount) {
                maxCount = counter;
                positionOfInt = i;
            }
        }

        System.out.print("\n" + "Longest : ");
        for (int i = 0; i < maxCount - 1; i++) {
            System.out.print(inputLine[positionOfInt - maxCount + 1 + i] + " ");
        }
        System.out.println(inputLine[positionOfInt]);
    }
}