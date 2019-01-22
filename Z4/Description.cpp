#include<string>
#include"Description.h"
Description::Description() :mNumber(0), mLength(0), mName("Default") {}
Description::Description(int num, int length, const string& name) : mNumber(num), mLength(length), mName(name) {}
const string& Description::getName()const {
	return mName;
}
int Description::getNumber()const {
	return mNumber;
}
int Description::getLength()const {
	return mLength;
}
ostream& operator<<(ostream& out, const Description& dscrptn) {
	out << dscrptn.mNumber << "," << dscrptn.mLength << "," << dscrptn.mName;
	return out;
}
istream& operator>>(istream& in, Description& dscrpt) {
	char ignoreComma;
	in >> ignoreComma >> dscrpt.mNumber >> ignoreComma >> dscrpt.mLength >> ignoreComma;
	getline(in, dscrpt.mName);
	return in;
}