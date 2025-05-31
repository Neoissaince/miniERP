//SPDX-License-Identifier:MIT
pragma solidity ^0.8.0;


// A test contract of the inventory module. Cannot be implemented on the blockchain since it will be slower to interact with the chain during inventory management.
contract Inventory {
    address public Admin;

    struct Product {
        uint256 id;
        string name;
        uint256 quantity;
        uint256 price;
    }
    // mapping product(object) to Product(instance)
    mapping(uint256 => Product) products;
    uint256 public productCount;

    modifier OnlyAdmin() {
        require(msg.sender == Admin, "Only the Admin has access!!");
        _;
    }

    constructor() {
        Admin = msg.sender;
    }

    // Adding a product (onlyAdmin)
    function AddProduct(
        string memory name,
        uint256 quantity,
        uint256 price
    ) public OnlyAdmin {
        productCount++;
        products[productCount] = Product(productCount, name, quantity, price);
    }

    // Getting a product
    function GetProduct(uint256 id) public view returns (Product memory) {
        return products[id];
    }

    // Updating a product
    function UpdateProduct(uint256 id, uint256 newQuantity) public OnlyAdmin {
        require(id > 0 && id <= productCount, "Invalid Id!!");
        products[id].quantity = newQuantity;
    }
}
