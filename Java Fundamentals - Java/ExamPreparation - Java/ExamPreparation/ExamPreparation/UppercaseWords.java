package ExamPreparation;/**
 * Created by Deny on 11/11/2015.
 */

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import static java.util.regex.Pattern.compile;
import static java.util.regex.Pattern.matches;

public class UppercaseWords {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);
        String input = getInput.nextLine();
        String asd = "";

        while (!input.equals("END")) {
            Pattern pattern = compile("\\b([A-Z]+)\\b");
            Matcher matcher = pattern.matcher(input);

            while (matcher.find()){
                String word = matcher.group(1);
                String reversed = Reverse(word);
                
                if (reversed.equals(word)){
                    reversed = DoubleEachLetter(reversed);
                }

               input = input.replaceAll(word, reversed);
            }
            System.out.println(input);
            input = getInput.nextLine();
        }
    }
    private static String DoubleEachLetter(String reversed)
    {
        StringBuilder doubled = new StringBuilder();
        for (int i = 0; i < reversed.length(); i++) {
            doubled.append(reversed.charAt(i));
            doubled.append(reversed.charAt(i));
        }
        return doubled.toString();
    }

    private static String Reverse(String value)
    {
        StringBuilder reversed = new StringBuilder();
        for (int i = value.length()- 1; i >= 0; i--)
        {
            reversed.append(value.charAt(i));
        }

        return reversed.toString();
    }
}
