package ExamPreparation;

import java.util.Scanner;

/**
 * Created by Deny on 30/10/2015.
 */
public class TinySporebat {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);

        String line = getInput.nextLine();
        int healthPoints = 5800;
        int glowcaps = 0;
        boolean canBuy = false;
        boolean shoulBreak = false;

        while (!line.equals("Sporeggar")) {
            char[] array = line.toCharArray();
            for (int i = 0; i < array.length - 1; i++) {
                if (array[i] == 'L') {
                    healthPoints += 200;
                } else {
                    int ascii = (int) array[i];
                    healthPoints -= ascii;
                }
            }

            if (healthPoints <= 0){
                break;
            }

            int x = Character.getNumericValue(array[array.length - 1]);
            glowcaps += x;

            line = getInput.nextLine();
        }

        int glowcapsLeft = glowcaps - 30;
        if (glowcaps >= 30){
            canBuy = true;
        }

        if (canBuy){
            System.out.println("Health left: " + healthPoints);
            System.out.println("Bought the sporebat. Glowcaps left: " + glowcapsLeft);
        } else if (healthPoints <= 0){
            System.out.println("Died. Glowcaps: " + glowcaps);
        } else {
            System.out.println("Health left: " + healthPoints);
            System.out.printf("Safe in Sporeggar, but another %s Glowcaps needed.", 30 - glowcaps);
        }


    }
}
