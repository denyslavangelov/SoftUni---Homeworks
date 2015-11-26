package ExamPreparation;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Deny on 29/10/2015.
 */
public class TheNumbers {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);

        String input = getInput.nextLine();
        List<String> list = new ArrayList<>();
        List<String> result = new ArrayList<>();

        Pattern pattern = Pattern.compile("[0-9]+");
        Matcher matcher = pattern.matcher(input);

        while (matcher.find()) {
            list.add(matcher.group());
        }

        for (int i = 0; i < list.size(); i++) {
            int integer = Integer.parseInt(list.get(i));
            String hex = Integer.toHexString(integer).toUpperCase();
            hex = ("0000" + hex).substring(hex.length());

            result.add("0x" + hex);
        }

        String asd = String.join("-", result);

        System.out.println(asd);
    }
}
