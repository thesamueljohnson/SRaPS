using System;
using System.Collections.Generic;

public class BusinessDay
{
	private List<Salesperson> _staff = new List<Salesperson>();
	private List<Salesperson> _clockedOn = new List<Salesperson>();
	private List<Sale> _sales = new List<Sale>();
	private DateTime _openTime;
	private DateTime _closeTime;

	public List<Salesperson> Staff { get { return _staff; } }
	public List<Salesperson> ClockedOn { get { return _clockedOn; } }
	public String Date { get { return _openTime.Date.ToShortDateString(); } }
	public List<Sale> Sales { get { return _sales; } }

	public BusinessDay(DateTime openTime)
	{
		_openTime = openTime;
	}

	public void AddStaff(Salesperson salesperson)
    {
		_staff.Add(salesperson);
		_clockedOn.Add(salesperson);
    }

	public void ClockOut(Salesperson salesperson)
    {
		if(_clockedOn.Contains(salesperson))
			_clockedOn.Remove(salesperson);
    }

	public void AddSale(Sale sale)
    {
		_sales.Add(sale);
    }

	public void Close()
    {
		_closeTime = DateTime.Now;
    }
}
