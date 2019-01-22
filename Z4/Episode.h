#ifndef EPISODE_H
#define EPISODE_H
#include"Description.h"
class Episode {
	friend ostream& operator<<(ostream&, const Episode&);
	friend istream& operator>>(istream&, Episode&);
	friend bool operator== (const Episode&, const Episode&);
	friend bool operator!= (const Episode&, const Episode&);
	friend bool operator> (const Episode&, const Episode&);
	friend bool operator< (const Episode&, const Episode&);
	friend bool operator>= (const Episode&, const Episode&);
	friend bool operator<= (const Episode&, const Episode&);
	int mViewers;
	float mTotalScore;
	float mMaxScore;
	Description mDescription;
public:
	Episode();
	Episode(int, float, float, const Description&);
	void addView(float);
	int getViewerCount()const;
	float getAverageScore()const;
	float getMaxScore()const;
	const Description& getDescription()const;
};

float generateRandomScore();
void print(Episode**, const int);
void swap(Episode**, Episode**);
void sort(Episode**, const int);
void persistToFile(const string&, Episode**, const int);
#endif
