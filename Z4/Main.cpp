#include<iostream>
#include<string>
#include"Printer.h"
int main() {
	IPrinter* printer = new ConsolePrinter();
	//IPrinter* printer = new FilePrinter("name.txt");

	std::string fileName("shows.tv");
	std::vector<Episode> episodes = loadEpisodesFromFile(fileName);
	Season* season = new Season(episodes);

	printer->print(*season);
	season->add(Episode(100, 84.56, 9.88, Description(11, 45, "Christmas special")));
	printer->print(*season);
	try {
		season->remove("Pilot");
		season->remove("Nope.");
	}
	catch (const EpisodeNotFoundException& ex) {
		std::cout << ex.what() << ", Name: " << ex.getName() << "\n\n";
	}
	printer->print(*season);
	delete printer;
	delete season;
	system("pause");
}
