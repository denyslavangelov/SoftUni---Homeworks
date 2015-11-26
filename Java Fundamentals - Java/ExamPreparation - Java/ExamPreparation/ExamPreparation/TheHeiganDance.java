package ExamPreparation;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by Deny on 03/11/2015.
 */
public class TheHeiganDance {
    public static void main(String[] args) {
        List<int[]> chamber = new ArrayList<>();
        for (int i = 0; i < 15; i++) {
            int[] arr = new int[15];
            for (int j = 0; j < 15; j++) {
                arr[j] = 1;
            }
            chamber.add(arr);
        }

        for (int[] ints : chamber) {
            System.out.println(ints);
        }
    }


}
