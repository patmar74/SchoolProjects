import java.util.ArrayList;

/**
 * @author Patrick Martin
 * Date: 2/20/17
 * Game represents the actual game being played and processes how to continue
 */
public class Game {
    int inning = 1;
    ArrayList<Team> gameTeams= new ArrayList<>();
    Team team1;
    Team team2;
    // runs the game and runs through all innings until one team has had all 9 batters struck out
    public void runGame(){
        initializeTeams();
        gameTeams.add(team1);//index 0
        gameTeams.add(team2);//index 1
        boolean gameContinue = true;
        while (gameContinue){
            gameContinue = runHalfInning(0); // Check if team one ends the game
            if (gameContinue){
                runHalfInning(1);
            }
            if (gameContinue){
                System.out.println("Inning " + inning + " is over");
            }
            inning +=1;
        }
        team1 = gameTeams.get(0);
        team2 = gameTeams.get(1);
        System.out.println("The game has ended in inning " + (inning-1));
        System.out.println(team1.getTeamName() + " has had " + team1.getSuccessfulHits()+ " successful hits this game.");
        System.out.println(team2.getTeamName() + " has had " + team2.getSuccessfulHits()+ " successful hits this game.");
        if (team1.getSuccessfulHits() > team2.getSuccessfulHits()) {
            System.out.println("The " + team1.getTeamName() + " have won!");
        } else if (team2.getSuccessfulHits() > team1.getSuccessfulHits()) {
                System.out.println("The " + team2.getTeamName() + " have won!");
        } else {
            System.out.println("The teams have tied with " + team1.getSuccessfulHits() + " successful hits.");
        }
    }// end run game

    // Initializes the team object members of the Game class
    public void initializeTeams(){
        String[] namesTeam1 = {"Jim","John","Jacob","Jack","Jerry","Jeffrey","Joey","Jamie","Justin"};
        String[] namesTeam2 = {"Michael","Mason","Matt","Maurice","Mick","Manuel","Max","Mozzie","Mufasa"};
        this.team1 = new Team(namesTeam1,"Jays");
        this.team2 = new Team(namesTeam2,"Ems");
    }// end initializeTeams

    // runs an inning of the specified team, returns true if game should continue, returns false if game will not continue due to a team running our of players
    public boolean runHalfInning(int teamIndex){
        boolean continueGame = true;
        Team currentTeam = gameTeams.get(teamIndex);
        Team nextTeam;
        currentTeam.resetOuts(); // make sure inning doesn't autoprogress if outs is already 3
        // nextTeam is always the other index
        if (teamIndex == 0){
            nextTeam = gameTeams.get(1);
        }else{
            nextTeam = gameTeams.get(0);
        }
        boolean inningContinue = true; // flag to continue the inning
        while (inningContinue){
            if(currentTeam.getTeamSize() == 0){ // check if team still has members that can play
                inningContinue = false;
                continueGame = false;
            }else{
                currentTeam.atBatBegin();
            }

            if(currentTeam.getOuts()==3){
                inningContinue = false;
                if(currentTeam.getTeamSize() == 0){ // check if team still has members that can play
                    continueGame = false;
                }
                System.out.println("The " + currentTeam.getTeamName() + " is out, " + nextTeam.getTeamName() + " is up next.");
            }
            currentTeam.nextBatter();
        }
        return continueGame;
    }//end run Half of inning
}// end Game
