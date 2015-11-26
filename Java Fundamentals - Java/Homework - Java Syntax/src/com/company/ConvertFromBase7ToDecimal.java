package com.company;
import java.util.Scanner;

/**
 * Created by Deny on 16/10/2015.
 */

public class ConvertFromBase7ToDecimal {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);
        String num = getInput.nextLine();
        int result = 0;


        for (int i = 0; i < num.length(); i++) {
            int curentNum = Character.getNumericValue(num.charAt(i));
            int multiplier = (int) Math.pow(7,(num.length()-1)-i );
            result += curentNum * multiplier;

        }
        System.out.println(result);


    }
}
