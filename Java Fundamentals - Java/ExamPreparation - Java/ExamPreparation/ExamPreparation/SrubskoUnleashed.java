package ExamPreparation;

import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Deny on 04/11/2015.
 */
public class SrubskoUnleashed {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);
        String line = getInput.nextLine();

        LinkedHashMap<String, HashMap<String, Integer>> map = new LinkedHashMap<>();

        while (!line.equals("End")){
            Pattern pattern = Pattern.compile("([\\D]+)\\s@([\\D]+)\\s([\\d]+)\\s([\\d]+)");
            Matcher matcher = pattern.matcher(line);

            if (matcher.find()){
                String singer = matcher.group(1);
                String place = matcher.group(2);
                int ticketPrice = Integer.parseInt(matcher.group(3));
                int ticketCount = Integer.parseInt(matcher.group(4));
                int money = ticketPrice * ticketCount;

                if (!map.containsKey(place)){
                    map.put(place, new Hash());
                }

                if (!map.get(place).containsKey(singer)){
                    map.get(place).put(singer, 0);
                }

                int sum = map.get(place).get(singer);
                map.get(place).put(singer, sum + money);

            }


            line = getInput.nextLine();
        }

        for (String s : map.keySet()) {
        }
    }
}
