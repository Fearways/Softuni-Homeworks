import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Scanner;

public class _07_DaysBetweenTwoDates {

	public static void main(String[] args) throws ParseException {	

		Scanner input = new Scanner(System.in);
		System.out.println("Enter a starting date in format dd-MM-yyyy: ");
		String inputStart= input.nextLine();
		System.out.println("Enter an end date in format dd-MM-yyyy: ");
		String inputEnd = input.nextLine();
		SimpleDateFormat format = new SimpleDateFormat("dd-MM-yyyy");
		input.close();
		Date start = null;
		Date end = null;
		String dateStart = inputStart;
		String dateStop = inputEnd;
		start = format.parse(dateStart);
		end = format.parse(dateStop);
		long difference = end.getTime() - start.getTime();
		long days = difference / (24 * 60 * 60 * 1000);
		System.out.println(days);			
	}
}