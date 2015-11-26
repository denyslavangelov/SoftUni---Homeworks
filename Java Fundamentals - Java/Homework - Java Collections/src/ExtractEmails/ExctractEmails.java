package ExtractEmails;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ExctractEmails {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);
        String inputLine = getInput.nextLine();

        Pattern pattern = Pattern.compile("([A-Za-z-_.0-9]+@[a-z-.]+)");
        Matcher matcher = pattern.matcher(inputLine);

        while (matcher.find()){
            System.out.println(matcher.group(0));
        }
    }
}
