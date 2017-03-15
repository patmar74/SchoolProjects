package com.Java2Class;

import java.util.ArrayList;
import java.io.*;
import java.util.Scanner;


/**Author: Patrick Martin
 * Project:genericArrayListfromfile Class
 * Date: 2/8/2017
 * Purpose: Build class to open file, read file into arraylist
 * Use methods that will return array list, count items in arraylist,
 * return file name and path name
 */

public class genericArrayListFromFile extends ArrayList{
    //Initialize fileName field
    private String fileName = "";
    //Initialize pathName field
    private String pathName = "";


    //Constructor that accepts a pathName to the file being read
    public genericArrayListFromFile(String pathName){
        int indexOfSlash;
        // position of last \ in the file path
        indexOfSlash = pathName.lastIndexOf("\\");
        this.pathName = pathName;
        // If index of slash is 0 or positive then use substring to get fileName
        if (indexOfSlash >= 0) {
            // indexOfSlash + 1
            this.fileName = pathName.substring(indexOfSlash+1);
        } else { // else fileName is the same as the pathName
            fileName = pathName;
        }

        readIntoArrayList(pathName);
    }

    //Method to Open & Read File into ArrayList
    private void readIntoArrayList(String pathName) {
        try {
            File myFile = new File(pathName);
            Scanner readFile = new Scanner(myFile);
            while(readFile.hasNext()){
                this.add(readFile.nextLine());
            }
            readFile.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
    //Needed: Method to return the ArrayList
        // Not needed since inheriting ArrayList, calling the variable is returning the arrayList
    //Needed: Method to return number of items in ArrayList
        // Not needed since inheriting ArrayList, this class has access to ArrayList's size() method

    public String getPathName() {
        return pathName;
    }

    public String getFileName() {
        return fileName;
    }

}// end class

