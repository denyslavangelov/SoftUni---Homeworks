package ExamPreparation;/**
 * Created by Deny on 10/11/2015.
 */

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import static java.util.regex.Pattern.compile;

public class GandalfStash {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);
        int mood = Integer.parseInt(getInput.nextLine());
        String input = getInput.nextLine().toLowerCase();

        Pattern pattern = compile("[A-Za-z]+");
        Matcher matcher = pattern.matcher(input);

        while (matcher.find()) {
            switch (matcher.group(0)) {
                case "cram":
                    mood += 2;
                    break;
                case "honeycake":
                    mood += 5;
                    break;
                case "melon":
                    mood += 1;
                    break;
                case "apple":
                    mood += 1;
                    break;
                case "mushrooms":
                    mood -= 10;
                    break;
                case "lembas":
                    mood += 3;
                    break;
                default:
                    mood -= 1;
                    break;
            }
        }

        System.out.println(mood);

        if (mood < -5) {
            System.out.println("Angry");
        } else if (mood >= -5 && mood <= 0) {
            System.out.println("Sad");
        } else if (mood >= 0 && mood <= 15) {
            System.out.println("Happy");
        } else if (mood >= 15) {
            System.out.println("Special JavaScript mood");
        }


    }
}
