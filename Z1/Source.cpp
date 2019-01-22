#include<iostream>
#include<cstdlib>
#include<ctime>
#include"Header.h"
int main()
{
	std::srand(static_cast<unsigned>(std::time(NULL)));
	Episode *ep1, *ep2;
	ep1 = new Episode();
	ep2 = new Episode(10, 64.39, 8.7);
	int viewers = 10;
	for (int i = 0; i < viewers; i++) {
		ep1->addView(generateRandomScore());
		std::cout << ep1->getMaxScore() << std::endl;
	}
	if (ep1->getAverageScore() > ep2->getAverageScore()) {
		std::cout << "Viewers: " << ep1->getViewerCount() << std::endl;
	}
	else {
		std::cout << "Viewers: " << ep2->getViewerCount() << std::endl;
	}
	delete ep1;
	delete ep2;
}