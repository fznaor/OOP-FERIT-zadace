#ifndef HEADER_H
#define HEADER_H
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
};

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
void persistToFile(string, Episode**, const int);
#endif
