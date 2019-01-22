#include"Printer.h"
#include<fstream>
void ConsolePrinter::print(const Season& s)const {
	cout << "******************************" << endl;
	for (const Episode& e : s.getEpisodes())
		cout << e << endl;
	cout << "******************************" << endl << endl;
}

FilePrinter::FilePrinter(const string& name) :mFilename(name) {}
void FilePrinter::print(const Season& s)const {
	ofstream file(mFilename, ios::app);
	if (!file.is_open())
		return;
	file << "******************************" << endl;
	for (const Episode&e : s.getEpisodes())
		file << e << endl;
	file << "******************************" << endl << endl;
	file.close();
}
