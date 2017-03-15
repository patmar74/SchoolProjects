import java.util.Comparator;

/**
 * product class which has basic details of a product.
 */

/**
 * @author Jeffrey
 * @author Patrick Martin (editor)
 *
 */
public class product implements Comparable<product>{
	 private int productId;
	 private String productName;
	 private String productCategory;
	 private double price;
	 private boolean isRetired= false;
	 private String dateRetired="";

	 public void retire(String date){
	     isRetired = true;
	     dateRetired = date;
     }
     //Check if product has been retired and return string of when
     public String getRetiredString(){
	     if (isRetired){
	         return productName + " was retired on " + dateRetired;
         }else{
	         return ""; //return empty string if not retired
         }

     }
     public boolean checkRetired(){
         return isRetired;
     }

	 public product()
     {     
     }

     public product(int productId, String productName, String productCategory, double price)
    {
         this.productId = productId;
         this.productName = productName;
         this.productCategory = productCategory;
         this.price = price;
    }
     // return product id
      public int getProductId()
      {
              return productId;
      }

      // create product id
      public void setProductId(int productId)
      {
            this.productId = productId;
      }
      // get product name
      public String getProductName()
      {
             return productName;
      }

      // set product name
		public void setProductName(String productName)
		{
		 this.productName = productName;
		}
		
		// return the product description
		public String getProductCategory()
		{
		 return productCategory;
		}
		
		// set the product description
		public void setProductCategory(String productDescription)
		{
		 this.productCategory = productDescription;
		}
		
		// return the price
		public double getPrice()
		{
		 return price;
		}
		
		// set the price of the product
		public void setPrice(double price)
		{
		 this.price = price;
		}
		
		// compare product ids
		public int compareTo(product p)
		{  
		 return this.productId-p.productId;
		}
		

		// do we have the same products?	    
		// you need to complete this
		// compare to instances of product class to see if they are equal
	    public boolean equals(product p1)
	    {
	    	if(productId == p1.getProductId() && productName.equals(p1.getProductName()) && productCategory.equals(p1.getProductCategory())&& price==p1.getPrice()){
	    	    return true;
            }else{
                return false;
            }
	    }// end equals
	    
		@Override
		public String toString()
		{
  			// clean this up so it shows in English and is tab separated.
		 return  productId + "\t" + productName + "\tCategory:"
                 + productCategory +"\t" + price;
		}	 		
				
		// product inner class enables the object of its own kind to be sorted.
		public static class ProductInnerClass implements Comparator<product>
	    {
	        @Override
	        public int compare(product p1, product p2)
	        {
	            int i=Double.compare(p1.getPrice(), p2.getPrice());
	            if(i==0)
	            {
	                return p1.getProductId()-p2.getProductId();
	            }
	            return i;
	        }       
	    }  

	    
		
		
}
