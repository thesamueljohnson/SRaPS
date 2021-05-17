using System;
using System.Collections.Generic;

public class Business
{
	private string _name;
	private string _password;
	private DateTime _systemInstallDate;
	private List<Salesperson> _staff = new List<Salesperson>();
	private List<Item> _items = new List<Item>();
	private List<Report> _reports = new List<Report>();
	private List<String> _categories = new List<string>();
	private List<BusinessDay> _businessDays = new List<BusinessDay>();
	private BusinessDay _currentBusinessDay = null;
	private Report _thisMonthsReport;

	private int _nextStaffID = -1;
	private int _nextItemID = -1;
	private int _nextSaleID = -1;
	private int _nextReportID = -1;

	//Normal properties
	public string Name { get { return _name; } set { _name = value; } }
	public string Password { get { return _password; } }
	public List<Salesperson> Staff { get { return _staff; } }
	public List<Item> Items { get { return _items; } }
	public List<string> Categories { get { return _categories; } }
	public List<BusinessDay> BusinessDays { get { return _businessDays; } }
	public BusinessDay CurrentBusinessDay { get { return _currentBusinessDay; } }

	//ID properties (auto-increments when fetched)
	public int NextStaffID { get { _nextStaffID++; return _nextStaffID; } }
	public int NextItemID { get { _nextItemID++; return _nextItemID; } }
	public int NextSaleID { get { _nextSaleID++; return _nextSaleID; } }
	public int NextReportID { get { _nextReportID++; return _nextReportID; } }

	public Business(string name, string password)
	{
		_name = name;
		_password = password;
		_systemInstallDate = DateTime.Now;
	}

	public void AddStaff(string firstName, string lastName)
    {
		_staff.Add(new Salesperson(NextStaffID, firstName, lastName));
    }
	public void UpdateStaff(int index, string firstName, string lastName)
    {
		_staff[index].FirstName = firstName;
		_staff[index].LastName = lastName;
		_staff[index].FullName = firstName + " " + lastName;
	}

	public void ChangePassword(string newPassword)
    {
		//More checks needed here
		_password = newPassword;
    }

	public Item AddItem(string name)
    {
		Item item = new Item(NextItemID, name);
		_items.Add(item);
		return (item);
    }

	public void RemoveItem(int index)
    {
		_items.RemoveAt(index);
    }

	public void AddCategory(string name)
    {
		if (!_categories.Contains(name))
			_categories.Add(name);
    }

	public void UpdateCategory(int index, string name)
    {
		_categories[index] = name;
    }

	public void RemoveCategory(int index)
    {
		_categories.RemoveAt(index);
    }

	public void StartBusinessDay()
    {
		_currentBusinessDay = null;

		//Resume business day if they have a matching date
		foreach(BusinessDay day in _businessDays)
        {
			if(day.Date == DateTime.Now.Date.ToShortDateString())
				_currentBusinessDay = day;
        }
		//Start a new business day if there's no matching date
		if(_currentBusinessDay == null)
			_currentBusinessDay = new BusinessDay(DateTime.Now);
    }

	public void EndBusinessDay()
    {
		_currentBusinessDay.Close();
		if(!_businessDays.Contains(_currentBusinessDay))
			_businessDays.Add(_currentBusinessDay);
		_currentBusinessDay = null;
    }

	public bool IsLastClockedIn(Salesperson last)
    {
		foreach(Salesperson salesperson in _currentBusinessDay.ClockedOn)
        {
			if (salesperson.IsClockedIn() && salesperson.StaffID != last.StaffID)
				return false;
        }

		return true;
    }
}