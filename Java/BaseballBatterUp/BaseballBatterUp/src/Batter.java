/**
 * @author Patrick Martin
 * Date: 2/19/17
 * Class represents a batter on a team and the strikes and balls against them
 */
import java.util.Random;

public class Batter {
    private int balls;
    private int strikes;
    private String name;

    public String getName() {
        return name;
    }
    public void printCount(){
        System.out.println("The current count is: " + balls + "-"+strikes);
    }
    // Constructor that accepts a name as a string, and sets balls and strikes to zero
    public Batter(String name){
        this.name = name;
        balls = 0;
        strikes = 0;
    }

    public int getBalls() {
        return balls;
    }

    public void addBall() {
        this.balls += 1;
    }

    public int getStrikes() {
        return strikes;
    }

    public void addStrike() {
        this.strikes += 1;
    }

    public void resetCount(){
        strikes = 0;
        balls = 0;
    }

    /** Swings the bat and determines if it is a hit or not
     *
     * @return int 0 for a hit, 1 for a ball, 2 for a strike
     */
    public int swingBat(){
        int hitType;
        Random rand = new Random();
        hitType = rand.nextInt(3); // returns number between 0 inclusive and 3 exclusive
        return hitType;
    }
}
