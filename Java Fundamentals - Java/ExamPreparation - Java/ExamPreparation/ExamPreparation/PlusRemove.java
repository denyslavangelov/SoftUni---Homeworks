package ExamPreparation;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by Deny on 28/10/2015.
 */
public class PlusRemove {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);
        List<char[]> list = new ArrayList<>();

        String line = getInput.nextLine().toLowerCase();

        while(!line.equals("end")){
            char[] charLine = line.toCharArray();
            list.add(charLine);
            line = getInput.nextLine().toLowerCase();
        }

        for (int row = 1; row < list.size() - 1; row++) {
            for (int col = 1; col < list.get(row).length - 1; col++) {
                if ((list.get(row)[col] == list.get(row - 1)[col]) &&
                        (list.get(row)[col] == list.get(row + 1)[col]) &&
                        (list.get(row)[col] == list.get(row)[col - 1]) &&
                        (list.get(row)[col] == list.get(row)[col + 1])){

                    list.get(row)[col] = '\0';
                    list.get(row + 1)[col] = '\0';
                    list.get(row - 1)[col] = '\0';
                    list.get(row)[col + 1] = '\0';
                    list.get(row)[col - 1] = '\0';
                }

            }
        }

        List<String> result = new ArrayList<>();

        for (int i = 0; i < list.size(); i++) {
            String array = String.copyValueOf(list.get(i));
            String replace = array.replaceAll("\0", "");
            result.add(replace);
        }

        for (String s : result) {
            System.out.println(s);
        }

    }
}
