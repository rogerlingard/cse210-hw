public class Product{
    private string _productID;
    private double _pricePerUnit;
    private int _quantity;
    private string _name;

    public Product(string productID, double pricePerUnit, int qunatity, string name){
        setProductID(productID);
        setPricePerUnit(pricePerUnit);
        setQuantity(qunatity);
        setName(name);
    }

    public void setProductID(string productID){
        _productID = productID;
    }
    public string getProductID(){
        return _productID;
    }

    public void setPricePerUnit(double pricePerUnit){
        _pricePerUnit = pricePerUnit;
    }
    public double getPricePerUnit(){
        return _pricePerUnit;
    }

    public void setQuantity(int qunatity){
        _quantity = qunatity;
    }
    public int getQunatity(){
        return _quantity;
    }

    public void setName(string name){
        _name = name;
    }
    public string getName(){
        return _name;
    }

    public double totalCost(){
        double totalCost = getPricePerUnit() * getQunatity();
        return totalCost;
    }
}