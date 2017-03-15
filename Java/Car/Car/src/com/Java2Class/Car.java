package com.Java2Class;
/**
 * Author:Patrick Martin
 * Date: 2/7/17
 * Project: Car Class Exercise
 * Description: A car class to represent a physical car
 * Pseudocode: Declare fields: int yearModel, String make, int speed
 * Create getters for each field
 * Create constructor Car(yearModel, make) that sets those values and initializes speed to 0
 * Create accelerate method: Adds 5 to speed
 * Create brake method: Subtract 5 from speed
 */
public class Car {
    // Car fields
    private int yearModel;
    private String make;
    private int speed;

    // field getters
    public int getYearModel() {
        return yearModel;
    }

    public String getMake() {
        return make;
    }

    public int getSpeed() {
        return speed;
    }

    // Constructor: Sets yearModel and make, and initializes speed to 0
    public Car(int yearModel,String make){
        this.yearModel = yearModel;
        this.make = make;
        this.speed = 0;
    }

    // Add 5 to speed when called
    public void accelerate() {
        speed += 5;
    }
    // Subtract 5 from speed
    public void brake(){
        // Since braking does not make you go backwards
        // Check if speed is positive, if not just return 0
        if (speed > 0 ) {
            speed -= 5;
        } else {
            speed = 0;
        }
    }
} // end car class
