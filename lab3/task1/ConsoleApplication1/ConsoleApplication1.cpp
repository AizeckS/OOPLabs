#include <iostream>
#include <string>

using namespace std;

class Publication
{
public:
	void getData()
	{
		cout << "Name:\t" << name << "\nPrice:\t" << price << " grn" << endl;
	}
	void putData()
	{
		cout << "Name:\t";
		cin >> this->name;
		cout << "Price:\t";
		cin >> this->price;
	}
private:
	string name;
	float price;
};

class Book :public Publication
{
public:
	void getData()
	{
		Publication::getData();
		cout << "Pages:\t" << pages << endl;

	}
	void putData()
	{
		Publication::putData();
		cout << "Pages:\t";
		cin >> this->pages;
	}
private:
	int pages;
};

class Type :public Publication
{
public:
	void getData()
	{
		Publication::getData();
		cout << "Min:\t" << min << endl;
	}
	void putData()
	{
		Publication::putData();
		cout << "Min:\t";
		cin >> this->min;
	}
private:
	int min;
};


int main()
{

	Book book;
	book.putData();

	Type type;
	type.putData();

	book.getData();
	type.getData();
	return 0;
}

