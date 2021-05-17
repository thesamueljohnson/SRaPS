using System;
using System.Collections.Generic;
using System.Globalization;

public class Sale
{
	private int _saleID;
	private DateTime _time;
	private List<Item> _items = new List<Item>();
	private double _total = 0;
	private Salesperson _salesperson;
	private string _transactionString;
	private string _notes;
	private double _discount;

	public double Total { get { return Total; } set { _total = value; } }
	public string TotalString {  get { return _total.ToString("C", CultureInfo.CreateSpecificCulture("en-US")); } }
	public string TransactionString { get { return _transactionString; } set { _transactionString = value; } }
	public double Discount { get { return Total; } set { _discount = value; } }

	public List<Item> Items { get { return _items; } set { _items = value; } }

	public Sale(int saleID, Salesperson salesperson)
	{
		_saleID = saleID;
		_time = DateTime.Now;
		_salesperson = salesperson;
	}
}
