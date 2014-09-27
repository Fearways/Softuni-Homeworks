import java.util.Scanner;

public class _05_AngleUnitConverter {
	
	public static void main(String[] args) {
	  Scanner input = new Scanner(System.in);
	  System.out.println("Enter number 'n' to determine the number of entries: ");
	  int n = Integer.parseInt(input.nextLine());
	  double[] numbers = new double[n];
	  String[] measure = new String[n];
	  for (int i = 0; i < n; i++) {
		  if (input.hasNextDouble()) {
			  numbers[i] = input.nextDouble();
		}
		  if (input.hasNext()) {
			  measure[i] = input.next();
		}
	  }
	  input.close();
	  for (int i = 0; i < n; i++) {
	    if (measure[i].equals("rad")) {
			radiansToDegrees(numbers[i]);
		}
	    else if(measure[i].equals("deg")) {
			degreesToRadians(numbers[i]);
		}
	  }	
	}
	
	public static void degreesToRadians(double degrees){
		double radians = (degrees * (double)Math.PI) / 180.0d;
		System.out.printf("%.6f rad\n",radians);		
	}

	public static void radiansToDegrees(double radians){
		double degrees = radians * (180.0d /(double)Math.PI);
		System.out.printf("%.6f deg\n ",degrees);		
	}
}