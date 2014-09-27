import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;

public class _10_ExtractAllUniqueWords {

    public static void main(String[] args) {
	Scanner input = new Scanner(System.in);
	String[] wordsLowerCase = input.nextLine().toLowerCase()
		.split("([().,!?:;'\"-]|\\s)+");
	input.close();
	Set<String> words = new TreeSet<>();
	for (String string : wordsLowerCase) {
	    words.add(string);
	}
	for (String string : words) {
	    System.out.print(string + " ");
	}
    }
}