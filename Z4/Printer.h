#ifndef PRINTER_H
#define PRINTER_H
#include"Season.h"
class IPrinter {
public:
	virtual void print(const Season&)const = 0;
};

class ConsolePrinter :public IPrinter {
public:
	virtual void print(const Season&)const;
};

class FilePrinter :public IPrinter {
	string mFilename;
public:
	FilePrinter(const string&);
	virtual void print(const Season&)const;
};
#endif
