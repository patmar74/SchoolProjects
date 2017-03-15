
/**Author: Patrick Martin
 * Project:genericArrayListfromfile Class
 * Date: 2/8/2017
 * Purpose: Create instance of new class, pass file name through into arraylist,
 * print out each arraylist
 */
package com.Java2Class;

import java.util.Scanner;

public class callGALFF {

    public static void main(String[] args){
        //Ask for user input
        Scanner kbd = new Scanner(System.in);
        String pathName;
        System.out.print("Please paste the file path here: ");
        pathName = kbd.nextLine();

        genericArrayListFromFile array = new genericArrayListFromFile(pathName);
        // Print the array
        System.out.println(array.toString());
        System.out.println("This Array List has " + array.size() + " members");
        System.out.println("Path is " + array.getPathName());
        System.out.println("File Name is " + array.getFileName());
        int i = 0; // counter for conversions
        String[] myArray = new String[array.size()];
        //Convert to String array
        for (Object item:array){
            myArray[i] = item.toString();
            i++;
        }
        // Show that array creation worked
        System.out.println("This is your new array");
        for (String item:myArray){
            System.out.print(item);
        }

    }
}
