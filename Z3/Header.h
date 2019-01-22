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
	int getNumber()const;
	int getLength()const;
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

class Season {
	Episode** mEpisodes;
	int mCount;
public:
	Season();
	Season(Episode**, const int);
	Season(const Season&);
	~Season();
	float getAverageRating()const;
	int getTotalViews()const;
	const Episode& getBestEpisode()const;
	Season& operator=(const Season&);
	Episode& operator[](int);
	const Episode& operator[](int)const;
};

float generateRandomScore();
void print(Episode**, const int);
void swap(Episode**, Episode**);
void sort(Episode**, const int);
void persistToFile(const string&, Episode**, const int);
Episode** loadEpisodesFromFile(const string&, const int);
#endif
