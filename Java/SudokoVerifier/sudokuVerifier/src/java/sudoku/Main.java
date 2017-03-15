package sudoku;

/**
 * Author: Patrick Martin
 * Date: 1/28/17
 * Purpose: Create a program to verify that a sudoku solution is valid
 * */
public class Main {

    public static void main(String[] args) {

        //initialize new sudokuBoard
        SudokuBoard board = new SudokuBoard();
        board.showBoard();
        boolean rowsValid = board.verifyRows();
        boolean columnsValid;
        boolean blocksValid;
        boolean validSolution;
        if (rowsValid) {
            columnsValid = board.verifyColumns();
            if(columnsValid) {
                blocksValid = board.verifyBlocks();
                if(blocksValid) {
                    validSolution = true;
                }else{
                    validSolution = false;
                }
            }else{
                validSolution = false;
            }
        }else{
            validSolution = false;
        }
        if (validSolution){
            System.out.println("This solution is valid. Good job!");
        }else {
            System.out.println("This solution is not valid. Better luck next time.");
        }
    }


} // end Main class

