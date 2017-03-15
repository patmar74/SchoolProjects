/**
 * Class calls product class and enables of testing of the class.
 * Product contains a basic product structure
 * product test enables sorting of those products.
 * 
 *  Created in Eclipse 
 *  Eclipse IDE for Java Developers
 *  Version: Mars.1 Release (4.5.1)
 *  Build id: 20150924-1200
 *  
 *   * 	Updates required by you the student
 * 	The current product list is static and you are provided a text file called plumbingproducts.txt in the Bin folder
 *  Thus createData() will be deprecated and replaced with a new create data. 
 *  the file doesn't have a description, we will use the name as the description as well.
 *  
 *  Next you will have to add, edit or retire a product. Also you will be able to state if a product is equal to a new product (no duplicate listing).
 *  Your main class will a method which handles product updates (i.e. SortProducts but for product updates)
 *  From Main you can call product updates, SortProducts, Save, or application end. this app will be a loop until you inform it to quit.
 *  
 *  Save will overwrite the existing plumbingproducts.txt You will need to either create a class or method to handle such.
 *  
 *  Fix Sort Products so it has a means to quit sorting.
 *  
 *  Product Class enhancements
 *  You will need to product category to the product class. 
 *  You will need to state the product is retired (end date, retirement flag, what have you)
 *  You will complete the equals method.
 *  The toString requires clean up so creates  a more English statement and the information is tab separated.
 * 
 * 
 */
import java.io.*;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.Scanner;


/**
 * @author Jeffrey
 * @author Patrick Martin (editor)
 */
public class TestProduct {

	/**
	 * @param args
	 */
	public static void main(String[] args) throws NumberFormatException, IOException {
		// declare an array  list for products 
		ArrayList<product> productList=new ArrayList<product>();
		// create a set of products
        productList = createData();
        productList.add(new product(1023444,"PVC Pipe 8ft","Pipe",8.29));
        productList.get(3).retire("12/25/18");
        System.out.println(productList.get(3).getRetiredString());
        product myProduct = new product(1023444,"PVC Pipe 8ft","Pipe",8.29);
        if (myProduct.equals(productList.get(productList.size()-1))){
            System.out.println("The products are the same");
        }else{
            System.out.println("The are not the same");
        }
        SortProducts(productList);
        createInventoryFile(productList);
        

	}  // end main
	// create data 
	private static ArrayList<product> createData(){
	    ArrayList<product> productListing=new ArrayList<product>();

        try {
            File myFile = new File("bin/plumbingproducts.txt");
            Scanner plumbingProducts = new Scanner(myFile);
            plumbingProducts.nextLine(); // progress past the first line which is the header
            // Loop through file and put products in the arrayList
            //FUTURE REFERENCE TABS ARE TERRIBLE AND UNRELIABLE DELIMITERS
            while (plumbingProducts.hasNextLine()){
                String[] temp = plumbingProducts.nextLine().split("\t"); // Holds string array for whole line which was tab delimitted
                int itemID = Integer.parseInt(temp[0]); // Holds item number from temp[0]
                String description = temp[1]; // Holds description from temp[1]
                String subCategory = temp[2]; // Holds sub category from temp[2]
                double price = Double.parseDouble(temp[3]); // Holds price from temp[3]
                productListing.add(new product(itemID,description,subCategory,price)); // Add product to the ArrayList
            } //end while
            plumbingProducts.close();
        } catch (Exception e) {
            System.out.println(e.getMessage());
            e.printStackTrace();
        }

        return productListing;
	} // end createData
	
	private static void SortProducts (ArrayList<product> productList) throws NumberFormatException, IOException
	{
        BufferedReader br=new BufferedReader(new InputStreamReader(System.in));
        boolean quit = false;
        while(!quit)
        {
            System.out.println("1 : Sort by id");
            System.out.println("2 : Sort by name");
            System.out.println("3 : Sort by price");
            int ch=Integer.parseInt(br.readLine());
            switch(ch)
            {
                case 1 : 
                       	Collections.sort( productList);
                         System.out.println("Sorted product : ");
                         for(product p : productList)
                         {
                             System.out.println(p);
                         }
                         break;
                case 2 : Collections.sort(productList, new Comparator<product>()
                         {
                                @Override
                         public int compare(product p1, product p2)
                         {
                         int i=p1.getProductName().compareToIgnoreCase 
                                                  (p2.getProductName());
                            if(i==0)
                            {
                            return p1.getProductCategory().
                             compareToIgnoreCase(p2.getProductCategory());
                            }                   
                                       return i;
                         }
                       });  
                System.out.println("Sorted product : ");
                 for(product p : productList)
                 {
                     System.out.println(p);
                 }
                 break;
               case 3 :
            	   Collections.sort(productList,new product.ProductInnerClass());
                    System.out.println("Sorted product : ");
                     for(product p : productList)
                     {
                         System.out.println(p);
                     }
                     break;
                default : System.out.println("Invalid Option");    
                           System.exit(0);
            	}  // end switch
            System.out.println("Do you need to sort again? Y/N");
            String answer = br.readLine();
            if (answer.equalsIgnoreCase("Y")){
                quit = false;
            }else {
                quit = true;
            }//end if

        	}	// end while
	}	// end sort products

    private static void createInventoryFile(ArrayList<product> products){

        try {
            PrintWriter myInventory = new PrintWriter("bin/plumbingproducts.txt");
            myInventory.println("Item#\tDescription\tSub Category\tPrice");
            for (product prod:products){
                myInventory.println(prod.getProductId()+"\t"+prod.getProductName()+"\t"+ prod.getProductCategory()
                + "\t" + prod.getPrice());
            }
            myInventory.close();
        } catch (FileNotFoundException e) {
            System.out.println(e.getMessage());
            e.printStackTrace();
        }
    }
}	// end class
