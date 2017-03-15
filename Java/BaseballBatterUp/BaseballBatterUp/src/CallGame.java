/**
 * @author Patrick Martin
 * Date: 2/20/17
 * Call game's only purpose is to create a new game and then start it.
 * Pseudocode: Create batters with properties of strikes, balls, and name
 *                            with a method to swing a bat and return the results of the swing
 *             Create a Team with an Arraylist of batters with properties outs, and nextBatterIndex
 *                            with a method to evaluate the at bat of the current batter and do the appropriate
 *                            course of action, then move to the next batter until 3 outs have been made.
 *             Create a Game made up of two Teams, with a property of currentInning
 *                            with methods to control the flow of the game.
 *                            Loop through innings until one of the teams has had all batters struck out.
 *                            Due to the nature of baseball and since the team is 9 people, this will always occur
 *                            at the top of the 3rd inning.
 */
public class CallGame {
    public static void main(String[] args){
        Game myGame = new Game();
        myGame.runGame();
    }
}
