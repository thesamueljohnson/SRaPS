using System;
using System.Collections.Generic;

public class Sale
{
	private int _saleID;
	private DateTime _time;
	private List<Item> _items = new List<Item>();
	private double _total;
	private Salesperson _salesperson;
	private string _notes;
	private double _discount;

	public double Total { get { return Total; } set { _total = value; } }
	public double Discount { get { return Total; } set { _discount = value; } }

	public List<Item> Items { get { return _items; } set { _items = value; } }

	public Sale(Salesperson salesperson)
	{
		_salesperson = salesperson;
	}
}
