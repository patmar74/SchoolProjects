import java.util.ArrayList;
import java.util.Scanner;

/**
 * @author Patrick Martin
 * Date: 2/19/17
 * A class representing a team of 9 baseball players
 * The team class controls the play of each team, ie) evaluates how the player bats,
 * keeps track of the outs, and determines the batting order
 */
public class Team  {
    private ArrayList<Batter> players = new ArrayList<>();
    private int outs = 0;
    private int currentBatterIndex = 0;// index of current batter
    private int successfulHits = 0; // counter for hits for the team
    private String teamName;

    public int getTeamSize(){
        return players.size();
    }

    public String getTeamName() {
        return teamName;
    }

    public int getSuccessfulHits(){
        return successfulHits;
    }

    public int getOuts() {
        return outs;
    }

    public int getCurrentBatterIndex() {
        return currentBatterIndex;
    }

    public void resetOuts(){
        outs = 0;
    }

    // remove player due to strike out
    private void removePlayer(){
        players.remove(currentBatterIndex);
    }

    public void nextBatter(){
        currentBatterIndex += 1;
        //if team is out of players, then reset batterIndex to 0
        if (currentBatterIndex >= players.size()){
            currentBatterIndex = 0;
        }
    }

    /**
     * Constructs the team from a String array of player names
     * @param names a String array of exactly 9 elements
     * @param teamName a String for the name of the team
     */
    public Team(String[] names, String teamName){
        if(names.length == 9){
            for(String name:names){
                players.add(new Batter(name));
            }
        }else{
            System.out.println("The roster provided is not the right size");
        }
        this.teamName = teamName;
    }

    /**
     * Begins an at bat for the current player
     */
    public void atBatBegin(){
        boolean continueBatting = true; //flag to continue batting
        boolean hitMade = false;
        Batter currentBatter = players.get(currentBatterIndex);
        currentBatter.resetCount();
        do{
            hitMade = evaluateBat(currentBatter);// returns true only if a hit was mad

            if(hitMade){
                continueBatting = false;
            }else{// print count if ball not hit
                currentBatter.printCount();
            }
            //if 4 ball was pitched, at bat ends, report walk
            if(currentBatter.getBalls() == 4){
                continueBatting = false;
                System.out.println(currentBatter.getName() + " has been walked.");
                // if 3 strikes pitched, at bat ends, add out, report out, and remove player from lineup
            }else if(currentBatter.getStrikes()== 3){
                continueBatting = false;
                outs += 1;
                System.out.println(currentBatter.getName() + " has struck out.");
                System.out.println(teamName + " has " + outs + " out now.");
                removePlayer();
            }

        }while(continueBatting);
    }

    /**
     *
     * @param currentBatter Batter object for the current batter
     * @return true if at bat was a hit, false if not hit
     */
    private boolean evaluateBat(Batter currentBatter){
        Scanner kbd = new Scanner(System.in);
        System.out.print("And the pitch... Press enter to see what happens.");
        kbd.nextLine(); // solely to stop the program from continually running

        int hitType;
        boolean hasHit = false;
        hitType = currentBatter.swingBat();
        switch (hitType){
            case 0:{
                System.out.println(currentBatter.getName() + " has successfully hit the ball");
                hasHit = true;
                successfulHits += 1;
                break;
            }
            case 1:{
                currentBatter.addBall();
                System.out.println("The pitcher threw a ball to " + currentBatter.getName() + " .");
                break;
            }
            case 2: {
                currentBatter.addStrike();
                System.out.println("The pitcher threw a strike to " + currentBatter.getName() + " .");
                break;
            }
        }
        return hasHit;
    }

}
