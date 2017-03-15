package sudoku;

import java.util.Arrays;

/**
 * SudokuBoard class represents a sudoku board, creates a new board, and checks if the given solution is correct
 * Right now the board solution is hardcoded but could in the future be defined by reading from a file.
 * Created by Patrick on 1/28/2017.
 */
public class SudokuBoard {
    private int rows = 9;
    private int columns = 9;

    public int getRows() {
        return rows;
    }

    public int getColumns() {
        return columns;
    }

    private int[][] grid = {{5,3,4,6,7,8,9,1,2},
                            {6,7,2,1,9,5,3,4,8},
                            {1,9,8,3,4,2,5,6,7},
                            {8,5,9,7,6,1,4,2,3},
                            {4,2,6,8,5,3,7,9,1},
                            {7,1,3,9,2,4,8,5,6},
                            {9,6,1,5,3,7,2,8,4},
                            {2,8,7,4,1,9,6,3,5},
                            {3,4,5,2,8,6,1,7,9}};
    /**
     * getRow returns an integer array for the row index specified
     * @param row int Index of desired row
     * @return gridRow An array integers in the row
     */
    public int[] getRow(int row){

        if (row > rows || row < 0) {
            System.out.println("ERROR: Invalid row input");
            int[] gridRow = {0};
            return gridRow;
        }else{
            return grid[row];
        }
    }

    /**
     * getColumn returns an integer array for the column index specified
     * @param column int Index of desired column
     * @return gridColumn An array of integers in the column
     */
    public int[] getColumn(int column){
        int[] gridColumn = new int[9];
        if (column > columns || column < 0) {
            System.out.println("ERROR: Invalid column input");
            gridColumn[0] = 0;
            return gridColumn;
        }else{
            // put all integers from column in an array gridColumn
            for(int i = 0; i < rows; i++)
                gridColumn[i] = grid[i][column];
            return gridColumn;
        }
    }

    /**
     *  getBlock returns a 3x3 integer array for the block specified
     *  @param blockNumber int Block position desired starting with 1 ending with 9
     *  @return block a 3x3 integer array
     */
    public int[][] getBlock(int blockNumber){
        int[][] block = new int[3][3];
        int startRowI; // Row index that starts the block
        int startColumnI; // Column index that starts the block
        //define starting positions of the block based on blockNumber
        switch (blockNumber){
            case 1: //  Left Top Block
                startRowI=0;
                startColumnI=0;
                break;
            case 2: // Mid Top Block
                startRowI=0;
                startColumnI=3;
                break;
            case 3: // Right Top Block
                startRowI=0;
                startColumnI=6;
                break;
            case 4: // Left Mid Block
                startRowI=3;
                startColumnI=0;
                break;
            case 5: // Mid Mid Block
                startRowI=3;
                startColumnI=3;
                break;
            case 6: // Right Mid Block
                startRowI=3;
                startColumnI=6;
                break;
            case 7: // Left Bottom Block
                startRowI=6;
                startColumnI=0;
                break;
            case 8: // Mid Bottom Block
                startRowI=6;
                startColumnI=3;
                break;
            case 9: // Right Bottom Block
                startRowI=6;
                startColumnI=6;
                break;
            default: // Invalid block given
                block[0][0] = 0;
                return block;
        }
        int blockRowI = 0; //Row index for block 3x3 array
        int blockColI = 0; //Column index for block 3x3 array
        // loop through three sequential rows of the block
        for(int i = startRowI; i<startRowI +3;i++ ){
            blockColI = 0;
            // For each row loop through three sequential columns of the block
            for(int j = startColumnI; j<startColumnI+3;j++){
                block[blockRowI][blockColI] = grid[i][j];
                blockColI++;
            }
            blockRowI++;
        }
        return block;
    }

    /**
     * linearizeArray accepts a 3x3 integer array of 9 total items and returns all values in one integer array
     * @param array int[][] a 3x3 integer array
     * @return linearizedArray int[] with all 9 values from the 3x3 array
     */
    private int[] linearizeArray(int[][] array){
        int[] linearizedArray = new int[9];
        int index = 0; // current index of linearized array
        for(int i = 0; i<3; i++){
            for(int j = 0; j<3; j++){
                linearizedArray[index] = array[i][j];
                index++;
            }
        }
        return linearizedArray;
    }

