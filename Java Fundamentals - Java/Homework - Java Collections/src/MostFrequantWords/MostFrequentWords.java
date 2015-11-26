package MostFrequantWords;

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class MostFrequentWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] text = scanner.nextLine().toLowerCase()
                .split(" ");
        Map<String, Integer> wordsCount = new TreeMap<String, Integer>();

        int maxCount = 0;
        for (String word : text) {
            Integer count = wordsCount.get(word);
            if (count == null) {
                count = 0;
            }
            if (count + 1 > maxCount) {
                maxCount = count + 1;
            }
            wordsCount.put(word, count + 1);
        }

        for (Map.Entry<String, Integer> max : wordsCount.entrySet()) {
            if (max.getValue() == maxCount) {
                System.out.printf("%s -> %d times\n", max.getKey(),
                        max.getValue());
            }
        }


    }
}
