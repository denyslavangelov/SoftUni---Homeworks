package com.company;
import java.util.Scanner;

public class RectangleArea {

    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);

        int firstSide = getInput.nextInt();
        int secondSide = getInput.nextInt();

        int areaOfRectangle = firstSide * secondSide;

        System.out.print(areaOfRectangle);
    }
}
