using System;

public class Item
{
	private int _itemID;
	private string _name;
	private string _category;
	private Char[] _barcode = new char[13];
	private double _RRP;
	private double _discountDollar = 0.00;
	private double _discountPercentage = 0.00;
	private double _bonusDiscountDollar = 0.00;
	private double _bonusDiscountPercentage = 0.00;
	private int _stockQuantity = 1;
	private string _stockString;
	private int _cartQuantity;
	private string _cartString;
	private double _price;

	public int ItemID { get { return _itemID; } }
	public String Name { get { return _name; } set { _name = value; } }
	public String Category { get { return _category; } set { _category = value; } }
	public Char[] Barcode { get { return _barcode; } set { _barcode = value; } }
	public double RRP { get { return _RRP; } set { _RRP = value; } }
	public double DiscountDollar { get { return _discountDollar; } set { _discountDollar = value; } }
	public double DiscountPercentage { get { return _discountPercentage; } set { _discountPercentage = value; } }
	public double BonusDiscountDollar { get { return _bonusDiscountDollar; } set { _bonusDiscountDollar = value; } }
	public double BonusDiscountPercentage { get { return _bonusDiscountPercentage; } set { _bonusDiscountPercentage = value; } }
	public int StockQuantity { get { return _stockQuantity; } set { _stockQuantity = value; } }
	public string StockString { get { return _stockString; } set { _stockString = value; } }
	public int CartQuantity { get { return _cartQuantity; } set { _cartQuantity = value; } }
	public string CartString { get { return _cartString; } set { _cartString = value; } }
	public double Price { get { return _price; } set { _price = value; } }

	public Item(int id, string name)
	{
		_itemID = id;
		_name = name;
	}

	public void Update()
    {
		_stockString = _name + " X " + (_stockQuantity - _cartQuantity).ToString();
		_cartString = _name + " X " + _cartQuantity.ToString();
		_price = (_RRP - _discountDollar - _bonusDiscountDollar) * _cartQuantity;
	}

	public void Duplicate(Item item)
    {
		_itemID = item.ItemID;
		_name = item.Name;
		_category = item.Category;
		_barcode = item.Barcode;
		_RRP = item.RRP;
		_discountDollar = item.DiscountDollar;
		_discountPercentage = item.DiscountPercentage;
		_bonusDiscountDollar = item.BonusDiscountDollar;
		_bonusDiscountPercentage = item.BonusDiscountPercentage;
		_stockQuantity = item.StockQuantity;
		_stockString = item.StockString;
		_cartQuantity = item.CartQuantity;
		_cartString = item.CartString;
		_price = item.Price;
	}
}