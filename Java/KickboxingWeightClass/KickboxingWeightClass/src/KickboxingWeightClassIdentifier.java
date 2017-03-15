// Author: Patrick Martin
// Date: 1/24/17
// Purpose: Accept user input for weight and determine what weight class they are in based
// 			on predetermined, hard coded values. Results are output to the console.

import java.util.Scanner;
public class KickboxingWeightClassIdentifier {

	public static void main(String[] args) {
		// TODO initialize weight array and class array both of equal length
		Scanner kbd = new Scanner(System.in);
		boolean willContinue = true; // Flag if user wants to continue
		String input;
		while (willContinue){
			System.out.print("Enter your weight to find what weight class you are in: ");
			input = kbd.nextLine();
			getWeightClass(input);
			System.out.print("Do you have more data to check? Y or N: ");
			input = kbd.nextLine();
			
			if (input.equalsIgnoreCase("Y")){
				willContinue = true;
			} else {
				willContinue = false;
			}
		}
		kbd.close();
	} // end main
	
	// Accepts a string of user input representing weight and outputs the weight class to the console
	private static void getWeightClass(String inputStr) {
		// weights array holds non-inclusive max value of each weight class
		// last index will hold -1 as the value should never be checked
		int[] weights = {112,115,118,122,126,130,135,140,147,154,160,167,174,183,189,198,209,-1};
		// classString array holds weight classification strings
		// an weights[0] corresponds with classString[0]
		String[] classString = {"Fly Weight","Super Fly Weight", "Bantam Weight", "Super Bantam Weight", 
				"Feather Weight", "Super Feather Weight", "Light Weight", "Super Light Weight", "Welter Weight",
				"Super Welter Weight", "Middle Weight", "Super Middle Weight", "Light Heavy Weight", "Super Light Heavy Weight",
				"Cruiser Weight", "Super Cruiser Weight", "Heavy Weight", "Super Heavy Weight"};
		double weight; // Holds validated value for user weight entry
		String weightClass;  // Holds string for weight class
		boolean isValid = false; // Flag for checking if user input is a valid integer
		boolean classFound = false;  // Flag for if the weight class has been found
		Scanner kbd = new Scanner(System.in);
		// Ask for user input
		
		inputStr = inputStr.trim(); // trim off any leading or trailing spaces
		isValid = isNumeric(inputStr);
	
		// Prompt new entry until valid data is entered
		while (!isValid) {
			System.out.print("Please enter a valid weight: ");
			inputStr = kbd.next();
			isValid = isNumeric(inputStr);
		}
		kbd.close();
		// Make validated input an integer
		weight = Double.parseDouble(inputStr);
		
		int i = 0; // counter for iterating through 
		// Search for weight in weights array
		while (!classFound){
			// since starting at 0 if weight is less than the value in weights then the class has been found
			// iterate through weights until class is found
			// if weights[i] = -1 then last weight class with no upper bound 
			if (weight < weights[i]){
				classFound = true;
				
			} else if (weights[i] == -1 ){
				classFound = true;
			} else {
				i++;
			}
		}
		weightClass = classString[i];
		System.out.println("Your weight class is: " + weightClass + ".");
	} // end getWeightClass
	
	// Accepts a string and checks if the value is a number
	// incidentally it returns false for negative numbers since '-' is not a digit and is not explicitly handled
	private static boolean isNumeric(String s) {
		boolean isNumber = false;
		int dotCount = 0; // Counter of for '.'
		// Loop through each character in the string to check if digit or '.'
		for (int i = 0; i < s.length(); i++   ) {
			char c = s.charAt(i);
			// increment dotCount if c is '.'
			if (c == '.') {
				dotCount++;
			}
			// if dotCount then return false because number has too many decimals to be a valid double
			if (dotCount > 1) {
				return false;
			} else if (Character.isDigit(c) || c == '.') {
				isNumber = true;	
			} else {
				return false;
			}
			
		}
		return isNumber;
	} // end isNumeric
} // end KickboxingWeightClassIdentifier
