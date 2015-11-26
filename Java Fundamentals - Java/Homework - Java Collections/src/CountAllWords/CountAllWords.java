package CountAllWords;


import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class CountAllWords {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);
        String input = getInput.nextLine();

        Pattern pattern = Pattern.compile("\\w");
        Matcher matcher  = pattern.matcher(input);

        int count = 0;

        while (matcher.find()){
            count++;
        }

        System.out.println(count);
    }
}
