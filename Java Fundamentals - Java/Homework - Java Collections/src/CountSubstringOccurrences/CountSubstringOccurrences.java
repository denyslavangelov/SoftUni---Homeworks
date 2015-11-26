package CountSubstringOccurrences;

import java.util.Scanner;
public class CountSubstringOccurrences {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);
        String inputLine = getInput.nextLine().toLowerCase();
        String word = getInput.nextLine().toLowerCase();

        int counter = 0;

        for (int i = 0; i <= inputLine.length() - word.length(); i++) {

            if (inputLine.substring(i, word.length() + i).contains(word)) {
                counter++;
            }
        }

        System.out.println(counter);

    }
}
