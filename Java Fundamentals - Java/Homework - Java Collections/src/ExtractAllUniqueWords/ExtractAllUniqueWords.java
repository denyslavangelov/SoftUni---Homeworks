package ExtractAllUniqueWords;

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ExtractAllUniqueWords {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);
        String inputLine = getInput.nextLine();

        List<String> list = new ArrayList<>();
        List<String> result = new ArrayList<>();

        Pattern patter = Pattern.compile("(\\w+)");
        Matcher matcher = patter.matcher(inputLine);

        while (matcher.find()){
            list.add(matcher.group().toLowerCase());
        }

        for (int i = 0; i < list.size(); i++) {
            if (!result.contains(list.get(i))){
                result.add(list.get(i));
            }
        }

        Collections.sort(result);

        for (String s : result){
            System.out.print(s + " ");
        }
    }
}
