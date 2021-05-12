using System;

public class Item
{
	private int _itemID;
	private string _name;
	private string _category;
	private double _RRP;
	private double _discountDollar;
	private double _discountPercentage;
	private double _bonusDiscountDollar;
	private double _bonusDiscountPercentage;
	private double _price;

	public int ItemID { get { return _itemID; } }
	public String Name { get { return _name; } set { _name = value; } }
	public String Category { get { return _category; } set { _category = value; } }
	public double RRP { get { return _RRP; } set { _RRP = value; } }
	public double DiscountDollar { get { return _discountDollar; } set { _discountDollar = value; } }
	public double DiscountPercentage { get { return _discountPercentage; } set { _discountPercentage = value; } }
	public double BonusDiscountDollar { get { return _bonusDiscountDollar; } set { _bonusDiscountDollar = value; } }
	public double BonusDiscountPercentage { get { return _bonusDiscountPercentage; } set { _bonusDiscountPercentage = value; } }
	public double Price { get { return _price; } set { _price = value; } }

	public Item(int id, string name)
	{
		_itemID = id;
		_name = name;
	}
}