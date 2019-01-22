#ifndef DESCRIPTION_H
#define DESCRIPTION_H
#include<iostream>
using namespace std;
class Description {
	friend ostream& operator<<(ostream&, const Description&);
	friend istream& operator>>(istream&, Description&);
	int mNumber;
	int mLength;
	string mName;
public:
	Description();
	Description(int, int, const string&);
	const string& getName()const;
	int getNumber()const;
	int getLength()const;
};
#endif 

