package ExamPreparation;/**
 * Created by Deny on 08/11/2015.
 */

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import static java.util.regex.Pattern.compile;

public class RageQuit {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);
        String input = getInput.nextLine().toUpperCase();

        Pattern pattern = compile("(\\D+)(\\d+)");
        Matcher matcher = pattern.matcher(input);
        HashSet<Character> unique = new HashSet<>();
        StringBuilder sb = new StringBuilder();

        while (matcher.find()) {
            String string = matcher.group(1);
            int repeat = Integer.parseInt(matcher.group(2));
            for (int i = 0; i < repeat; i++) {
                sb.append(string);
            }
        }

        String string = sb.toString();
        for (int i = 0; i <string.length() ; i++) {
            unique.add(string.charAt(i));
        }

        System.out.printf("Unique symbols used: %d\n", unique.size());
        System.out.println(string);

    }
}
