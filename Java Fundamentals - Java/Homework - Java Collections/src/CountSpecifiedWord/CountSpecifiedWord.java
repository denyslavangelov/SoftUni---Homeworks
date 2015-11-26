package CountSpecifiedWord;

import java.util.Scanner;

public class CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);
        String[] inputLine = getInput.nextLine().toLowerCase().split("\\W+");
        String word = getInput.nextLine().toLowerCase();

        int counter = 0;

        for (int i = 0; i < inputLine.length; i++) {
            if (inputLine[i].equals(word)){
                counter++;
            }
        }

        System.out.println(counter);
    }
}