    /**
     * sumArray accept an integer array and returns the sum of all the values
     * @param array int[] Any length
     * @return sum int Sum of all values in array
     */
    private int sumArray(int[] array){
        int sum = 0;
        for(int number:array){
            sum += number;
        }
        return sum;
    }

    /**
     * verifyRows Check if the rows are a valid solutions and returns true or false
     * @return isValid boolean if all rows are valid sudoku solutions
     */
    public boolean verifyRows() {
        boolean isValid = true;
        int maxRow = getRows();
        int i = 0; // current row index
        while (isValid && i < maxRow) {
            int[] row = cloneArray(getRow(i));
            // all rows equal 45 if not then isValid is false
            if (sumArray(row) != 45) {
                isValid = false;
            } else {
                Arrays.sort(row);
                //Loop through each member of the sorted row
                for (int j = 0; j < row.length; j++) {
                    // if value at index j is not j+1 (since sudoku starts at 1) then the solution is false
                    if (row[j] != j + 1) {
                        isValid = false;
                    }
                }
                i++;
            }
        }
        return isValid;
    }
    /**
     * verifyColumns Check if the columns are a valid solutions and returns true or false
     * @return isValid boolean if all columns are valid sudoku solutions
     */
    public boolean verifyColumns(){
        boolean isValid = true;
        int maxColumns = getColumns();
        int i =0; // current row index
        while(isValid && i<maxColumns){
            int[] column = cloneArray(getColumn(i));
            // all columns equal 45 if not then isValid is false
            if (sumArray(column)!= 45){
                isValid = false;
            } else{

                Arrays.sort(column);
                //Loop through each member of the sorted column
                for(int j = 0; j<column.length; j++){
                    // if value at index j is not j+1 (since sudoku starts at 1) then the solution is false
                    if (column[j] != j+1){
                        isValid = false;
                    }
                }
                i++;
            }
        }
        return isValid;
    }

    /**
     * verifyBlocks checks if the blocks are a valid solutions and returns true or false
     * @return isValid boolean if all blocks are valid sudoku solutions
     */
    public boolean verifyBlocks() {
        boolean isValid = true;
        int maxBlocks = 9;
        int i = 1; // start with block 1 since block 0 does not exist
        while(isValid && i<= maxBlocks){
            int[][] blockArray = getBlock(i);
            int [] block = linearizeArray(blockArray);
            // all blocks equal 45 if not then isValid is false
            if (sumArray(block)!=45){
                isValid = false;
            } else{
                Arrays.sort(block);
                for(int j = 0; j<block.length;j++){
                    // if value at index j is not j+1 (since sudoku starts at 1) then the solution is false
                    if (block[j] != j+1) {
                        isValid = false;
                    }else{
                        isValid = true;
                    }
                }
                i++;
            }
        }
        return isValid;
    }

    /**
     * cloneArray accepts an integer array of any length and returns an exact clone of the array
     * This is to prevent any issues with passing an array by reference.
     */
    private int[] cloneArray(int[] array){
        int i = 0;
        int[] clonedArray = new int[array.length];
        for(int number:array){
            clonedArray[i] = number;
            i++;
        }
        return clonedArray;
    }

    /**
     * showBoard Outputs an ASCII style sudoku board to the console
     */
    public void showBoard() {

        // Loop through each row of the grid and set column = 1 so that I can use a modulus to get every three columns
        for (int i = 0; i < rows; i++) {
            int column = 1;
            String rowStr = "";
            int row = i + 1; // row is one more than index for modulus operator to find every three rows
            // loop through each number in the row and build a string rowStr to output for the row
            for (int j = 0; j < columns; j++){
                int number = grid[i][j];
                // end of row reached only add the number
                if (column == columns) {
                    rowStr += number;
                    // if third column then add " | " to rowStr
                }else if ( column %3 == 0) {
                    rowStr += number + " | ";
                }else{
                    rowStr += number + " ";
                }
                //increment column
                column++;
            }
            System.out.println(" " + rowStr);
            if ( row < rows){
                // if third row then output row border
                if (row % 3 == 0) {
                    System.out.println("-------+-------+------");
                }
            }
            row++;
        }
    }
}
