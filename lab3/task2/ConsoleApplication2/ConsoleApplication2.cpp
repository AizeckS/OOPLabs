#include <iostream>

using namespace std;

class PairNum
{
protected:
	int a, b, c, d;
public:
	PairNum() : a(1), b(2), c(3), d(4)
	{}

	PairNum(int a, int b, int c, int d) : a(a), b(b), c(c), d(d)
	{}

	~PairNum()
	{}

	void PairSum()
	{
		cout << "a+c= " << a + c << endl;
		cout << "b+d= " << b + d << endl;
	}
};

class MultiNum:PairNum
{
protected:
	int olderPart1 = a * 10;
	int yongerPart1 = b;
	int olderPart2 = c * 10;
	int yongerPart2 = d;
public:
	MultiNum(int a, int b, int c, int d) : PairNum(a,b,c,d)
	{}
	MultiNum() :PairNum()
	{}

	int GetOlderPart1() {
		return olderPart1;
	}
	void SetOlderPart1(int n)
	{
		olderPart1 = n;
	}
	int GetOlderPart2() {
		return olderPart2;
	}
	void SetOlderPart2(int n)
	{
		olderPart2= n;
	}
	int GetYongerPart1() {
		return yongerPart1;
	}
	void SetYongerPart1(int n)
	{
		yongerPart1 = n;
	}
	int GetYongerPart2() {
		return yongerPart2;
	}
	void SetYongerPart2(int n)
	{
		yongerPart2 = n;
	}
	void ShowNum()
	{
		cout << "num1=" << olderPart1+yongerPart1 << endl;
		cout << "num2=" << olderPart2+yongerPart2 << endl;
	}
	int Multiplie()
	{
		int multi = (olderPart1 + yongerPart1) * (olderPart2 + yongerPart2);
		return multi;
	}
	int Add()
	{
		int add = (olderPart1 + yongerPart1) + (olderPart2 + yongerPart2);
		return add;
	}
	int Minus()
	{
		int min = (olderPart1 + yongerPart1) - (olderPart2 + yongerPart2);
		return min;
	}
};

int main()
{
	PairNum pairNum(2, 4, 6, 8);
	pairNum.PairSum();
	PairNum pairNumDef;
	pairNumDef.PairSum();
	MultiNum multiNum(3, 3, 2, 2);
	multiNum.ShowNum();
	cout << "Multiplie:" << multiNum.Multiplie() << endl;
	cout << "Add:" << multiNum.Add() << endl;
	cout << "Minus:" << multiNum.Minus() << endl;
}