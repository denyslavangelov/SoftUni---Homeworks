package ExamPreparation;/**
 * Created by Deny on 10/11/2015.
 */

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import static java.util.regex.Pattern.compile;

public class LettersChangeNumbers {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);
        String input = getInput.nextLine();
        String[] tokens = input.split("\\s++");
        Pattern pattern = compile("\\d+");
        Matcher matcher = pattern.matcher(input);
        double number = 0d;
        int counter = 0;
        while (matcher.find()) {
            String string = tokens[counter];
            if (Character.isUpperCase(string.charAt(0))) {
                int match = Integer.parseInt(matcher.group(0));
                double firstPosition = CheckPositionUpperCase(tokens[counter].charAt(0));
                number += (double)(match / firstPosition);
            } else {
                int match = Integer.parseInt(matcher.group(0));
                double firstPosition = CheckPositionLowerCase(tokens[counter].charAt(0));
                number +=  (double)(match * firstPosition);
            }
            if (Character.isUpperCase(string.charAt(string.length() - 1))) {
                int match = Integer.parseInt(matcher.group(0));
                double secondPosition = CheckPositionUpperCase(string.charAt(string.length() - 1));
                number =  number - secondPosition;
            } else {
                int match = Integer.parseInt(matcher.group(0));
                double secondPosition = CheckPositionLowerCase(string.charAt(string.length() - 1));
                number =  (double)number + secondPosition;
            }
            counter ++;
            if (counter == tokens.length){
                break;
            }
        }
        System.out.printf("%.2f", number);
    }

    public static int CheckPositionLowerCase(Character s) {
        int asd = 0;
        int temp = (int) s;
        int temp_integer = 96; //for upper case
        if (temp <= 122 & temp >= 97) {
            asd = temp - temp_integer;
        }
        return asd;
    }

    public static int CheckPositionUpperCase(Character s) {
        int asd = 0;
        int temp = (int) s;
        int temp_integer = 64; //for upper case
        if (temp <= 90 & temp >= 65) {
            asd = temp - temp_integer;
        }
        return asd;
    }
}
