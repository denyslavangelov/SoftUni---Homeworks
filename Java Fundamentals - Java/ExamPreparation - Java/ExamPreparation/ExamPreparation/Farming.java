package ExamPreparation;

import java.util.*;

/**
 * Created by Deny on 03/11/2015.
 */
public class Farming {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);

        String[] input = getInput.nextLine().toLowerCase().split(" ");
        int shards = 0;
        int motes = 0;
        int fragments = 0;
        int leathers = 0;
        int stones = 0;
        int fangs = 0;
        int silver = 0;

        boolean isBreak = false;
        List<Integer> asd = new ArrayList<>();
        Map<String, Integer> hm = new HashMap<String, Integer>();

        while (fragments < 250 || motes < 250 || shards < 250) {
            for (int i = 0; i < input.length - 1; i++) {
                if (input[i + 1].equals("shards")) {
                    int quantity = Integer.parseInt(input[i]);
                    shards += quantity;
                    hm.put("shards", shards);
                }
                if (input[i + 1].equals("motes")) {
                    int quantity = Integer.parseInt(input[i]);
                    motes += quantity;
                    hm.put("motes", motes);
                }
                if (input[i + 1].equals("fragments")) {
                    int quantity = Integer.parseInt(input[i]);
                    fragments += quantity;

                }
                if (input[i + 1].equals("fangs")) {
                    int quantity = Integer.parseInt(input[i]);
                    fangs += quantity;
                } if (input[i + 1].equals("stones")) {
                    int quantity = Integer.parseInt(input[i]);
                    stones += quantity;
                } if (input[i + 1].equals("leathers")) {
                    int quantity = Integer.parseInt(input[i]);
                    leathers += quantity;
                }
                if (input[i + 1].equals("silver")) {
                    int quantity = Integer.parseInt(input[i]);
                    silver += quantity;
                }


                if (fragments >= 250 || shards >= 250 || motes >= 250){
                    isBreak = true;
                    break;
                }

            }
            if (isBreak){
                break;
            }
            input = getInput.nextLine().toLowerCase().split(" ");
        }
        if (fragments >= 250){
            fragments -= 250;
            hm.put("fragments", fragments);
            System.out.println("Valanyr obtained!");
        }
        else if (motes >= 250){
            motes -= 250;
            System.out.println("Dragonwrath obtained!");
        }
        else if (shards >= 250) {
            shards -= 250;
            System.out.println("Shadowmourne obtained!");
        }

        Map<String, Integer> treeMap = new TreeMap<String, Integer>(hm);
        printMap(treeMap);


    }

    public static void printMap(Map<String, Integer> map) {
        for (Map.Entry<String, Integer> entry : map.entrySet()) {
            System.out.println("[Key] : " + entry.getKey()
                    + " [Value] : " + entry.getValue());
        }
    }
    private static Map<String, Integer> sortByComparator(Map<String, Integer> unsortMap) {

        // Convert Map to List
        List<Map.Entry<String, Integer>> list =
                new LinkedList<Map.Entry<String, Integer>>(unsortMap.entrySet());

        // Sort list with comparator, to compare the Map values
        Collections.sort(list, new Comparator<Map.Entry<String, Integer>>() {
            public int compare(Map.Entry<String, Integer> o1,
                               Map.Entry<String, Integer> o2) {
                return (o1.getValue()).compareTo(o2.getValue());
            }
        });

        // Convert sorted map back to a Map
        Map<String, Integer> sortedMap = new LinkedHashMap<String, Integer>();
        for (Iterator<Map.Entry<String, Integer>> it = list.iterator(); it.hasNext();) {
            Map.Entry<String, Integer> entry = it.next();
            sortedMap.put(entry.getKey(), entry.getValue());
        }
        return sortedMap;
    }
}

