package com.Java2Class;
/**
* Author: Patrick Martin
* Date: 2/7/17
* Purpose: Test the new Car class and it's methods
*/
public class Main {

    public static void main(String[] args) {
	    Car car1 = new Car(1992, "Volkswagon");

	    System.out.println("The " + car1.getYearModel() + " " + car1.getMake() + " is now at starting line");
	    // Accelerate 5 times and print current speed after each one
	    car1.accelerate();
        System.out.println("Current speed: " + car1.getSpeed());
        car1.accelerate();
        System.out.println("Current speed: " + car1.getSpeed());
        car1.accelerate();
        System.out.println("Current speed: " + car1.getSpeed());
        car1.accelerate();
        System.out.println("Current speed: " + car1.getSpeed());
        car1.accelerate();
        System.out.println("Current speed: " + car1.getSpeed());
        // Brake 5 times and print current speed after each one
        car1.brake();
        System.out.println("Current speed: " + car1.getSpeed());
        car1.brake();
        System.out.println("Current speed: " + car1.getSpeed());
        car1.brake();
        System.out.println("Current speed: " + car1.getSpeed());
        car1.brake();
        System.out.println("Current speed: " + car1.getSpeed());
        car1.brake();
        System.out.println("Current speed: " + car1.getSpeed());
    } // end main
} // end class
