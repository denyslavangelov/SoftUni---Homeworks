package com.company;
import java.util.*;

public class RandomizeNumbers {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);
        int minimum = getInput.nextInt();
        int maximum = getInput.nextInt();

        if (minimum > maximum){
            minimum = maximum;
        }

        List<Integer> resultList = new ArrayList<>();

        for (int i = minimum; i <= maximum; i++){
            resultList.add(i);
        }

        Collections.shuffle(resultList);

        for (int number : resultList) {
            System.out.print(number + " ");
        }
    }
}
