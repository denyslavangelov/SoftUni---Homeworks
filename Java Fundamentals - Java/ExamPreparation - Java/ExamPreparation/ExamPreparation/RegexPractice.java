package ExamPreparation;
/**
 * Created by Deny on 05/11/2015.
 */

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import static java.util.regex.Pattern.compile;

public class RegexPractice {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);
        String input = getInput.nextLine();
        List<String> doubles = new ArrayList<>();
        List<String> ints = new ArrayList<>();

        while (!input.equals("//END_OF_CODE")){
            Pattern pattern = compile("(double|int)(\\s[a-z][A-Za-z]*)");
            Matcher matcher = pattern.matcher(input);

            while (matcher.find()){
                String variable = matcher.group(1);
                String name = matcher.group(2);

                if (variable.equals("double")){
                    doubles.add(name);
                } else {
                    ints.add(name);
                }
            }
            input = getInput.nextLine();
        }

        Collections.sort(doubles);
        Collections.sort(ints);

        if (doubles.size() > 0){
            System.out.println("Doubles:" + String.join(",", doubles));
        } else {
            System.out.println("Doubles: None");
        }

        if (ints.size() > 0){
            System.out.println("Ints:" + String.join(",", ints));
        } else {
            System.out.println("Ints: None");
        }


    }
}
