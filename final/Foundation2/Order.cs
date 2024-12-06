using System.Net.Http.Headers;

public class Order{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer){
        setCustomer(customer);
        setProducts(products);
        
    }

    public void setProducts(List<Product> products){
        _products = products;
    }
    public List<Product> getProducts(){
        return _products;
    }

    public void setCustomer(Customer customer){
        _customer = customer;
    }
    public Customer getCustomer(){
        return _customer;
    }

    public double totalOrderCost(){
        Customer customer = getCustomer();
        
        double totalCost = 0;
        if(customer.inUSA()){
            double shippingCost = 5;
            
            foreach(Product product in getProducts()){
                totalCost += product.totalCost();
            }

            return totalCost + shippingCost;
        }
        else{
            float shippingCost = 35;

            foreach(Product product in getProducts()){
                totalCost += product.totalCost();
            }

            return totalCost + shippingCost;
        }

    }
    public string shippingLable(){
        return $"Shipping Lable: \nCustomer name: {getCustomer().getName()} \nCustomer Address: {getCustomer().getAddress().fullAddress()}";

    }
    public string packingLable(){
        string packingLable = "Packing Lable: ";
        foreach(Product product in getProducts()){
            packingLable += $"\nName: {product.getName()} \nProduct ID: {product.getProductID()} \nQunatity: {product.getQunatity()} \n";
        }
        return packingLable;

    }

}