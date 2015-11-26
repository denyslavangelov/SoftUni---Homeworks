package com.company;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Deny on 17/10/2015.
 */

public class StartsAndEndsWithCapitalLetter {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);
        String inputString = getInput.nextLine();

        Pattern pattern = Pattern.compile("\\b[A-Z][a-z]*[A-Z]\\w*");
        Matcher matches = pattern.matcher(inputString);

        while(matches.find()){
            System.out.print(matches.group() + " ");
        }
    }
}
