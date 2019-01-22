#include<iostream>
#include<cstdlib>
#include<string>
#include<fstream>
#include"Header.h"
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

Episode::Episode() :mViewers(0), mTotalScore(0), mMaxScore(0), mDescription(Description()) {}
Episode::Episode(int viewers, float totalScore, float maxScore, const Description& dscrptn) : mViewers(viewers), mTotalScore(totalScore), mMaxScore(maxScore), mDescription(dscrptn) {}
void Episode::addView(float score) {
	mViewers++;
	mTotalScore += score;
	if (score > mMaxScore)	mMaxScore = score;
}
int Episode::getViewerCount()const {
	return mViewers;
}
float Episode::getAverageScore()const {
	return mTotalScore / mViewers;
}
float Episode::getMaxScore()const {
	return mMaxScore;
}
const Description& Episode::getDescription()const {
	return mDescription;
}
ostream& operator<<(ostream& out, const Episode& ep) {
	out << ep.mViewers << " ," << ep.mTotalScore << "," << ep.mMaxScore << "," << ep.mDescription;
	return out;
}
istream& operator>>(istream& in, Episode& ep) {
	char ignoreComma;
	in >> ep.mViewers >> ignoreComma >> ep.mTotalScore >> ignoreComma >> ep.mMaxScore >> ep.mDescription;
	return in;
}
bool operator==(const Episode& lhs, const Episode& rhs) {
	return lhs.mViewers == rhs.mViewers && lhs.mTotalScore == rhs.mTotalScore && lhs.mMaxScore == rhs.mMaxScore && lhs.getDescription().getNumber()==rhs.getDescription().getNumber()
			&& lhs.getDescription().getLength()==rhs.getDescription().getLength() && lhs.getDescription().getName()==rhs.getDescription().getName(); 
}
bool operator!=(const Episode& lhs, const Episode& rhs) {
	return !operator==(lhs, rhs);
}
bool operator<(const Episode& lhs, const Episode& rhs) {
	return lhs.getDescription().getName()[0] < rhs.getDescription().getName()[0];
}
bool operator>(const Episode& lhs, const Episode& rhs) {
	return operator<(rhs, lhs);
}
bool operator>=(const Episode& lhs, const Episode& rhs) {
	return !operator<(lhs, rhs);
}
bool operator<=(const Episode& lhs, const Episode& rhs) {
	return !operator>(lhs, rhs);
}

Season::Season() :mEpisodes(NULL), mCount(0) {}
Season::Season(Episode** eps, const int count) :mEpisodes(new Episode*[count]), mCount(count) {
	for (int i = 0; i < count; i++)
		mEpisodes[i] = new Episode(*eps[i]);
}
Season::Season(const Season& s) : mEpisodes(new Episode*[s.mCount]), mCount(s.mCount) {
	for (int i = 0; i < s.mCount; i++)
		mEpisodes[i] = new Episode(s[i]);
}
Season::~Season() {
	for (int i = 0; i < mCount; i++)
		delete mEpisodes[i];
	delete[] mEpisodes;
}
float Season::getAverageRating()const {
	float sum = 0;
	for (int i = 0; i < mCount; i++)
		sum += mEpisodes[i]->getAverageScore();
	return sum / mCount;
}
int Season::getTotalViews()const {
	int sum = 0;
	for (int i = 0; i < mCount; i++)
		sum += mEpisodes[i]->getViewerCount();
	return sum;
}
const Episode& Season::getBestEpisode()const {
	float bestMaxScore = mEpisodes[0]->getMaxScore();
	int indexOfBestEpisode = 0;
	for(int i=1;i<mCount;i++)
		if (mEpisodes[i]->getMaxScore() > bestMaxScore) {
			bestMaxScore = mEpisodes[i]->getMaxScore();
			indexOfBestEpisode = i;
		}
	return *mEpisodes[indexOfBestEpisode];
}
Season& Season::operator=(const Season& s) {
	if (&s == this)return *this;
	if (mEpisodes) {
		for (int i = 0; i < mCount; i++)
			delete mEpisodes[i];
		delete[]mEpisodes;
	}
	mCount = s.mCount;
	mEpisodes = new Episode*[mCount];
	for (int i = 0; i < mCount; i++)
		mEpisodes[i] = new Episode(s[i]);
	return *this;
}
const Episode& Season::operator[](int index)const {
	return *mEpisodes[index];
}
Episode& Season::operator[](int index) {
	return *mEpisodes[index];
}

float generateRandomScore() {
	return static_cast<float>(std::rand()) / RAND_MAX * 10;
}
void print(Episode** eps, const int count) {
	for (int i = 0; i < count; i++)
		cout << i << ". " << *eps[i] << endl;
}
void swap(Episode** ep1, Episode** ep2) {
	Episode *temp;
	temp = *ep1;
	*ep1 = *ep2;
	*ep2 = temp;
}
void sort(Episode** eps, const int count) {
	for (int i = 0; i < count - 1; i++)
		for (int j = 0; j < count - 1 - i; j++)
			if (*eps[j] > *eps[j + 1])
				swap(&eps[j], &eps[j + 1]);
}
void persistToFile(const string& filename, Episode** eps, const int count) {
	ofstream file(filename);
	if (file.is_open() == false)
		return;
	for (int i = 0; i < count; i++)
		file << *eps[i] << endl;
	file.close();
}
Episode** loadEpisodesFromFile(const string& filename, const int count) {
	ifstream input(filename);
	Episode** episodes = new Episode*[count];
	if (input.is_open() == false)
		return NULL;
	for (int i = 0; i < count; i++) {
		episodes[i] = new Episode();
		input >> *episodes[i];
	}
	input.close();
	return episodes;
}