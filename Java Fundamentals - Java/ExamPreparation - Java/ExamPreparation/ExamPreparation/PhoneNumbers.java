package ExamPreparation;/**
 * Created by Deny on 11/11/2015.
 */

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import static java.util.regex.Pattern.compile;

public class PhoneNumbers {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);
        String input = getInput.nextLine();
        StringBuilder sb = new StringBuilder();

        while (!input.equals("END")) {
            sb.append(input);
            input = getInput.nextLine();
        }
        String inputStr = sb.toString();
        String removeSpace = inputStr.replace(" ", "");
        String nonTrash = removeSpace.replaceAll("[^0-9a-zA-Z+\\s]+", "");

        Pattern pattern = compile("([A-Z][a-z]*)([+\\d]{2,}[^+])");
        Matcher matcher = pattern.matcher(nonTrash);
        List<String> names = new ArrayList<>();
        List<String> numbers = new ArrayList<>();
        while (matcher.find()){
            names.add(matcher.group(1));
            numbers.add(matcher.group(2));
        }
        if (names.isEmpty()){
            System.out.println("<p>No matches!</p>");
        } else {
            System.out.print("<ol>");
            for (int i = 0; i < names.size(); i++) {
                if (i < names.size() - 1) {
                    System.out.printf("<li><b>%s:</b> %s</li>", names.get(i), numbers.get(i));
                } else {
                    System.out.printf("<li><b>%s:</b> %s</li></ol>", names.get(i), numbers.get(i));
                }
            }
        }
    }
}
