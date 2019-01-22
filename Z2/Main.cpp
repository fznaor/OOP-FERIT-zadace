#include<iostream>
#include<fstream>
#include"Header.h"
int main() {
	Description description(1, 45, "Pilot");
	std::cout << description << std::endl;
	Episode episode(10, 88.64, 9.78, description);
	std::cout << episode << std::endl;
	// Assume that the number of rows in the text file is always at least 10. 
	// Assume a valid input file.
	std::string fileName("shows.tv");
	const int COUNT = 10;

	std::ifstream input(fileName);
	Episode* episodes[COUNT];

	if (input.is_open() == false)
		return 1;

	for (int i = 0; i < COUNT; i++) {
		episodes[i] = new Episode();
		input >> *episodes[i];
	}
	input.close();
	std::cout << "Episodes:" << std::endl;
	print(episodes, COUNT);
	sort(episodes, COUNT);
	std::cout << "Sorted episodes:" << std::endl;
	print(episodes, COUNT);

	persistToFile("sorted.tv", episodes, COUNT);

	for (int i = 0; i < COUNT; i++) {
		delete episodes[i];
	}
	return 0;
}